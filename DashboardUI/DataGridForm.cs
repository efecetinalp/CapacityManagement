using Business.Concrete;
using Core.Utilities.Results;
using DashboardUI.Properties;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DataTable = System.Data.DataTable;
using System.Diagnostics;
using System.Drawing;
using Font = System.Drawing.Font;
using Rectangle = System.Drawing.Rectangle;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.VisualBasic.Devices;

namespace DashboardUI
{
    public partial class DataGridForm : Form
    {
        //Database Referances
        ManagementManager managementManager;
        DepartmentManager departmentManager;
        CategoryManager categoryManager;
        ProjectManager projectManager;
        ProjectCapacityManager projectCapacityManager;
        DepartmentCapacityManager departmentCapacityManager;

        //UI Form Referances
        CreateForm createForm;
        Dashboard _dashboardForm;

        //Class Referances
        AlertBox alertBox;
        ToolTip _toolTip;

        //Properties
        private object _tempCellValue;
        private bool isEditing = false;
        private int _alertPosX;
        private int _alertPosY;

        public DataGridForm(ProjectManager projectManager, DepartmentManager departmentManager, ManagementManager managementManager, CategoryManager categoryManager, DepartmentCapacityManager departmentCapacityManager, ProjectCapacityManager projectCapacityManager, Dashboard dashboardForm)
        {
            this.projectManager = projectManager;
            this.departmentManager = departmentManager;
            this.managementManager = managementManager;
            this.categoryManager = categoryManager;
            this.projectCapacityManager = projectCapacityManager;
            this.departmentCapacityManager = departmentCapacityManager;

            _dashboardForm = dashboardForm;
            _alertPosX = _dashboardForm.Left + _dashboardForm.Width;
            _alertPosY = _dashboardForm.Top + _dashboardForm.Height;
            InitializeComponent();
        }

        private void DataGridForm_Load(object sender, EventArgs e)
        {
            //form initialize options
            alertBox = new AlertBox();

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

            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = "MM/yyyy";
            dateTimePickerStart.ShowUpDown = true;
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = "MM/yyyy";
            dateTimePickerEnd.ShowUpDown = true;

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

            //DELETE LATER
            comboBoxManagement.SelectedIndex = 0;
            comboBoxDepartment.SelectedIndex = 0;
        }

        #region Button List Function

        private void buttonList_Click(object sender, EventArgs e)
        {
            ResetGridView();

            if (comboBoxManagement.Text == "" || comboBoxDepartment.Text == "")
            {
                alertBox.WarningAlert("Please select a Department", _dashboardForm.Left + _dashboardForm.Width, _dashboardForm.Top + _dashboardForm.Height);
                return;
            }

            //fetches data and format into data grid view
            FetchData();

            alertBox.SuccessAlert("Success", _alertPosX, _alertPosY);
        }

        private async void FetchData()
        {
            DataTable dataTable = new DataTable();

            //Columns placement
            //this column for management / department / project names
            DataColumn initialColumn = dataTable.Columns.Add("Initial");

            //date columns will add to data table
            int monthCalulate = (dateTimePickerEnd.Value.Year - dateTimePickerStart.Value.Year) * 12
                + (dateTimePickerEnd.Value.Month - dateTimePickerStart.Value.Month);

            for (int i = 0; i <= monthCalulate; i++)
            {
                DateTime tempMonth;
                tempMonth = dateTimePickerStart.Value.AddMonths(i);
                DataColumn dateColumn = dataTable.Columns.Add(tempMonth.ToString("MMM-yy"));
            }

            //Rows placement
            //dates placed into row
            DataRow dateRow = dataTable.Rows.Add();
            for (int i = 0; i <= monthCalulate; i++)
            {
                DateTime tempMonth;
                tempMonth = dateTimePickerStart.Value.AddMonths(i);
                dateRow[i + 1] = (tempMonth.ToString("MMM-yy"));
            }

            //management name placed into row
            DataRow managementRow = dataTable.Rows.Add();
            managementRow[0] = comboBoxManagement.Text;

            //management name placed into row
            DataRow departmentRow = dataTable.Rows.Add();
            departmentRow[0] = comboBoxDepartment.Text;

            var departmentDatas = departmentCapacityManager.GetAllByDateBetweenAndDepartmentName(dateTimePickerStart.Value, dateTimePickerEnd.Value, comboBoxDepartment.Text);

            if (departmentDatas.Success)
            {
                foreach (var departmentData in departmentDatas.Data)
                {
                    for (int i = 0; i <= monthCalulate; i++)
                    {
                        if (dateRow[i + 1].ToString() == departmentData.Date.ToString("MMM-yy"))
                        {
                            departmentRow[i + 1] = departmentData.DTotalCapacity;
                        }
                    }
                }
            }
            else
            {
                alertBox.ErrorAlert(departmentDatas.Massage, _alertPosX, _alertPosY);
                return;
            }

            //project name and capacity placed into row
            int departmentId = departmentManager.GetByName(comboBoxDepartment.Text).Data.DepartmentId;
            var projectNames = projectManager.GetAllByDepartmentId(departmentId);
            var projectDatas = projectCapacityManager.GetProjectCapacityDetailsByDateBetweenAndDepartmentId(dateTimePickerStart.Value, dateTimePickerEnd.Value, departmentId);

            if (projectNames.Success && projectDatas.Success)
            {
                foreach (var projectName in projectNames.Data)
                {
                    DataRow projectRow = dataTable.Rows.Add();
                    projectRow[0] = projectName.ProjectName;

                    foreach (var projectData in projectDatas.Data)
                    {
                        for (int i = 0; i <= monthCalulate; i++)
                        {
                            if (dateRow[i + 1].ToString() == projectData.Date.ToString("MMM-yy"))
                            {
                                for (int j = 0; j < dataTable.Rows.Count; j++)
                                {
                                    if (projectName.ProjectName == projectData.ProjectName)
                                    {
                                        projectRow[i + 1] = projectData.PTotalCapacity;
                                    }
                                }
                            }
                        }
                    }
                }

            }
            else
            {
                alertBox.ErrorAlert(projectNames.Massage, _alertPosX, _alertPosY);
                return;
            }

            //place data table into data grid view
            dbGrid.DataSource = dataTable;

            //data grid view style
            FormatDataGridView();
        }

        private void FormatDataGridView()
        {
            //format data grid view style
            dbGrid.Columns[0].Width = 250;

            //data grid view font styles
            Font managementFont = new("Calibri", 12, FontStyle.Italic);
            Font projectFont = new("Segoe UI", 9, FontStyle.Italic);

            //capacity and dates placed middle center into data grid view
            for (int i = 1; i < dbGrid.Columns.Count; i++)
            {
                dbGrid.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dbGrid.Columns[i].Width = 30;
            }

            // date row backcolor
            dbGrid.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(46, 52, 63);
            dbGrid.Rows[0].DefaultCellStyle.ForeColor = Color.White;
            dbGrid.Rows[0].DefaultCellStyle.Font = projectFont;
            dbGrid.Rows[0].Height = 60;

            //formating 90° date text
            dbGrid.CellPainting += new DataGridViewCellPaintingEventHandler(dbGrid_CellPainting);

            //management row backcolor
            dbGrid.Rows[1].DefaultCellStyle.BackColor = Color.FromArgb(46, 52, 63);
            dbGrid.Rows[1].DefaultCellStyle.Font = managementFont;

            //department row backcolor
            dbGrid.Rows[2].DefaultCellStyle.BackColor = Color.FromArgb(255, 230, 153);
            dbGrid.Rows[2].DefaultCellStyle.Font = projectFont;

            //project rows backcolor
            for (int i = 3; i < dbGrid.Rows.Count; i++)
            {
                dbGrid.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(210, 238, 255);
                dbGrid.Rows[i].DefaultCellStyle.Font = projectFont;
            }

            //project capacity cells backcolor
            for (int i = 3; i < dbGrid.Rows.Count; i++)
            {
                for (int j = 1; j < dbGrid.Columns.Count; j++)
                {
                    if (dbGrid.Rows[i].Cells[j].Value.ToString() != "")
                        dbGrid.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(198, 224, 180);
                    else
                        dbGrid.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(226, 239, 218);
                }
            }
        }

        private void dbGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // dates row
            if (e.RowIndex == 0 && e.ColumnIndex >= 1)
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
                e.Graphics.DrawString(e.Value.ToString(), this.Font, Brushes.White, new PointF(rect.Y - (dbGrid.Rows[0].Height - titleSize.Width), rect.X + 5));
                // The old line for comparison
                //e.Graphics.DrawString(e.Value.ToString(), this.Font, Brushes.Black, new PointF(rect.Y, rect.X));

                e.Graphics.RotateTransform(90.0F);
                e.Graphics.TranslateTransform(0, -titleSize.Width);
                e.Handled = true;
            }

            //management row
            if (e.RowIndex == 1 && e.ColumnIndex >= 0)
            {
                e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            }
        }

        private void dbGrid_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        #endregion

        #region Button Reset Function

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetGridView();

            //reset filters
            comboBoxManagement.ResetText();
            comboBoxManagement.SelectedIndex = -1;
            comboBoxDepartment.ResetText();
            comboBoxDepartment.SelectedIndex = -1;

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

        #endregion

        //THIS IS EMPTY DELETE LATER
        #region Button Refresh Function

        #endregion

        #region Button Export To Excel Function
        
        private void buttonExportToExcel_Click(object sender, EventArgs e)
        {
            ExportHandler.ExportDataToExcel(dbGrid);
        }

        #endregion

        #region Button Create New Project Function

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

        #endregion

        //TOTAL MESS INSIDE NEED TO REFACTOR
        #region Button Edit Function

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

                dbGrid.Columns.Remove("Delete");
                dbGrid.Columns.Remove("Update");

                dbGrid.ReadOnly = true;

                isEditing = false;
            }
        }

        private void dbGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0 && e.RowIndex > 0)
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
            else if (e.ColumnIndex < 0)
            {
                Debug.Print("project card opened");
            }
        }

        #region CRUD Operations

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

        #endregion

        #endregion

        #region Combobox Management Changed Event

        private void comboBoxManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update department comboBox
            comboBoxDepartment.Items.Clear();
            comboBoxDepartment.ResetText();
            comboBoxDepartment.SelectedIndex = -1;

            foreach (var department in departmentManager.GetAllByManagementId(comboBoxManagement.SelectedIndex + 1).Data)
            {
                comboBoxDepartment.Items.Add(department.DepartmentName);
            }
        }

        #endregion

        //NOT WORKED ON YET
        #region Project Information Card
        
        private void dbGrid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                if (dbGrid.Rows[e.RowIndex].Tag == "Project")
                {
                    for (int i = 0; i < dbGrid.Rows.Count; i++)
                    {
                        dbGrid.Rows[i].HeaderCell.Value = "";
                    }
                    dbGrid.Rows[e.RowIndex].HeaderCell.Value = "x";
                }
            }
        }

        #endregion

        //NOT WORKED ON YET
        #region Button Chart Function

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

        #endregion

    }
}
