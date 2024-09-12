using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.Data.SqlClient.Server;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace DashboardUI
{
    public partial class Dashboard : Form
    {
        //database manager referances
        ManagementManager managementManager = new ManagementManager(new EfManagementDal());
        DepartmentManager departmentManager = new DepartmentManager(new EfDepartmentDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        ProjectManager projectManager = new ProjectManager(new EfProjectDal());
        ProjectCapacityManager projectCapacityManager = new ProjectCapacityManager(new EfProjectCapacityDal());
        DepartmentCapacityManager departmentCapacityManager = new DepartmentCapacityManager(new EfDepartmentCapacityDal());
        //temp cell value
        object _tempCellValue;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

            dateTimePickerStart.Value = new DateTime(2024, 01, 01);
            dateTimePickerEnd.Value = dateTimePickerStart.Value.AddMonths(11);
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            ResetGridView();

            UIRequest uiRequest = new();
            uiRequest.ManagementIndex = comboBoxManagement.SelectedIndex + 1; //+1 because sql table starts with -1

            if (comboBoxDepartment.Text != "")
                uiRequest.DepartmentIndex = departmentManager.GetIdByDepartmentName(comboBoxDepartment.Text).Data.DepartmentId;
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
            dbGrid.ColumnHeadersHeight = 50;
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

            var result = projectManager.GetProjectDetails(uiRequest.ManagementIndex, uiRequest.DepartmentIndex, uiRequest.CategotryIndex);
            FetchData(result);

        }

        private void FetchData(IDataResult<List<ProjectDetailDto>> result)
        {
            //DELETE THIS LATER
            dbGrid.Columns.Add("", "");

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
                    AddRow(managementNames[i], Color.FromArgb(51, 63, 79));

                    // if department count >0
                    for (int j = 0; j < departmentNames.Count; j++)
                    {
                        if (managementNames[i] == departmentNames[j].Split(",")[1])
                        {

                            AddRow(departmentNames[j].Split(",")[0], Color.FromArgb(255, 230, 153));

                            for (int k = 0; k < projectNames.Count; k++)
                            {
                                if (departmentNames[j].Split(",")[0] == projectNames[k].Split(",")[1])
                                    AddRow(projectNames[k].Split(",")[0], Color.FromArgb(210, 238, 255));

                                //string tempData;
                                //tempData = result.Data[k].ProjectName;
                                //AddRow(tempData, Color.FromArgb(210, 238, 255));
                            }
                            //seperator
                            AddRow("", Color.White);
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

        private int AddRow(string data, Color color)
        {
            DataGridViewRow dataRow = new();
            DataGridViewTextBoxCell dataCell = new();
            dataCell.Value = data;
            dataRow.DefaultCellStyle.BackColor = color;
            dataRow.Cells.Add(dataCell);
            dbGrid.Rows.Add(dataRow);
            return dbGrid.Rows.IndexOf(dataRow);
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
                e.Graphics.DrawString(e.Value.ToString(), this.Font, Brushes.Black, new PointF(rect.Y - (dbGrid.ColumnHeadersHeight - titleSize.Width), rect.X));

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
            //create new project
            CreateForm createForm = new(managementManager, departmentManager, categoryManager, projectManager);
            createForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //able to edit data grid view
            DataGridViewButtonColumn buttonDeleteRow = new();
            buttonDeleteRow.Name = "Delete";
            buttonDeleteRow.Text = "X";
            dbGrid.Columns.Add(buttonDeleteRow);
        }

        private void dbGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //delete project and project capacities
            if (dbGrid.Columns[e.ColumnIndex].Name == "Delete")
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
                else
                {
                    ResetGridView();
                }
            }
        }

        private void dbGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var cellValue = dbGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            var cellDate = dbGrid.Columns[e.ColumnIndex].HeaderText;
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

                    Debug.Print("cell value added");
                }
                else
                {
                    //if cell value is deleted or 0
                    ProjectCapacity projectCapacityToUpdate = projectCapacityManager.GetProjectCapacityByDateAndProjectId(Convert.ToDateTime(cellDate), cellProject.ProjectId).Data;
                    if (cellValue == null || Convert.ToInt32(cellValue) == 0)
                    {
                        projectCapacityManager.Delete(projectCapacityToUpdate);
                        Debug.Print("cell value deleted");

                    }
                    else
                    {
                        projectCapacityToUpdate.PTotalCapacity = Convert.ToInt32(cellValue);
                        projectCapacityManager.Update(projectCapacityToUpdate);
                        Debug.Print("cell value updated");
                    }
                }
            }
            else
                Debug.Print("cell is the same");
        }

        private void dbGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _tempCellValue = dbGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }
    }
}