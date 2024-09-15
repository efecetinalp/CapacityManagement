using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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

        //temp cell value
        object _tempCellValue;

        public DataGridForm(ProjectManager projectManager, DepartmentManager departmentManager, ManagementManager managementManager, CategoryManager categoryManager, DepartmentCapacityManager departmentCapacityManager, ProjectCapacityManager projectCapacityManager)
        {
            this.projectManager = projectManager;
            this.departmentManager = departmentManager;
            this.managementManager = managementManager;
            this.categoryManager = categoryManager;
            this.projectCapacityManager = projectCapacityManager;
            this.departmentCapacityManager = departmentCapacityManager;

            InitializeComponent();
        }

        private void DataGridForm_Load(object sender, EventArgs e)
        {
            //form initialize options

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

            dateTimePickerStart.Value = new DateTime(2023, 01, 01);
            dateTimePickerEnd.Value = dateTimePickerStart.Value.AddMonths(23);

            dbGrid.ReadOnly = true;
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            ResetGridView();

            UIRequest uiRequest = new();
            uiRequest.ManagementIndex = comboBoxManagement.SelectedIndex + 1; //+1 because sql table starts with -1

            if (comboBoxDepartment.Text != "")
                uiRequest.DepartmentIndex = departmentManager.GetByDepartmentName(comboBoxDepartment.Text).Data.DepartmentId;
            else
                uiRequest.DepartmentIndex = 0;

            uiRequest.CategotryIndex = comboBoxCategory.SelectedIndex + 1;
            uiRequest.StartDate = dateTimePickerStart.Value;
            uiRequest.EndDate = dateTimePickerEnd.Value;

            DatabaseRows(uiRequest);
            DatabaseColumns();
            //GetRowNames();
        }

        //for test purpose
        private void GetRowNames()
        {
            for (int i = 0; i < dbGrid.Rows.Count - 1; i++)
            {
                Debug.Print(dbGrid.Rows[i].Cells[0].Value.ToString());
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

                DataGridViewColumn column = dbGrid.Columns[i + 1];

                tempMonth = dateTimePickerStart.Value.AddMonths(i);
                column.HeaderCell.Style.BackColor = Color.FromArgb(46, 52, 63);
                column.HeaderText = tempMonth.ToString("MMM-yy");

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
                            column.DataGridView.Rows[j].Cells[i + 1].Value = departmentResult.Data[k].DTotalCapacity;
                            //column.DataGridView.Rows[j].Cells[i + 1].Style.BackColor = Color.FromArgb(255, 230, 153);
                        }
                    }

                    //get project capacity detail by date and project name
                    var projectResult = projectCapacityManager.GetProjectCapacityDetailsByDateAndProjectName(tempMonth, tempCellName);
                    if (projectResult.Success)
                    {
                        for (int k = 0; k < projectResult.Data.Count; k++)
                        {
                            column.DataGridView.Rows[j].Cells[i + 1].Value = projectResult.Data[k].PTotalCapacity;
                            column.DataGridView.Rows[j].Cells[i + 1].Style.BackColor = Color.LightGreen;
                        }
                    }
                }
            }
            #region "DELETE LATER"
            //DELETE LATER
            dbGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dbGrid.ColumnHeadersHeight = 80;
            dbGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            // Here we attach an event handler to the cell painting event
            dbGrid.CellPainting += new DataGridViewCellPaintingEventHandler(dbGrid_CellPainting);
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
            //DELETE THIS LATER

            int columnIndex = dbGrid.Columns.Add("", "");
            DataGridViewColumn column = dbGrid.Columns[columnIndex];
            column.HeaderCell.Style.BackColor = Color.FromArgb(46, 52, 63);

            if (result.Success)
            {
                List<string> managementNames = new();
                List<string> departmentNames = new();
                List<string> projectNames = new();

                for (int i = 0; i < result.Data.Count; i++)
                {
                    managementNames.Add(result.Data[i].ManagementName);
                    departmentNames.Add(result.Data[i].DepartmentName + "," + result.Data[i].ManagementName);
                    projectNames.Add(result.Data[i].ProjectName + "," + result.Data[i].DepartmentName);
                }

                //unique values
                managementNames = managementNames.Distinct().ToList();
                departmentNames = departmentNames.Distinct().ToList();
                projectNames = projectNames.Distinct().ToList();


                //if management count > 0
                for (int i = 0; i < managementNames.Count; i++)
                {
                    Font managementFont = new("Calibri", 11, FontStyle.Italic);
                    //managementFont.Style = FontStyle.Italic;
                    AddRow(managementNames[i], Color.FromArgb(46, 52, 63), Color.White, "Management", managementFont);

                    // if department count >0
                    for (int j = 0; j < departmentNames.Count; j++)
                    {
                        if (managementNames[i] == departmentNames[j].Split(",")[1])
                        {
                            Font departmentFont = new("Segoe UI", 8, FontStyle.Italic);
                            AddRow(departmentNames[j].Split(",")[0], Color.FromArgb(255, 230, 153), Color.Black, "Department", departmentFont);

                            for (int k = 0; k < projectNames.Count; k++)
                            {
                                Font projectFont = new("Segoe UI", 8, FontStyle.Italic);
                                if (departmentNames[j].Split(",")[0] == projectNames[k].Split(",")[1])
                                    AddRow(projectNames[k].Split(",")[0], Color.FromArgb(210, 238, 255), Color.Black, "Project", projectFont);

                                //string tempData;
                                //tempData = result.Data[k].ProjectName;
                                //AddRow(tempData, Color.FromArgb(210, 238, 255));
                            }
                            //seperator
                            AddRow("", Color.FromArgb(242, 242, 242), Color.White, "Empty", new Font("Segui", 8), 15);

                        }
                    }
                }

                //string managementTitle, departmentTitle;

                //managementTitle = result.Data[0].ManagementName;
                //departmentTitle = result.Data[0].DepartmentName;

                //for (int k = 0; k < result.Data.Count; k++)
                //{
                //    string tempData;
                //    tempData = result.Data[k].ProjectName;
                //    AddRow(tempData, Color.LightSkyBlue);
                //}

                Debug.Print(result.Massage);
            }
            else
            {
                ResetGridView();
                dbGrid.Columns.Add("", "");
                Debug.Print(result.Massage);
            }
        }

        private void AddRow(string data, Color color, Color foreColor, string tag, Font font, int height = 33)
        {
            DataGridViewRow dataRow = new();
            DataGridViewTextBoxCell dataCell = new();

            //seperate rows and cells accordingly
            dataRow.Tag = tag;
            dataCell.Value = data;
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
            dateTimePickerEnd.Value = dateTimePickerStart.Value.AddMonths(11);
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
            if (e.RowIndex == -1 && e.ColumnIndex >= 1)
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
        }

        //CRUD OPERTAIONS
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //create entity
            CreateForm createForm = new(managementManager, departmentManager, categoryManager, projectManager);
            createForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //update entity
            UpdateForm updateForm = new(managementManager, departmentManager, categoryManager, projectManager);
            updateForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete entity
            DeleteForm deleteForm = new(managementManager, departmentManager, categoryManager, projectManager);
            deleteForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {

                DataGridViewImageColumn imageColumn = new();
                dbGrid.Columns.Add(imageColumn);
                //dbGrid.Columns.Add("Delete", "Delete", Properties.Resources.DeleteIcon);


                int lastColumnIndex = dbGrid.Columns.Count - 1;
                dbGrid.Columns[lastColumnIndex].Name = "Delete";


                for (int i = 0; i < dbGrid.Rows.Count; i++)
                {
                    if (dbGrid.Rows[i].Tag != "Project")
                    {
                        dbGrid.Rows[i].Cells[lastColumnIndex].Style.NullValue = null;
                        //dbGrid.Rows[i].Cells[lastColumnIndex].Value = "Delete";
                        //dbGrid.Rows[i].Cells[lastColumnIndex].Value = iconColumn;
                    }
                    else
                    {
                        dbGrid.Rows[i].Cells[lastColumnIndex].Value = Properties.Resources.Remove;
                    }
                }

                dbGrid.ReadOnly = false;

                btnEdit.Text = "Exit Edit";
            }

            else if (btnEdit.Text == "Exit Edit")
            {
                dbGrid.Columns.Remove("Delete");

                dbGrid.ReadOnly = true;

                btnEdit.Text = "Edit";
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
            }
        }

        private void dbGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            var cellValue = dbGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            var cellDate = dbGrid.Columns[e.ColumnIndex].HeaderText;

            //If editing Project Capacities
            if (dbGrid.Rows[e.RowIndex].Tag == "Project")
            {
                //check if cell value is changed
                if (_tempCellValue != cellValue)
                {
                    Project cellProject = projectManager.GetByName(dbGrid.Rows[e.RowIndex].Cells[0].Value.ToString()).Data;

                    //check if cell value was empty before
                    if (_tempCellValue == null)
                    {
                        ProjectCapacity projectCapacityToAdd = new ProjectCapacity();

                        projectCapacityToAdd.ProjectId = cellProject.ProjectId;
                        projectCapacityToAdd.PTotalCapacity = Convert.ToInt32(cellValue);
                        projectCapacityToAdd.Date = Convert.ToDateTime(cellDate);
                        projectCapacityManager.Add(projectCapacityToAdd);

                        Debug.Print("project cell value added");
                    }
                    else
                    {
                        //if cell value is deleted or 0
                        ProjectCapacity projectCapacityToUpdate = projectCapacityManager.GetProjectCapacityByDateAndProjectId(Convert.ToDateTime(cellDate), cellProject.ProjectId).Data;
                        if (cellValue == null || Convert.ToInt32(cellValue) == 0)
                        {
                            projectCapacityManager.Delete(projectCapacityToUpdate);
                            Debug.Print("project cell value deleted");

                        }
                        else
                        {
                            projectCapacityToUpdate.PTotalCapacity = Convert.ToInt32(cellValue);
                            projectCapacityManager.Update(projectCapacityToUpdate);
                            Debug.Print("project cell value updated");
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
                    Department cellDepartment = departmentManager.GetByDepartmentName(dbGrid.Rows[e.RowIndex].Cells[0].Value.ToString()).Data;

                    //check if cell value was empty before
                    if (_tempCellValue == null)
                    {
                        DepartmentCapacity departmentCapacityToAdd = new DepartmentCapacity();

                        departmentCapacityToAdd.DepartmentId = cellDepartment.DepartmentId;
                        departmentCapacityToAdd.DTotalCapacity = Convert.ToInt32(cellValue);
                        departmentCapacityToAdd.Date = Convert.ToDateTime(cellDate);
                        departmentCapacityManager.Add(departmentCapacityToAdd);

                        Debug.Print("department cell value added");
                    }
                    else
                    {
                        //if cell value is deleted or 0
                        DepartmentCapacity departmentCapacityToUpdate = departmentCapacityManager.GetDepartmentCapacityByDateAndDepartmentId(Convert.ToDateTime(cellDate), cellDepartment.DepartmentId).Data;
                        if (cellValue == null || Convert.ToInt32(cellValue) == 0)
                        {
                            departmentCapacityManager.Delete(departmentCapacityToUpdate);
                            Debug.Print("department cell value deleted");

                        }
                        else
                        {
                            departmentCapacityToUpdate.DTotalCapacity = Convert.ToInt32(cellValue);
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
    }
}
