using Business.Concrete;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace DashboardUI
{
    public partial class AdminForm : Form
    {
        ManagementManager _managementManager;
        DepartmentManager _departmentManager;
        CategoryManager _categoryManager;
        ProjectManager _projectManager;
        UserManager _userManager;
        ProjectCapacityManager _projectCapacityManager;
        DepartmentCapacityManager _departmentCapacityManager;

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
        private bool isSorted;
        private string _tableValue;
        private int _tableIndex;

        public AdminForm(Dashboard dashboardForm, ManagementManager managementManager, DepartmentManager departmentManager, CategoryManager categoryManager,
            ProjectManager projectManager, UserManager userManager, ProjectCapacityManager projectCapacityManager, DepartmentCapacityManager departmentCapacityManager)
        {
            InitializeComponent();

            _managementManager = managementManager;
            _departmentManager = departmentManager;
            _categoryManager = categoryManager;
            _projectManager = projectManager;
            _dashboardForm = dashboardForm;
            _userManager = userManager;
            _projectCapacityManager = projectCapacityManager;
            _departmentCapacityManager = departmentCapacityManager;

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
                    _createForm = new DeleteManagementForm(_managementManager, _departmentManager, _managementManager.GetById(_tableIndex).Data);
                }
                else if (isDepartmentActive)
                {
                    _createForm = new DeleteDepartmentForm(_departmentManager, _departmentCapacityManager, _projectManager, _departmentManager.GetById(_tableIndex).Data);
                }
                else if (isProjectActive)
                {
                    _createForm = new DeleteProjectForm(_projectManager, _projectCapacityManager, _projectManager.GetById(_tableIndex).Data);
                }
                else if (isCategoryActive)
                {
                    _createForm = new DeleteCategoryForm(_categoryManager, _projectManager, _categoryManager.GetById(_tableIndex).Data);
                }
                else if (isUserActive)
                {
                    _createForm = new DeleteUserForm(_userManager, _projectManager, _userManager.GetById(_tableIndex).Data);
                }
                else
                {
                    _alertbox.ErrorAlert("No active selection");
                    return;
                }
                _createForm.FormClosed += CreateForm_FormClosed;
                _createForm.ShowDialog();
            }
            else
                _createForm.Activate();
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
                    _createForm = new CreateProjectForm(_managementManager, _departmentManager, _categoryManager, _projectManager, _userManager);
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
                    _createForm = new UpdateManagementForm(_managementManager, _tableIndex);
                }
                else if (isDepartmentActive)
                {
                    _createForm = new UpdateDepartmentForm(_managementManager, _departmentManager, _tableIndex);
                }
                else if (isProjectActive)
                {
                    _createForm = new UpdateProjectForm(_managementManager, _departmentManager, _categoryManager, _projectManager, _userManager, _tableIndex);
                }
                else if (isCategoryActive)
                {
                    _createForm = new UpdateCategoryForm(_categoryManager, _tableIndex);
                }
                else if (isUserActive)
                {
                    _createForm = new UpdateUserForm(_userManager, _tableIndex);
                }
                else
                {
                    _alertbox.ErrorAlert("No active selection");
                    return;
                }
                _createForm.FormClosed += CreateForm_FormClosed;
                _createForm.ShowDialog();
            }
            else
                _createForm.Activate();
        }

        private void CreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _createForm = null;
            RefreshDataGridView();
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
            adminDataGrid.Columns[0].Visible = false;
        }

        private void buttonDepartment_Click(object sender, EventArgs e)
        {
            ResetDataGridView();
            isDepartmentActive = true;
            adminDataGrid.DataSource = _departmentManager.GetDepartmentDetails().Data;
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

        private void RefreshDataGridView()
        {
            if (isManagementActive)
            {
                buttonManagement_Click(default, default);
            }
            else if (isDepartmentActive)
            {
                buttonDepartment_Click(default, default);
            }
            else if (isProjectActive)
            {
                buttonProject_Click(default, default);
            }
            else if (isCategoryActive)
            {
                buttonCategory_Click(default, default);
            }
            else if (isUserActive)
            {
                buttonUser_Click(default, default);
            }
            else
            {
                _alertbox.ErrorAlert("No active selection");
                return;
            }
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

            string tempPath = textBoxPath.Text;
            textBoxPath.Text = openFileDialog.FileName;

            if (textBoxPath.Text == "")
            {
                MessageBox.Show("No database selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxPath.Text = tempPath;
                return;
            }

            var exePath = Path.GetDirectoryName(
               new Uri(System.Reflection.Assembly.GetExecutingAssembly().Location).LocalPath);

            var dbLocation = exePath + "\\database_path.txt";

            StreamWriter streamWriter = new StreamWriter(dbLocation);
            streamWriter.Write(textBoxPath.Text);
            streamWriter.Close();
        }

        #endregion

        private void adminDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                string clickedCell = adminDataGrid.Columns[e.ColumnIndex].HeaderText.Trim();
                
                if (isManagementActive)
                {
                    ResetDataGridView();
                    if (!isSorted)
                    {
                        adminDataGrid.DataSource = _managementManager.GetAll().Data.OrderBy(x => x.GetType().GetProperty(clickedCell).GetValue(x, null)).ToArray();
                        isSorted = true;
                    }
                    else
                    {
                        adminDataGrid.DataSource = _managementManager.GetAll().Data.OrderByDescending(x => x.GetType().GetProperty(clickedCell).GetValue(x, null)).ToArray();
                        isSorted = false;
                    }

                    isManagementActive = true;
                    adminDataGrid.Columns[0].Visible = false;
                }
                else if (isDepartmentActive)
                {
                    ResetDataGridView();
                    if (!isSorted)
                    {
                        adminDataGrid.DataSource = _departmentManager.GetDepartmentDetails().Data.OrderBy(x => x.GetType().GetProperty(clickedCell).GetValue(x, null)).ToArray();
                        isSorted = true;
                    }
                    else
                    {
                        adminDataGrid.DataSource = _departmentManager.GetDepartmentDetails().Data.OrderByDescending(x => x.GetType().GetProperty(clickedCell).GetValue(x, null)).ToArray();
                        isSorted = false;
                    }

                    isDepartmentActive = true;
                    adminDataGrid.Columns[0].Visible = false;
                    adminDataGrid.Columns[3].Visible = false;
                }
                else if (isProjectActive)
                {
                    ResetDataGridView();
                    if (!isSorted)
                    {
                        adminDataGrid.DataSource = _projectManager.GetProjectDetails().Data.OrderBy(x => x.GetType().GetProperty(clickedCell).GetValue(x, null)).ToArray();
                        isSorted = true;
                    }
                    else
                    {
                        adminDataGrid.DataSource = _projectManager.GetProjectDetails().Data.OrderByDescending(x => x.GetType().GetProperty(clickedCell).GetValue(x, null)).ToArray();
                        isSorted = false;
                    }

                    isProjectActive = true;
                    adminDataGrid.Columns[0].Visible = false;
                    adminDataGrid.Columns[9].Visible = false;
                    adminDataGrid.Columns[10].Visible = false;
                    adminDataGrid.Columns[11].Visible = false;
                    adminDataGrid.Columns[12].Visible = false;
                }
                else if (isCategoryActive)
                {
                    ResetDataGridView();
                    if (!isSorted)
                    {
                        adminDataGrid.DataSource = _categoryManager.GetAll().Data.OrderBy(x => x.GetType().GetProperty(clickedCell).GetValue(x, null)).ToArray();
                        isSorted = true;
                    }
                    else
                    {
                        adminDataGrid.DataSource = _categoryManager.GetAll().Data.OrderByDescending(x => x.GetType().GetProperty(clickedCell).GetValue(x, null)).ToArray();
                        isSorted = false;
                    }

                    isCategoryActive = true;
                    adminDataGrid.Columns[0].Visible = false;
                }
                else if (isUserActive)
                {
                    ResetDataGridView();
                    if (!isSorted)
                    {
                        adminDataGrid.DataSource = _userManager.GetAll().Data.OrderBy(x => x.GetType().GetProperty(clickedCell).GetValue(x, null)).ToArray();
                        isSorted = true;
                    }
                    else
                    {
                        adminDataGrid.DataSource = _userManager.GetAll().Data.OrderByDescending(x => x.GetType().GetProperty(clickedCell).GetValue(x, null)).ToArray();
                        isSorted = false;
                    }

                    isUserActive = true;
                    adminDataGrid.Columns[0].Visible = false;
                }
            }
        }
    }
}

