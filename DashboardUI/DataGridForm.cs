using Business.Concrete;
using Entities.Concrete;
using System.Data;
using DataTable = System.Data.DataTable;
using System.Diagnostics;
using Font = System.Drawing.Font;
using Rectangle = System.Drawing.Rectangle;
using System.Globalization;
using Microsoft.Office.Interop.Excel;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Core.Entities;
using DashboardUI.Utilities;
using DatabaseOperation = DashboardUI.Utilities.DatabaseOperation;

namespace DashboardUI
{
    public partial class DataGridForm : Form
    {
        //Database Referances
        ManagementManager managementManager;
        DepartmentManager departmentManager;
        CategoryManager categoryManager;
        ProjectManager projectManager;
        UserManager userManager;
        ProjectCapacityManager projectCapacityManager;
        DepartmentCapacityManager departmentCapacityManager;

        //UI Form Referances
        CreateProjectForm createForm;
        Dashboard _dashboardForm;
        DataCardUI _dataCardForm;

        //Class Referances
        AlertBox alertBox;

        //Properties
        private string _cellValueBegin;
        private bool isEditing = false;
        private bool isSorted = false;
        private bool isHidden = false;

        private DateTime _startDate;
        private DateTime _endDate;
        private bool _isActiveUser = false;
        public bool isDataListed = false;
        private int _rowIndex;
        private int _departmentIndex;
        private List<Project> _listedProjects = new();
        private List<int> _completedProjectList = new();

        //CRUD operation list
        private Project _currentEditingProject;
        private int _currentEditingRow;
        private List<DatabaseOperation> _databaseOperations = new();

        public DataGridForm(ProjectManager projectManager, DepartmentManager departmentManager, ManagementManager managementManager, CategoryManager categoryManager,
            DepartmentCapacityManager departmentCapacityManager, ProjectCapacityManager projectCapacityManager, UserManager userManager, Dashboard dashboardForm)
        {
            this.projectManager = projectManager;
            this.departmentManager = departmentManager;
            this.managementManager = managementManager;
            this.categoryManager = categoryManager;
            this.projectCapacityManager = projectCapacityManager;
            this.departmentCapacityManager = departmentCapacityManager;
            this.userManager = userManager;

            _dashboardForm = dashboardForm;
            InitializeComponent();
        }

        private void DataGridForm_Load(object sender, EventArgs e)
        {
            //form initialize options
            alertBox = new AlertBox(_dashboardForm);

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

            CheckUserCredential();

            //DELETE LATER
            comboBoxManagement.SelectedIndex = 0;
            comboBoxDepartment.SelectedIndex = 0;
        }

        private void CheckUserCredential()
        {
            if (_dashboardForm.activeUser != null)
                _isActiveUser = true;
        }

        #region Button List Function

        private void buttonList_Click(object sender, EventArgs e)
        {
            dbGrid.SuspendLayout();

            ResetGridView();

            if (comboBoxManagement.Text == "" || comboBoxDepartment.Text == "")
            {
                alertBox.WarningAlert("Please select a Department");
                return;
            }

            //fetches data and format into data grid view
            FetchData();

            _dashboardForm.ActivateChartButton();

            if (isDataListed)
                alertBox.SuccessAlert("Success");

            dbGrid.ResumeLayout();
            dbGrid.Refresh();
        }

        private async void FetchData()
        {
            DataTable dataTable = new DataTable();
            _startDate = dateTimePickerStart.Value;
            _endDate = dateTimePickerEnd.Value;

            //Columns placement
            //this column for management / department / project names
            DataColumn initialColumn = dataTable.Columns.Add("Initial");

            //date columns will add to data table
            int monthCalulate = (_endDate.Year - _startDate.Year) * 12
                + (_endDate.Month - _startDate.Month);

            for (int i = 0; i <= monthCalulate; i++)
            {
                DateTime tempMonth;
                tempMonth = _startDate.AddMonths(i);
                DataColumn dateColumn = dataTable.Columns.Add(tempMonth.ToString("MMM-yy"));
            }

            //Rows placement
            //dates placed into row
            DataRow dateRow = dataTable.Rows.Add();
            for (int i = 0; i <= monthCalulate; i++)
            {
                DateTime tempMonth;
                tempMonth = _startDate.AddMonths(i);
                dateRow[i + 1] = (tempMonth.ToString("MMM-yy"));
            }

            //management name placed into row
            DataRow managementRow = dataTable.Rows.Add();
            managementRow[0] = comboBoxManagement.Text;

            //management name placed into row
            DataRow departmentRow = dataTable.Rows.Add();
            departmentRow[0] = comboBoxDepartment.Text;

            //REFACTOR THIS IMMEDIATELY
            _departmentIndex = departmentManager.GetByName(comboBoxDepartment.Text).Data.DepartmentId;

            var departmentDatas = departmentCapacityManager.GetAllByDateBetweenAndDepartmentId(_startDate, _endDate, _departmentIndex);

            if (departmentDatas.Success)
            {
                //_departmentIndex = departmentDatas.Data[0].DepartmentId;
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
                alertBox.ErrorAlert(departmentDatas.Massage);
                return;
            }


            //project name and capacity placed into row
            //int departmentId = departmentManager.GetByName(comboBoxDepartment.Text).Data.DepartmentId;
            var projectNames = projectManager.GetAllByDepartmentId(_departmentIndex);
            var projectDatas = projectCapacityManager.GetProjectCapacityDetailsByDateBetweenAndDepartmentId(_startDate, _endDate, _departmentIndex);
            _listedProjects.Clear();

            if (projectNames.Success)
            {

                foreach (var projectName in projectNames.Data)
                {
                    DataRow projectRow = dataTable.Rows.Add();
                    projectRow[0] = projectName.ProjectName;
                    _listedProjects.Add(projectName);

                    //completed project table index list
                    if (projectName.IsCompleted)
                        _completedProjectList.Add(dataTable.Rows.Count - 1);

                    if (projectDatas.Success)
                    {
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
            }

            //place data table into data grid view
            dbGrid.DataSource = dataTable;
            isDataListed = true;

            if (_isActiveUser)
            {
                buttonReset.Enabled = true;
                buttonShowHide.Enabled = true;
                buttonChart.Enabled = true;
                buttonExportToExcel.Enabled = true;
                buttonNew.Enabled = true;
                buttonEdit.Enabled = true;
            }

            //data grid view style
            dbGrid.Columns[0].Frozen = true;

            for (int i = 1; i < dbGrid.Columns.Count; i++)
            {
                dbGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

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
            dbGrid.Rows[1].Tag = "Management";
            dbGrid.Rows[1].DefaultCellStyle.BackColor = Color.FromArgb(46, 52, 63);
            dbGrid.Rows[1].DefaultCellStyle.ForeColor = Color.White;
            dbGrid.Rows[1].DefaultCellStyle.Font = managementFont;

            //department row backcolor
            dbGrid.Rows[2].Tag = "Department";
            dbGrid.Rows[2].DefaultCellStyle.BackColor = Color.FromArgb(255, 230, 153);
            dbGrid.Rows[2].DefaultCellStyle.Font = projectFont;

            //project rows backcolor
            for (int i = 3; i < dbGrid.Rows.Count; i++)
            {
                dbGrid.Rows[i].Tag = "Project";
                dbGrid.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(210, 238, 255);
                dbGrid.Rows[i].DefaultCellStyle.Font = projectFont;
            }

            //project capacity cells backcolor
            for (int i = 3; i < dbGrid.Rows.Count; i++)
            {
                for (int j = 1; j < dbGrid.Columns.Count; j++)
                {
                    if (dbGrid.Rows[i].Cells[j].Value.ToString() != "")
                    {
                        dbGrid.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(198, 224, 180);
                    }
                    else
                    {
                        dbGrid.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(226, 239, 218);
                    }
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

            buttonReset.Enabled = false;
            buttonShowHide.Enabled = false;
            buttonChart.Enabled = false;
            buttonExportToExcel.Enabled = false;
            buttonNew.Enabled = false;
            buttonEdit.Enabled = false;

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
            isEditing = false;
            dbGrid.ReadOnly = true;
            pictureBoxLocked.Visible = true;
            pictureBoxUnlocked.Visible = false;
            labelLockStatus.Text = "Data editing is locked";
            isDataListed = false;
        }

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
                Management management = managementManager.GetByName(comboBoxManagement.Text).Data;
                Department department = departmentManager.GetById(_departmentIndex).Data;
                createForm = new CreateProjectForm(management, department, categoryManager, projectManager, userManager);
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
            if (createForm.ChangeAction)
                buttonList_Click(sender, e);

            createForm = null;
        }

        #endregion

        #region Button Edit Function

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                isEditing = false;
                dbGrid.ReadOnly = true;
                pictureBoxLocked.Visible = true;
                pictureBoxUnlocked.Visible = false;
                labelLockStatus.Text = "Data editing is locked";
            }
            else
            {
                isEditing = true;
                dbGrid.ReadOnly = false;
                pictureBoxLocked.Visible = false;
                pictureBoxUnlocked.Visible = true;
                labelLockStatus.Text = "Data editing is unlocked";
                _databaseOperations.Clear();
            }
        }

        #region CRUD Operations On DataGridView

        private string CheckDecimalSeperator(string cellValue)
        {
            string decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            if (decimalSeparator == ",")
                cellValue = cellValue.Replace(".", ",");
            else
                cellValue = cellValue.Replace(",", ".");

            return cellValue;
        }

        public static bool IsNumeric(object Expression)
        {
            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        private void dbGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            EditCell(dbGrid.Rows[e.RowIndex].Cells[e.ColumnIndex]);
        }

        private void dbGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Debug.Print(_databaseOperations.Count.ToString());
            _cellValueBegin = dbGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void EditCell(DataGridViewCell cell)
        {

            string cellValue = cell.Value.ToString();

            DateTime cellDate = _startDate.AddMonths(cell.ColumnIndex - 1);
            cellDate = new DateTime(cellDate.Year, cellDate.Month, 01);

            //editting project rows
            if (cell.RowIndex > 2)
            {
                //check if cell value is changed
                if (_cellValueBegin != cellValue)
                {
                    //editing project capacity data
                    //check if cell value is numaric
                    if (cellValue != "")
                    {
                        if (!IsNumeric(cellValue))
                        {
                            cell.Value = _cellValueBegin;
                            alertBox.WarningAlert("Non-numeric value");
                            return;
                        }
                    }

                    //fetch current project data to edit
                    Project cellProject;
                    if (cell.RowIndex == _currentEditingRow)
                    {
                        cellProject = _currentEditingProject;
                    }
                    else
                    {
                        _currentEditingRow = cell.RowIndex;
                        cellProject = _listedProjects[cell.RowIndex - 3];
                        _currentEditingProject = cellProject;
                    }

                    //new capacity value added
                    if (_cellValueBegin == "" && cell.ColumnIndex > 0)
                    {
                        //new capacity data
                        ProjectCapacity projectCapacityToAdd = new ProjectCapacity();
                        projectCapacityToAdd.ProjectId = cellProject.ProjectId;
                        projectCapacityToAdd.PTotalCapacity = Math.Round(Convert.ToDouble(CheckDecimalSeperator(cellValue)), 1);
                        projectCapacityToAdd.Date = cellDate;

                        _databaseOperations.Add(new CreateOperation(projectCapacityToAdd, projectCapacityManager, cell.ColumnIndex, cell.RowIndex));

                        //if (projectCapacityManager.Add(projectCapacityToAdd).Success)
                        //    Debug.Print(DateTime.Now + " - " + Environment.UserName + " - " + "CREATE" + " - " + "Project Capacity" + " - " + projectCapacityToAdd.ProjectCapacityId + "Project capacity cell value added");
                        //else
                        //{
                        //    Debug.Print(DateTime.Now + " - " + Environment.UserName + " - " + "ERROR" + " - " + "Project Capacity" + " - " + projectCapacityToAdd.ProjectCapacityId + "Error when adding data into database");
                        //    alertBox.ErrorAlert("Error when adding data into database");
                        //}
                    }
                    //current capacity value editing
                    else
                    {
                        //fetch project capacity data from data grid view
                        var projectCapacityData = projectCapacityManager.GetProjectCapacityByDateAndProjectId(cellDate, cellProject.ProjectId);
                        //if (!projectCapacityData.Success)
                        //{
                        //    Debug.Print(DateTime.Now + " - " + Environment.UserName + " - " + "ERROR" + " - " + "Project Capacity" + " - " + projectCapacityData.Data.ProjectCapacityId + "Could not find project capacity data");
                        //    alertBox.ErrorAlert("Could not find project capacity data");
                        //    return;
                        //}

                        //project capacity on data grid view
                        ProjectCapacity projectCapacityToUpdate = projectCapacityData.Data;

                        //new value is null or 0 incase delete data
                        if (cellValue == "" || Math.Round(Convert.ToDouble(CheckDecimalSeperator(cellValue)), 1) == 0)
                        {
                            _databaseOperations.Add(new DeleteOperation(projectCapacityToUpdate, projectCapacityManager, cell.ColumnIndex, cell.RowIndex));


                            //if (projectCapacityManager.Delete(projectCapacityToUpdate).Success)
                            //    Debug.Print(DateTime.Now + " - " + Environment.UserName + " - " + "DELETE" + " - " + "Project Capacity" + " - " + projectCapacityData.Data.ProjectCapacityId + "Project capacity data deleted");
                            //else
                            //{
                            //    Debug.Print(DateTime.Now + " - " + Environment.UserName + " - " + "ERROR" + " - " + "Project Capacity" + " - " + projectCapacityData.Data.ProjectCapacityId + "Error when deleting data from database");
                            //    alertBox.ErrorAlert("Error when deleting data from database");
                            //}
                        }
                        //new value will update on current data
                        else
                        {
                            projectCapacityToUpdate.PTotalCapacity = Math.Round(Convert.ToDouble(CheckDecimalSeperator(cellValue)), 1);

                            _databaseOperations.Add(new UpdateOperation(projectCapacityToUpdate, projectCapacityManager, cell.ColumnIndex, cell.RowIndex));

                            //if (projectCapacityManager.Update(projectCapacityToUpdate).Success)
                            //    Debug.Print(DateTime.Now + " - " + Environment.UserName + " - " + "UPDATE" + " - " + "Project Capacity" + " - " + projectCapacityData.Data.ProjectCapacityId + "Project capacity data updated");
                            //else
                            //{
                            //    Debug.Print(DateTime.Now + " - " + Environment.UserName + " - " + "ERROR" + " - " + "Project Capacity" + " - " + projectCapacityData.Data.ProjectCapacityId + "Error when updating data in database");
                            //    alertBox.ErrorAlert("Error when updating data in database");
                            //}
                        }
                    }
                }
                else
                    Debug.Print("No change action");
            }
            //editing department rows
            else if (cell.RowIndex == 2)
            {
                //check if cell value is changed
                if (_cellValueBegin != cellValue)
                {
                    //editing department capacity data
                    //check if cell value is numeric
                    if (cellValue != "")
                    {
                        if (!IsNumeric(cellValue))
                        {
                            cell.Value = _cellValueBegin;
                            alertBox.WarningAlert("Non-numeric value");
                            return;
                        }
                    }

                    //fetch current departmet data to edit
                    var departmentData = departmentManager.GetById(_departmentIndex);
                    if (!departmentData.Success)
                    {
                        alertBox.ErrorAlert("Could not find department data");
                        return;
                    }

                    //department data on data grid view
                    Department cellDepartment = departmentData.Data;

                    //new department capacity value added
                    if (_cellValueBegin == "" && cell.ColumnIndex > 0)
                    {
                        //new department capacity data
                        DepartmentCapacity departmentCapacityToAdd = new DepartmentCapacity();
                        departmentCapacityToAdd.DepartmentId = cellDepartment.DepartmentId;
                        departmentCapacityToAdd.DTotalCapacity = Math.Round(Convert.ToDouble(CheckDecimalSeperator(cellValue)), 1);
                        departmentCapacityToAdd.Date = cellDate;

                        if (departmentCapacityManager.Add(departmentCapacityToAdd).Success)
                            Debug.Print("Department capacity cell value added");
                        else
                        {
                            Debug.Print("Error when adding data into database");
                            alertBox.ErrorAlert("Error when adding data into database");
                        }
                    }
                    //current department capacity value editing
                    else
                    {
                        //fetch department capacity data from data grid view
                        var departmentCapacityData = departmentCapacityManager.GetDepartmentCapacityByDateAndDepartmentId(cellDate, cellDepartment.DepartmentId);
                        if (!departmentCapacityData.Success)
                        {
                            Debug.Print("Could not find department capacity data");
                            alertBox.ErrorAlert("Could not find department capacity data");
                            return;
                        }

                        //department capacity on data grid view
                        DepartmentCapacity departmentCapacityToUpdate = departmentCapacityData.Data;

                        //new value is null or 0 incase delete data
                        if (cellValue == "" || Math.Round(Convert.ToDouble(CheckDecimalSeperator(cellValue)), 1) == 0)
                        {
                            if (departmentCapacityManager.Delete(departmentCapacityToUpdate).Success)
                                Debug.Print("Department capacity data deleted");
                            else
                            {
                                Debug.Print("Error when deleting data from database");
                                alertBox.ErrorAlert("Error when deleting data from database");
                            }
                        }
                        //new value will update on current data
                        else
                        {
                            departmentCapacityToUpdate.DTotalCapacity = Math.Round(Convert.ToDouble(CheckDecimalSeperator(cellValue)), 1);

                            if (departmentCapacityManager.Update(departmentCapacityToUpdate).Success)
                                Debug.Print("Department capacity data updated");
                            else
                            {
                                Debug.Print("Error when updatig data in database");
                                alertBox.ErrorAlert("Error when updatig data in database");
                            }
                        }
                    }
                }
                else
                    Debug.Print("No change action");
            }
            //editing other rows
            else
            {
                //check if cell value is changed
                if (_cellValueBegin != cellValue)
                {
                    cell.Value = _cellValueBegin;
                    return;
                }
            }
        }

        #region Copy Paste Delete Key Down

        //On keydown events
        //When Ctrl+V pressed paste clipboard into datagrid view
        //When Delete or backspace pressed Delete Cell values
        private void dbGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                PasteClipboard();
                Debug.Print(_databaseOperations.Count.ToString());

            }
            else if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                DeleteCell();
                Debug.Print(_databaseOperations.Count.ToString());
            }
        }

        private void DeleteCell()
        {
            try
            {
                if (dbGrid.SelectedCells.Count == 0)
                {
                    return;
                }

                int failedOperations = 0;
                for (int i = 0; i < dbGrid.SelectedCells.Count; i++)
                {
                    DataGridViewCell selectedCell = dbGrid.SelectedCells[i];

                    if (selectedCell.ColumnIndex < 1 || selectedCell.RowIndex < 2)
                    {
                        return;
                    }

                    if (selectedCell == null) { return; }

                    _cellValueBegin = selectedCell.Value.ToString();
                    if (!selectedCell.ReadOnly)
                    {
                        selectedCell.Value = "";
                        //EditCell(selectedCell);
                    }
                    else
                        failedOperations++;
                }

                if (failedOperations > 0)
                    MessageBox.Show(string.Format("Data table is not in edit mode!" + Environment.NewLine + "{0} updates failed due to read only cell setting", failedOperations), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (FormatException)
            {
                MessageBox.Show("The data is not editable!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void PasteClipboard()
        {
            try
            {
                string s = Clipboard.GetText();
                string[] lines = s.Split('\n');
                int iFail = 0;
                int iRow = dbGrid.CurrentCell.RowIndex;
                int iCol = dbGrid.CurrentCell.ColumnIndex;
                DataGridViewCell oCell;
                foreach (string line in lines)
                {
                    if (iRow < dbGrid.RowCount && line.Length > 0)
                    {
                        string[] sCells = line.Split('\t');
                        for (int i = 0; i < sCells.GetLength(0); ++i)
                        {
                            if (iCol + i < this.dbGrid.ColumnCount)
                            {
                                oCell = dbGrid[iCol + i, iRow];
                                _cellValueBegin = oCell.Value.ToString();
                                if (!oCell.ReadOnly)
                                {
                                    oCell.Value = Convert.ChangeType(sCells[i], oCell.ValueType);
                                    EditCell(oCell);
                                }
                                else
                                    iFail++;
                                //only traps a fail if the data has changed 
                                //and you are pasting into a read only cell
                            }
                            else
                            { break; }
                        }
                        iRow++;
                    }
                    else
                    { break; }

                    if (iFail > 0)
                        MessageBox.Show(string.Format("Data table is not in edit mode!" + Environment.NewLine + "{0} updates failed due to read only cell setting", iFail), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("The data you pasted is in the wrong format for the cell", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        #endregion

        #endregion

        #endregion

        #region Combobox Management Changed Event

        private void comboBoxManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxManagement.Text != "")
            {
                //update department comboBox
                comboBoxDepartment.Items.Clear();
                comboBoxDepartment.ResetText();
                comboBoxDepartment.SelectedIndex = -1;

                var managementId = managementManager.GetByName(comboBoxManagement.SelectedItem.ToString()).Data.ManagementId;
                foreach (var department in departmentManager.GetAllByManagementId(managementId).Data)
                {
                    comboBoxDepartment.Items.Add(department.DepartmentName);
                }
            }
        }

        #endregion

        #region Project Information Card

        private void dbGrid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 3 && e.ColumnIndex == 0)
            {
                _rowIndex = e.RowIndex;
                buttonCard.Top = dbGrid.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Top + dbGrid.Top + 3;
                buttonCard.Left = dbGrid.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Right - 3;
                buttonCard.Visible = true;
            }
            else
                buttonCard.Visible = false;
        }

        private void buttonCard_Click(object sender, EventArgs e)
        {
            if (!_isActiveUser)
            {
                alertBox.WarningAlert("Need permission for this action");
                return;
            }

            buttonCard.Visible = false;

            //REFACTOR THIS
            var projectDetail = projectManager.GetProjectDetail(_listedProjects[_rowIndex - 3].ProjectId);

            if (_dataCardForm == null)
            {
                _dataCardForm = new(projectDetail.Data, managementManager, departmentManager, projectManager, categoryManager, userManager, projectCapacityManager);
                _dataCardForm.FormClosed += DataGridForm_FormClosed;
                _dataCardForm.Location = dbGrid.PointToScreen(dbGrid.GetCellDisplayRectangle(0, _rowIndex, false).Location);
                _dataCardForm.Show();
            }
            else
                _dataCardForm.Activate();
        }

        private void DataGridForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_dataCardForm.ChangeAction)
                buttonList_Click(sender, e);

            _dataCardForm = null;
        }

        #endregion

        #region Button Chart Function

        private void buttonChart_Click(object sender, EventArgs e)
        {
            _dashboardForm.ChartGenerateAndActivate(sender, e);
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
            for (int i = 2; i < dbGrid.Rows.Count; i++)
            {
                legends.Add(dbGrid.Rows[i].Cells[0].Value.ToString());

                //string serieName = "series" + i.ToString();
                //list of series
                List<double> templist = new();
                for (int j = 1; j < dbGrid.Columns.Count; j++)
                {
                    if (dbGrid.Rows[i].Cells[j].Value.ToString() != "")
                        templist.Add(Convert.ToDouble(dbGrid.Rows[i].Cells[j].Value));
                    else
                        templist.Add(0);
                }
                series.Add(templist);
            }
            #endregion

            chartRequest.ChartDesignation = dbGrid.Rows[1].Cells[0].Value.ToString();
            chartRequest.Months = months;
            chartRequest.Series = series;
            chartRequest.Legends = legends;

            return chartRequest;
        }

        #endregion

        #region Button Hide Completed Projects

        private void buttonShowHide_Click(object sender, EventArgs e)
        {
            if (!isHidden)
            {
                //hide
                isHidden = true;
                foreach (var projectIndex in _completedProjectList)
                    dbGrid.Rows[projectIndex].Visible = false;
            }
            else
            {
                //unhide
                isHidden = false;
                foreach (var projectIndex in _completedProjectList)
                    dbGrid.Rows[projectIndex].Visible = true;
            }
        }

        #endregion

        #region Button Save Function

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
