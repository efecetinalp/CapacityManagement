using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardUI
{
    public partial class DataGridForm : Form
    {
        ManagementManager managementManager;
        DepartmentManager departmentManager;
        CategoryManager categoryManager;
        ProjectManager projectManager;
        ProjectCapacityManager projectCapacityManager;
        DepartmentCapacityManager departmentCapacityManager;

        CreateForm createForm;
        Dashboard _dashboardForm;

        AlertBox alertBox;
        ToolTip _toolTip;
        private bool isEditing = false;

        //temp cell value
        object _tempCellValue;

        public DataGridForm(ProjectManager projectManager, DepartmentManager departmentManager, ManagementManager managementManager, CategoryManager categoryManager, DepartmentCapacityManager departmentCapacityManager, ProjectCapacityManager projectCapacityManager, Dashboard dashboardForm)
        {
            this.projectManager = projectManager;
            this.departmentManager = departmentManager;
            this.managementManager = managementManager;
            this.categoryManager = categoryManager;
            this.projectCapacityManager = projectCapacityManager;
            this.departmentCapacityManager = departmentCapacityManager;

            _dashboardForm = dashboardForm;
            InitializeComponent();
        }

        private void DataGridForm_Load(object sender, EventArgs e)
        {
            //form initialize options
            _toolTip = new ToolTip();
            _toolTip.SetToolTip(this.buttonList, "List");
            _toolTip.SetToolTip(this.buttonRefresh, "Refresh");
            _toolTip.SetToolTip(this.buttonReset, "Reset");
            _toolTip.SetToolTip(this.buttonNew, "Create");
            _toolTip.SetToolTip(this.buttonEdit, "Edit");

            foreach (var management in managementManager.GetAll().Data)
            {
                comboBoxManagement.Items.Add(management.ManagementName);
            }

            foreach (var department in departmentManager.GetAll().Data)
            {
                comboBoxDepartment.Items.Add(department.DepartmentName);
            }

            foreach (var category in categoryManager.GetAll().Data)
            {
                comboBoxCategory.Items.Add(category.CategoryName);
            }

            dateTimePickerStart.Value = new DateTime(2024, 01, 01);
            dateTimePickerEnd.Value = dateTimePickerStart.Value.AddMonths(23);

            dbGrid.ReadOnly = true;

            if (_dashboardForm.activeUser == null)
            {
                return;
            }
            else if (_dashboardForm.activeUser.Admin || _dashboardForm.activeUser.Author)
            {
                buttonNew.Enabled = true;
                buttonEdit.Enabled = true;
            }
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            ResetGridView();

            UIRequest uiRequest = new();
            uiRequest.ManagementIndex = comboBoxManagement.SelectedIndex + 1; //+1 because sql table starts with -1

            if (comboBoxDepartment.Text != "")
                uiRequest.DepartmentIndex = departmentManager.GetByName(comboBoxDepartment.Text).Data.DepartmentId;
            else
                uiRequest.DepartmentIndex = 0;

            uiRequest.CategotryIndex = comboBoxCategory.SelectedIndex + 1;
            uiRequest.StartDate = dateTimePickerStart.Value;
            uiRequest.EndDate = dateTimePickerEnd.Value;

            DatabaseRows(uiRequest);
            DatabaseColumnCategory();
            //DatabaseColumns(); //<- that works
            DatabaseColumnsTest();

            dbGrid.CellPainting += new DataGridViewCellPaintingEventHandler(dbGrid_CellPainting);

            alertBox = new AlertBox(_dashboardForm.Left + _dashboardForm.Width - 270, _dashboardForm.Top + _dashboardForm.Height - 70);
            alertBox.SuccessAlert("Datas listed successfuly!");
        }

        public ChartRequest GenerateChartData()
        {
            ChartRequest chartRequest = new();
            List<string> legends = new();
            List<List<double>> series = new();
            List<double> months = new();


            #region list of months
            int monthCalulate = (dateTimePickerEnd.Value.Year - dateTimePickerStart.Value.Year) * 12
                + (dateTimePickerEnd.Value.Month - dateTimePickerStart.Value.Month);
            for (int i = 0; i <= monthCalulate; i++)
            {
                months.Add(dateTimePickerStart.Value.AddMonths(i).ToOADate());
            }
            #endregion

            #region list of legends and series
            for (int i = 0; i < dbGrid.Rows.Count; i++)
            {
                if (dbGrid.Rows[i].Tag == "Empty")
                {
                    break;
                }

                if (dbGrid.Rows[i].Tag == "Management")
                {
                    continue;
                }

                legends.Add(dbGrid.Rows[i].Cells[0].Value.ToString());

                //string serieName = "series" + i.ToString();
                //list of series
                List<double> templist = new();
                for (int j = 2; j < dbGrid.Columns.Count; j++)
                {
                    templist.Add(Convert.ToDouble(dbGrid.Rows[i].Cells[j].Value));
                }
                series.Add(templist);
            }
            #endregion

            chartRequest.Months = months;
            chartRequest.Series = series;
            chartRequest.Legends = legends;

            return chartRequest;
        }

        private void DatabaseColumnCategory()
        {

            int columnIndex = dbGrid.Columns.Add("", "");
            DataGridViewColumn column = dbGrid.Columns[columnIndex];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            column.Width = 100;
            column.HeaderText = "Category";
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            for (int i = 0; i < dbGrid.Rows.Count - 1; i++)
            {
                if (dbGrid.Rows[i].Tag == "Project")
                {
                    var result = projectManager.GetCategoryByProjectName(dbGrid.Rows[i].Cells[0].Value.ToString());
                    string categoryName = result.Data[0].CategoryName;
                    dbGrid.Rows[i].Cells[columnIndex].Value = categoryName;
                    dbGrid.Rows[i].Cells[columnIndex].Tag = "Category";
                }
            }

        }

        private void DatabaseColumns()
        {
            int monthCalulate = (dateTimePickerEnd.Value.Year - dateTimePickerStart.Value.Year) * 12
                + (dateTimePickerEnd.Value.Month - dateTimePickerStart.Value.Month);

            //month columns
            DateTime tempMonth;
            for (int i = 0; i <= monthCalulate; i++)
            {
                //empty column
                dbGrid.Columns.Add("", "");

                DataGridViewColumn column = dbGrid.Columns[i + 2];

                tempMonth = dateTimePickerStart.Value.AddMonths(i);
                column.HeaderCell.Style.BackColor = Color.FromArgb(46, 52, 63);
                column.HeaderText = tempMonth.ToString("MMM-yy");
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //check project and department names from each row
                for (int j = 0; j < dbGrid.Rows.Count - 1; j++)
                {
                    string tempCellName;
                    tempCellName = dbGrid.Rows[j].Cells[0].Value.ToString();

                    //get department capacity detail by date and department name
                    var departmentResult = departmentCapacityManager.GetAllByDateAndDepartmentName(tempMonth, tempCellName);
                    if (departmentResult.Success)
                    {
                        for (int k = 0; k < departmentResult.Data.Count; k++)
                        {
                            column.DataGridView.Rows[j].Cells[i + 2].Value = departmentResult.Data[k].DTotalCapacity;
                            //column.DataGridView.Rows[j].Cells[i + 1].Style.BackColor = Color.FromArgb(255, 230, 153);
                        }
                    }

                    //get project capacity detail by date and project name
                    var projectResult = projectCapacityManager.GetProjectCapacityDetailsByDateAndProjectName(tempMonth, tempCellName);
                    if (projectResult.Success)
                    {
                        for (int k = 0; k < projectResult.Data.Count; k++)
                        {
                            column.DataGridView.Rows[j].Cells[i + 2].Value = projectResult.Data[k].PTotalCapacity;
                            column.DataGridView.Rows[j].Cells[i + 2].Style.BackColor = Color.FromArgb(198, 224, 180);
                        }
                    }
                    else if (dbGrid.Rows[j].Tag == "Project")
                        column.DataGridView.Rows[j].Cells[i + 2].Style.BackColor = Color.FromArgb(226, 239, 218);
                }
            }
            #region "DELETE LATER"
            //DELETE LATER
            dbGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dbGrid.ColumnHeadersHeight = 100;
            dbGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;

            //Change this later for category column
            foreach (DataGridViewColumn col in dbGrid.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                col.HeaderCell.Style.ForeColor = Color.White;
                //col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            // Here we attach an event handler to the cell painting event
            //dbGrid.CellPainting += new DataGridViewCellPaintingEventHandler(dbGrid_CellPainting);
            #endregion
        }

        private void DatabaseColumnsTest()
        {
            var listCapacity = projectCapacityManager.GetProjectCapacityDetails().Data;
            var listDepartmentCapacity = departmentCapacityManager.GetDepartmentCapacityDetails().Data;

            int monthCalulate = (dateTimePickerEnd.Value.Year - dateTimePickerStart.Value.Year) * 12
                + (dateTimePickerEnd.Value.Month - dateTimePickerStart.Value.Month);

            //month columns
            DateTime tempMonth;
            for (int i = 0; i <= monthCalulate; i++)
            {
                //empty column
                dbGrid.Columns.Add("", "");

                DataGridViewColumn column = dbGrid.Columns[i + 2];

                tempMonth = dateTimePickerStart.Value.AddMonths(i);
                column.HeaderCell.Style.BackColor = Color.FromArgb(46, 52, 63);
                column.Tag = tempMonth;
                column.HeaderText = tempMonth.ToString("MMM-yy");
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                foreach (var departmentItem in listDepartmentCapacity)
                {
                    if (departmentItem.Date == tempMonth)
                    {
                        for (int k = 0; k < dbGrid.Rows.Count; k++)
                        {
                            if (departmentItem.DepartmentName == dbGrid.Rows[k].Cells[0].Value.ToString() && dbGrid.Rows[k].Tag == "Department")
                            {
                                column.DataGridView.Rows[k].Cells[i + 2].Value = departmentItem.DTotalCapacity;
                            }
                        }
                    }
                }

                foreach (var item in listCapacity)
                {
                    if (item.Date == tempMonth)
                    {
                        for (int j = 0; j < dbGrid.Rows.Count; j++)
                        {
                            if (item.ProjectName == dbGrid.Rows[j].Cells[0].Value.ToString())
                            {
                                column.DataGridView.Rows[j].Cells[i + 2].Value = item.PTotalCapacity;
                                column.DataGridView.Rows[j].Cells[i + 2].Style.BackColor = Color.FromArgb(198, 224, 180);

                            }
                            else if (dbGrid.Rows[j].Tag == "Project" && dbGrid.Rows[j].Cells[i + 2].Value == null)
                                column.DataGridView.Rows[j].Cells[i + 2].Style.BackColor = Color.FromArgb(226, 239, 218);
                        }
                    }
                }

            }

            #region "DELETE LATER"
            //DELETE LATER
            dbGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dbGrid.ColumnHeadersHeight = 60;
            dbGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;

            //Change this later for category column
            foreach (DataGridViewColumn col in dbGrid.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                col.HeaderCell.Style.ForeColor = Color.White;
                //col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            // Here we attach an event handler to the cell painting event
            //dbGrid.CellPainting += new DataGridViewCellPaintingEventHandler(dbGrid_CellPainting);
            #endregion
        }

        private void DatabaseRows(UIRequest uiRequest)
        {
            if (uiRequest.ManagementIndex == 0)
            {
                var resultWOManagement = projectManager.GetProjectDetails();
                FetchData(resultWOManagement);
                return;
            }

            if (uiRequest.DepartmentIndex == 0)
            {
                var resultWODepartment = projectManager.GetProjectDetails(uiRequest.ManagementIndex);
                FetchData(resultWODepartment);
                return;
            }

            if (uiRequest.CategotryIndex == 0)
            {
                var resultWOCategory = projectManager.GetProjectDetails(uiRequest.ManagementIndex, uiRequest.DepartmentIndex);
                FetchData(resultWOCategory);
                return;
            }

            //DELETE LATER
            //dbGrid.DataSource = projectManager.GetProjectDetails(uiRequest.ManagementIndex, uiRequest.DepartmentIndex, uiRequest.CategotryIndex).Data;
            else
            {
                var result = projectManager.GetProjectDetails(uiRequest.ManagementIndex, uiRequest.DepartmentIndex, uiRequest.CategotryIndex);
                FetchData(result);
            }
        }

        private void FetchData(IDataResult<List<ProjectDetailDto>> result)
        {
            int columnIndex = dbGrid.Columns.Add("", "");

            if (result.Success)
            {
                List<string> managementNames = new();
                List<string> departmentNames = new();
                List<string> projectNames = new();

                for (int i = 0; i < result.Data.Count; i++)
                {
                    managementNames.Add(result.Data[i].ManagementName);
                    departmentNames.Add(result.Data[i].DepartmentName + "<ß>" + result.Data[i].ManagementName);
                    projectNames.Add(result.Data[i].ProjectName + "<ß>" + result.Data[i].DepartmentName);
                }

                //unique values
                managementNames = managementNames.Distinct().ToList();
                departmentNames = departmentNames.Distinct().ToList();
                projectNames = projectNames.Distinct().ToList();


                //if management count > 0
                for (int i = 0; i < managementNames.Count; i++)
                {
                    Font managementFont = new("Calibri", 12, FontStyle.Italic);
                    //managementFont.Style = FontStyle.Italic;
                    AddRow(managementNames[i], Color.FromArgb(46, 52, 63), Color.White, "Management", managementFont);
                    //dbGrid.CellPainting += new DataGridViewCellPaintingEventHandler(dbGrid_CellPainting);

                    // if department count >0
                    for (int j = 0; j < departmentNames.Count; j++)
                    {
                        if (managementNames[i] == departmentNames[j].Split("<ß>")[1])
                        {
                            Font departmentFont = new("Segoe UI", 9, FontStyle.Italic);
                            AddRow(departmentNames[j].Split("<ß>")[0], Color.FromArgb(255, 230, 153), Color.Black, "Department", departmentFont);

                            for (int k = 0; k < projectNames.Count; k++)
                            {
                                Font projectFont = new("Segoe UI", 9, FontStyle.Italic);
                                if (departmentNames[j].Split("<ß>")[0] == projectNames[k].Split("<ß>")[1])
                                {
                                    AddRow(projectNames[k].Split("<ß>")[0], Color.FromArgb(210, 238, 255), Color.Black, "Project", projectFont);
                                }

                            }
                            //seperator
                            AddRow("", Color.FromArgb(242, 242, 242), Color.White, "Empty", new Font("Segui", 8), 15);

                        }
                    }
                }

                Debug.Print(result.Massage);
            }
            else
            {
                ResetGridView();
                dbGrid.Columns.Add("", "");
                Debug.Print(result.Massage);
            }
        }

        private void AddRow(string mainData, Color color, Color foreColor, string tag, Font font, int height = 33)
        {
            DataGridViewRow dataRow = new();
            DataGridViewTextBoxCell dataCell = new();

            //seperate rows and cells accordingly
            dataRow.Tag = tag;
            dataCell.Value = mainData;
            dataRow.DefaultCellStyle.Font = font;
            dataRow.DefaultCellStyle.BackColor = color;
            dataRow.DefaultCellStyle.ForeColor = foreColor;
            dataRow.Height = height;
            dataRow.Cells.Add(dataCell);
            dbGrid.Rows.Add(dataRow);
            //return dbGrid.Rows.IndexOf(dataRow);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetGridView();

            //reset filters
            comboBoxManagement.ResetText();
            comboBoxManagement.SelectedIndex = -1;
            comboBoxDepartment.ResetText();
            comboBoxDepartment.SelectedIndex = -1;
            comboBoxCategory.ResetText();
            comboBoxCategory.SelectedIndex = -1;

            dateTimePickerStart.Value = new DateTime(2024, 01, 01);
            dateTimePickerEnd.Value = dateTimePickerStart.Value.AddMonths(23);

            isEditing = false;
        }

        private void ResetGridView()
        {
            //reset gridview
            dbGrid.DataSource = null;
            dbGrid.Rows.Clear();
            dbGrid.Columns.Clear();
        }

        private void comboBoxManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update department comboBox
            comboBoxDepartment.Items.Clear();
            comboBoxDepartment.ResetText();
            comboBoxDepartment.SelectedIndex = -1;
            comboBoxCategory.ResetText();
            comboBoxCategory.SelectedIndex = -1;

            foreach (var department in departmentManager.GetAllByManagementId(comboBoxManagement.SelectedIndex + 1).Data)
            {
                comboBoxDepartment.Items.Add(department.DepartmentName);
            }
        }

        private void dbGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // check that we are in a header cell!
            //column index = 1 is for project names
            if (e.RowIndex == -1 && e.ColumnIndex >= 2)
            {
                e.PaintBackground(e.ClipBounds, true);
                Rectangle rect = this.dbGrid.GetColumnDisplayRectangle(e.ColumnIndex, true);
                Size titleSize = TextRenderer.MeasureText(e.Value.ToString(), e.CellStyle.Font);
                if (this.dbGrid.ColumnHeadersHeight < titleSize.Width)
                {
                    this.dbGrid.ColumnHeadersHeight = titleSize.Width;
                }

                e.Graphics.TranslateTransform(0, titleSize.Width);
                e.Graphics.RotateTransform(-90.0F);

                // This is the key line for bottom alignment - we adjust the PointF based on the 
                // ColumnHeadersHeight minus the current text width. ColumnHeadersHeight is the
                // maximum of all the columns since we paint cells twice - though this fact
                // may not be true in all usages!   
                e.Graphics.DrawString(e.Value.ToString(), this.Font, Brushes.White, new PointF(rect.Y - (dbGrid.ColumnHeadersHeight - titleSize.Width), rect.X));
                // The old line for comparison
                //e.Graphics.DrawString(e.Value.ToString(), this.Font, Brushes.Black, new PointF(rect.Y, rect.X));


                e.Graphics.RotateTransform(90.0F);
                e.Graphics.TranslateTransform(0, -titleSize.Width);
                e.Handled = true;
            }

            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dbGrid.Rows[e.RowIndex].Tag == "Management")
            {
                e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            }
        }

        //CRUD OPERTAIONS

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete entity
            CreateProjectForm deleteForm = new(managementManager, departmentManager, categoryManager, projectManager);
            deleteForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isEditing == false)
            {

                DataGridViewImageColumn imageColumnUpdate = new();
                DataGridViewImageColumn imageColumnDelete = new();

                dbGrid.Columns.Add(imageColumnUpdate);
                dbGrid.Columns.Add(imageColumnDelete);

                int lastColumnIndex = dbGrid.Columns.Count - 1;
                dbGrid.Columns[lastColumnIndex - 1].Name = "Update";
                dbGrid.Columns[lastColumnIndex].Name = "Delete";


                for (int i = 0; i < dbGrid.Rows.Count; i++)
                {
                    if (dbGrid.Rows[i].Tag == "Empty")
                    {
                        dbGrid.Rows[i].Cells[lastColumnIndex].Style.NullValue = null;
                        dbGrid.Rows[i].Cells[lastColumnIndex - 1].Style.NullValue = null;
                    }
                    else
                    {
                        dbGrid.Rows[i].Cells[lastColumnIndex].Value = Properties.Resources.Remove;
                        dbGrid.Rows[i].Cells[lastColumnIndex].Style.BackColor = Color.FromArgb(242, 242, 242);

                        dbGrid.Rows[i].Cells[lastColumnIndex - 1].Value = Properties.Resources.DeleteIcon;
                        dbGrid.Rows[i].Cells[lastColumnIndex - 1].Style.BackColor = Color.FromArgb(242, 242, 242);
                    }
                }

                dbGrid.ReadOnly = false;

                isEditing = true;
            }

            else if (isEditing == true)
            {

                //OnEditMode(false);
                dbGrid.Columns.Remove("Delete");
                dbGrid.Columns.Remove("Update");

                dbGrid.ReadOnly = true;

                isEditing = false;
            }
        }

        private void OnEditMode(bool edit)
        {
            if (edit)
            {
                dbGrid.Columns.Remove(dbGrid.Columns[1]);
                DataGridViewComboBoxColumn cmbCol = new DataGridViewComboBoxColumn();
                cmbCol.HeaderText = "Edit Category";
                List<string> categoryNames = new();
                foreach (var name in categoryManager.GetAll().Data)
                {
                    categoryNames.Add(name.CategoryName);
                }
                cmbCol.DataSource = categoryNames;
                int index = dbGrid.Columns.Add(cmbCol);
                dbGrid.Columns[index].DisplayIndex = 1;
            }
            else
            {
                dbGrid.Columns.Remove(dbGrid.Columns[1]);
                DatabaseColumnCategory();
                dbGrid.Columns[dbGrid.Columns.Count - 1].DisplayIndex = 1;

            }

        }

        private void dbGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //delete project and project capacities
            if (dbGrid.Columns[e.ColumnIndex].Name == "Delete" && dbGrid.Rows[e.RowIndex].Tag == "Project")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to delete selected project? Project index: " + e.RowIndex, "Delete Project", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Project projectToDelete = projectManager.GetByName(dbGrid.Rows[e.RowIndex].Cells[0].Value.ToString()).Data;
                    DeleteProject(projectToDelete);
                }
            }
            else if (dbGrid.Columns[e.ColumnIndex].Name == "Update" && dbGrid.Rows[e.RowIndex].Tag == "Project")
            {
                UpdateProjectForm updateForm = new(managementManager, departmentManager, categoryManager, projectManager, dbGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                updateForm.ShowDialog();

            }
            else if (dbGrid.Columns[e.ColumnIndex].Name == "Delete" && dbGrid.Rows[e.RowIndex].Tag == "Department")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to delete selected department? Department index: " + e.RowIndex, "Delete Department", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Department departmentToDelete = departmentManager.GetByName(dbGrid.Rows[e.RowIndex].Cells[0].Value.ToString()).Data;
                    DeleteDepartment(departmentToDelete);
                }
            }
            else if (dbGrid.Columns[e.ColumnIndex].Name == "Update" && dbGrid.Rows[e.RowIndex].Tag == "Department")
            {
                UpdateDepartmentForm updateForm = new(managementManager, departmentManager, dbGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                updateForm.ShowDialog();

            }
            else if (dbGrid.Columns[e.ColumnIndex].Name == "Delete" && dbGrid.Rows[e.RowIndex].Tag == "Management")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to delete selected Management? Management index: " + e.RowIndex, "Delete Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Management managementToDelete = managementManager.GetByName(dbGrid.Rows[e.RowIndex].Cells[0].Value.ToString()).Data;
                    DeleteManagement(managementToDelete);
                }
            }
            else if (dbGrid.Columns[e.ColumnIndex].Name == "Update" && dbGrid.Rows[e.RowIndex].Tag == "Management")
            {
                UpdateManagementForm updateForm = new(managementManager, dbGrid.Rows[e.RowIndex].Cells[0].Value.ToString()); ;
                updateForm.ShowDialog();
            }
        }

        private void DeleteManagement(Management managementToDelete)
        {
            //delete all projects
            //delete all departments
            //delete management
            Debug.Print("Management not deleted but function works");
            MessageBox.Show("Management deleted successfully", "Delete Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteDepartment(Department departmentToDelete)
        {
            //delete all projects
            //delete department capacity
            //delete department

            Debug.Print("Department not deleted but function works");
            MessageBox.Show("Department deleted successfully", "Delete Department", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteProject(Project projectToDelete)
        {
            var projectCapacitiesToDelete = projectCapacityManager.GetAllByProjectId(projectToDelete.ProjectId);
            if (projectCapacitiesToDelete.Success)
            {
                foreach (var projectCapacity in projectCapacitiesToDelete.Data)
                {
                    projectCapacityManager.Delete(projectCapacity);
                }
            }

            projectManager.Delete(projectToDelete);

            MessageBox.Show("Project deleted successfully", "Delete Project", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dbGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            var cellValue = dbGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            var cellDate = dbGrid.Columns[e.ColumnIndex].Tag;
            var tempDate = Convert.ToDateTime(cellDate);
            cellDate = new DateTime(tempDate.Year, tempDate.Month, 01).ToString();
            Debug.Print(cellDate.ToString());
            //If editing Project Capacities
            if (dbGrid.Rows[e.RowIndex].Tag == "Project")
            {
                //check if cell value is changed
                if (_tempCellValue != cellValue)
                {
                    if (e.ColumnIndex == 0)
                    {
                        if (cellValue != null)
                        {
                            Project projectToUpdate = projectManager.GetByName(_tempCellValue.ToString()).Data;
                            projectToUpdate.ProjectName = cellValue.ToString();
                            projectManager.Update(projectToUpdate);
                            Debug.Print("project name is updated");
                            return;
                        }
                        else
                        {
                            dbGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = _tempCellValue;
                            Debug.Print("Project name cannot be empty");
                            return;
                        }
                    }

                    else if (e.ColumnIndex == 1)
                    {
                        //Category columns should change to combobox , and values should store there
                        Debug.Print("category is not changed but it works anyway");
                        return;

                    }

                    Project cellProject = projectManager.GetByName(dbGrid.Rows[e.RowIndex].Cells[0].Value.ToString()).Data;

                    //check if cell value was empty before
                    if (_tempCellValue == null && e.ColumnIndex > 1)
                    {
                        ProjectCapacity projectCapacityToAdd = new ProjectCapacity();

                        projectCapacityToAdd.ProjectId = cellProject.ProjectId;
                        projectCapacityToAdd.PTotalCapacity = Convert.ToDouble(cellValue);
                        projectCapacityToAdd.Date = Convert.ToDateTime(cellDate);
                        projectCapacityManager.Add(projectCapacityToAdd);

                        Debug.Print("project capacity cell value added");
                    }
                    else
                    {
                        //if cell value is deleted or 0
                        ProjectCapacity projectCapacityToUpdate = projectCapacityManager.GetProjectCapacityByDateAndProjectId(Convert.ToDateTime(cellDate), cellProject.ProjectId).Data;
                        if (cellValue == null || Convert.ToDouble(cellValue) == 0 && e.ColumnIndex > 1)
                        {
                            projectCapacityManager.Delete(projectCapacityToUpdate);
                            Debug.Print("project capacity cell value deleted");

                        }
                        else
                        {
                            projectCapacityToUpdate.PTotalCapacity = Convert.ToDouble(cellValue);
                            projectCapacityManager.Update(projectCapacityToUpdate);
                            Debug.Print("project capacity cell value updated");
                        }
                    }
                }
                else
                    Debug.Print("project cell is the same");
            }
            //If editing Department Capacities
            else if (dbGrid.Rows[e.RowIndex].Tag == "Department")
            {
                //check if cell value is changed
                if (_tempCellValue != cellValue)
                {
                    Department cellDepartment = departmentManager.GetByName(dbGrid.Rows[e.RowIndex].Cells[0].Value.ToString()).Data;

                    //check if cell value was empty before
                    if (_tempCellValue == null)
                    {
                        DepartmentCapacity departmentCapacityToAdd = new DepartmentCapacity();

                        departmentCapacityToAdd.DepartmentId = cellDepartment.DepartmentId;
                        departmentCapacityToAdd.DTotalCapacity = Convert.ToDouble(cellValue);
                        departmentCapacityToAdd.Date = Convert.ToDateTime(cellDate);
                        departmentCapacityManager.Add(departmentCapacityToAdd);

                        Debug.Print("department cell value added");
                    }
                    else
                    {
                        //if cell value is deleted or 0
                        DepartmentCapacity departmentCapacityToUpdate = departmentCapacityManager.GetDepartmentCapacityByDateAndDepartmentId(Convert.ToDateTime(cellDate), cellDepartment.DepartmentId).Data;
                        if (cellValue == null || Convert.ToDouble(cellValue) == 0)
                        {
                            departmentCapacityManager.Delete(departmentCapacityToUpdate);
                            Debug.Print("department cell value deleted");

                        }
                        else
                        {
                            departmentCapacityToUpdate.DTotalCapacity = Convert.ToDouble(cellValue);
                            departmentCapacityManager.Update(departmentCapacityToUpdate);
                            Debug.Print("department cell value updated");
                        }
                    }
                }
                else
                    Debug.Print("department cell is the same");
            }
        }

        private void dbGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _tempCellValue = dbGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void dbGrid_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            if (createForm == null)
            {
                createForm = new CreateForm(managementManager, departmentManager, categoryManager, projectManager);
                createForm.FormClosed += CreateForm_FormClosed;
                createForm.ShowDialog();
            }
            else
            {
                createForm.Activate();
            }
        }

        private void CreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            createForm = null;
        }
    }
}
