using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DashboardUI
{
    public partial class AdminForm : Form
    {
        ManagementManager _managementManager;
        DepartmentManager _departmentManager;
        CategoryManager _categoryManager;
        ProjectManager _projectManager;
        UserManager _userManager;

        AlertBox _alertbox;
        ToolTip toolTip;
        Dashboard _dashboardForm;
        Form _createForm;

        private string _tempCellValue;
        private int _rowIndex;
        private bool isManagementActive;
        private bool isDepartmentActive;
        private bool isProjectActive;
        private bool isCategoryActive;
        private bool isUserActive;
        private string _tableValue;
        private int _tableIndex;

        public AdminForm(Dashboard dashboardForm, ManagementManager managementManager, DepartmentManager departmentManager, CategoryManager categoryManager, ProjectManager projectManager, UserManager userManager)
        {
            InitializeComponent();

            _managementManager = managementManager;
            _departmentManager = departmentManager;
            _categoryManager = categoryManager;
            _projectManager = projectManager;
            _dashboardForm = dashboardForm;
            _userManager = userManager;

            var exePath = Path.GetDirectoryName(
               new Uri(System.Reflection.Assembly.GetExecutingAssembly().Location).LocalPath);

            var dbLocation = exePath + "\\database_path.txt";
            StreamReader streamReader = new StreamReader(dbLocation);
            textBoxPath.Text = streamReader.ReadLine();
            streamReader.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            _alertbox = new AlertBox(_dashboardForm);
        }

        #region CRUD Operations

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_createForm == null)
            {
                if (isManagementActive)
                {
                    _createForm = new DeleteManagementForm(_managementManager, _managementManager.GetById(_tableIndex).Data);
                }
                else if (isDepartmentActive)
                {
                    //_createForm = new DeleteManagementForm(_tableValue);
                }
                else if (isProjectActive)
                {
                   // _createForm = new DeleteManagementForm(_tableValue);
                }
                else if (isCategoryActive)
                {
                   // _createForm = new DeleteManagementForm(_tableValue);
                }
                else if (isUserActive)
                {
                   // _createForm = new DeleteManagementForm(_tableValue);
                }
                else
                {
                    _alertbox.ErrorAlert("No active selection");
                    return;
                }
                _createForm.Location = adminDataGrid.PointToScreen(adminDataGrid.GetCellDisplayRectangle(1, _rowIndex, false).Location);
                _createForm.FormClosed += CreateForm_FormClosed;
                _createForm.ShowDialog();
            }
            else
                _createForm.Activate();
        }

        private void adminDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            adminDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = _tempCellValue;
        }

        private void adminDataGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _tempCellValue = adminDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (_createForm == null)
            {
                if (isManagementActive)
                {
                    _createForm = new CreateManagementForm(_managementManager);
                }
                else if (isDepartmentActive)
                {
                    _createForm = new CreateDepartmentForm(_managementManager, _departmentManager);
                }
                else if (isProjectActive)
                {
                    _createForm = new CreateProjectForm(_managementManager, _departmentManager, _categoryManager, _projectManager);
                }
                else if (isCategoryActive)
                {
                    _createForm = new CreateCategoryForm(_categoryManager);
                }
                else if (isUserActive)
                {
                    _createForm = new CreateUserForm(_userManager);
                }
                else
                {
                    _alertbox.ErrorAlert("No active selection");
                    return;
                }
                _createForm.Location = adminDataGrid.PointToScreen(adminDataGrid.GetCellDisplayRectangle(1, _rowIndex, false).Location);
                _createForm.FormClosed += CreateForm_FormClosed;
                _createForm.ShowDialog();
            }
            else
                _createForm.Activate();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (_createForm == null)
            {
                if (isManagementActive)
                {
                    _createForm = new UpdateManagementForm(_managementManager, _tableValue);
                }
                else if (isDepartmentActive)
                {
                    _createForm = new UpdateDepartmentForm(_managementManager, _departmentManager, _tableValue);
                }
                else if (isProjectActive)
                {
                    _createForm = new UpdateProjectForm(_managementManager, _departmentManager, _categoryManager, _projectManager, _tableValue);
                }
                else if (isCategoryActive)
                {
                    _createForm = new UpdateCategoryForm(_categoryManager, _tableValue);
                }
                else if (isUserActive)
                {
                    _createForm = new UpdateUserForm(_userManager, _tableValue);
                }
                else
                {
                    _alertbox.ErrorAlert("No active selection");
                    return;
                }
                _createForm.Location = adminDataGrid.PointToScreen(adminDataGrid.GetCellDisplayRectangle(1, _rowIndex, false).Location);
                _createForm.FormClosed += CreateForm_FormClosed;
                _createForm.ShowDialog();
            }
            else
                _createForm.Activate();
        }

        private void CreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _createForm = null;
        }

        private void adminDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isUserActive)
            {
                if (e.ColumnIndex > 1 && e.RowIndex > -1)
                {
                    var userIndex = adminDataGrid.Rows[adminDataGrid.CurrentCell.RowIndex].Cells[0].Value;
                    User userToUpdate = _userManager.GetById(Convert.ToInt32(userIndex)).Data;

                    if (e.ColumnIndex == 2)
                    {
                        userToUpdate.Admin = true;
                        userToUpdate.Author = false;
                        _userManager.Update(userToUpdate);

                        //notification
                        _alertbox.SuccessAlert("User set as Admin Role!");
                    }
                    else if (e.ColumnIndex == 3)
                    {
                        userToUpdate.Admin = false;
                        userToUpdate.Author = true;
                        _userManager.Update(userToUpdate);

                        //notification
                        _alertbox.SuccessAlert("User set as Author Role!");
                    }
                }
            }
        }

        private void adminDataGrid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                buttonCreate.Visible = true;
            else
                buttonCreate.Visible = false;

            if (e.RowIndex > -1)
            {
                _rowIndex = e.RowIndex;
                buttonDelete.Top = adminDataGrid.GetCellDisplayRectangle(-1, e.RowIndex, false).Top + adminDataGrid.Top + 3;
                buttonDelete.Left = adminDataGrid.GetCellDisplayRectangle(-1, e.RowIndex, false).Left + 24;
                buttonDelete.Visible = true;
                buttonEdit.Top = adminDataGrid.GetCellDisplayRectangle(-1, e.RowIndex, false).Top + adminDataGrid.Top + 3;
                buttonEdit.Left = adminDataGrid.GetCellDisplayRectangle(-1, e.RowIndex, false).Left + 46;
                _tableValue = adminDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                _tableIndex = Convert.ToInt32(adminDataGrid.Rows[e.RowIndex].Cells[0].Value);
                buttonEdit.Visible = true;
            }
            else
            {
                buttonDelete.Visible = false;
                buttonEdit.Visible = false;
            }
        }

        private void buttonManagement_Click(object sender, EventArgs e)
        {
            ResetDataGridView();
            isManagementActive = true;
            adminDataGrid.DataSource = _managementManager.GetAll().Data;
            adminDataGrid.Columns["ManagementName"].HeaderText = "Management Name";
            adminDataGrid.Columns[0].Visible = false;
        }

        private void buttonDepartment_Click(object sender, EventArgs e)
        {
            ResetDataGridView();
            isDepartmentActive = true;
            adminDataGrid.DataSource = _departmentManager.GetDepartmentDetails().Data;
            adminDataGrid.Columns[1].HeaderText = "Department Name";
            adminDataGrid.Columns[0].Visible = false;
            adminDataGrid.Columns[3].Visible = false;
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            ResetDataGridView();
            isCategoryActive = true;
            adminDataGrid.DataSource = _categoryManager.GetAll().Data;
            adminDataGrid.Columns[0].Visible = false;
        }

        private void buttonProject_Click(object sender, EventArgs e)
        {
            ResetDataGridView();
            isProjectActive = true;
            adminDataGrid.DataSource = _projectManager.GetProjectDetails().Data;
            adminDataGrid.Columns[1].HeaderText = "Project Name";
            adminDataGrid.Columns[0].Visible = false;
            adminDataGrid.Columns[9].Visible = false;
            adminDataGrid.Columns[10].Visible = false;
            adminDataGrid.Columns[11].Visible = false;
            adminDataGrid.Columns[12].Visible = false;
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            ResetDataGridView();
            isUserActive = true;
            adminDataGrid.DataSource = _userManager.GetAll().Data;
            adminDataGrid.Columns[1].HeaderText = "User Name";
            adminDataGrid.Columns[0].Visible = false;
        }

        private void ResetDataGridView()
        {
            //reset gridview
            isManagementActive = false;
            isDepartmentActive = false;
            isCategoryActive = false;
            isProjectActive = false;
            isUserActive = false;
            adminDataGrid.DataSource = null;
            adminDataGrid.Rows.Clear();
            adminDataGrid.Columns.Clear();
        }

        #endregion

        #region Change Database Path

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select database location";
            openFileDialog.DefaultExt = "accdb";
            openFileDialog.Filter = "Access database (*.accdb)|*.accdb";
            openFileDialog.ShowDialog();

            textBoxPath.Text = openFileDialog.FileName;

            var exePath = Path.GetDirectoryName(
               new Uri(System.Reflection.Assembly.GetExecutingAssembly().Location).LocalPath);

            var dbLocation = exePath + "\\database_path.txt";

            StreamWriter streamWriter = new StreamWriter(dbLocation);
            streamWriter.Write(textBoxPath.Text);
            streamWriter.Close();
        }

        #endregion

    }
}

