using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.IO;
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

        AlertBox alertBox;
        ToolTip toolTip;
        Dashboard _dashboardForm;
        CreateForm _createForm;

        object _tempCellValue;

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
            alertBox = new AlertBox(_dashboardForm);
        }

        #region CRUD User

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new();
            createUser.FormClosed += CreateUser_FormClosed;
            createUser.ShowDialog();
        }

        private void CreateUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            ResetDataGridView();
        }

        private void ResetDataGridView()
        {
            //reset gridview
            adminDataGrid.DataSource = null;
            adminDataGrid.Rows.Clear();
            adminDataGrid.Columns.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete selected user permanently!", "User Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var userIndex = adminDataGrid.Rows[adminDataGrid.CurrentCell.RowIndex].Cells[0].Value;
                User userToDelete = _userManager.GetById(Convert.ToInt32(userIndex)).Data;
                _userManager.Delete(userToDelete);

                alertBox.SuccessAlert("User deleted!");
            }

            ResetDataGridView();
        }

        private void userDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    alertBox.SuccessAlert("User set as Admin Role!");
                }
                else if (e.ColumnIndex == 3)
                {
                    userToUpdate.Admin = false;
                    userToUpdate.Author = true;
                    _userManager.Update(userToUpdate);

                    //notification
                    alertBox.SuccessAlert("User set as Author Role!");
                }
                ResetDataGridView();
            }
        }

        private void userDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                var cellValue = adminDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                //check if cell value is changed
                if (_tempCellValue != cellValue)
                {
                    if (cellValue != null)
                    {
                        var userIndex = adminDataGrid.Rows[adminDataGrid.CurrentCell.RowIndex].Cells[0].Value;
                        User userToUpdate = _userManager.GetById(Convert.ToInt32(userIndex)).Data;
                        userToUpdate.UserName = cellValue.ToString();
                        _userManager.Update(userToUpdate);

                        //notification
                        alertBox.SuccessAlert("User name is updated!");
                    }
                    else
                    {
                        adminDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = _tempCellValue;

                        //notification
                        alertBox.ErrorAlert("User name cannot be empty!");
                    }
                }
                else
                {
                    //notification
                    alertBox.WarningAlert("The value is not changed!");
                }
            }
        }

        private void userDataGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _tempCellValue = adminDataGrid.Rows[e.RowIndex].Cells[1].Value;
        }

        private void buttonManagement_Click(object sender, EventArgs e)
        {
            ResetDataGridView();

            adminDataGrid.DataSource = _managementManager.GetAll().Data;
            adminDataGrid.Columns[0].Visible = false;
        }

        private void buttonDepartment_Click(object sender, EventArgs e)
        {
            ResetDataGridView();

            adminDataGrid.DataSource = _departmentManager.GetAll().Data;
            adminDataGrid.Columns[0].Visible = false;
            adminDataGrid.Columns[1].Visible = false;
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            ResetDataGridView();

            adminDataGrid.DataSource = _categoryManager.GetAll().Data;
            adminDataGrid.Columns[0].Visible = false;
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            ResetDataGridView();

            adminDataGrid.DataSource = _userManager.GetAll().Data;
            adminDataGrid.Columns[0].Visible = false;
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

        private void buttonNew_Click(object sender, EventArgs e)
        {
            if (_createForm == null)
            {
                _createForm = new CreateForm(_managementManager, _departmentManager, _categoryManager, _projectManager);
                _createForm.FormClosed += CreateForm_FormClosed;
                _createForm.ShowDialog();
            }
            else
            {
                _createForm.Activate();
            }
        }

        private void CreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _createForm = null;
        }
    }
}

