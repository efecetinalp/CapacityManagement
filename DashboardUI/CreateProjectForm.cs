using Business.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace DashboardUI
{
    public partial class CreateProjectForm : Form
    {
        //Form window drag to move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //Class Instances
        ManagementManager _managementManager;
        DepartmentManager _departmentManager;
        CategoryManager _categoryManager;
        ProjectManager _projectManager;
        UserManager _userManager;
        Management _management;
        Department _department;

        //Data results
        IDataResult<ProjectDetailDto> _projectData;
        IDataResult<List<Management>> _managementData;
        IDataResult<List<Department>> _departmentData;
        IDataResult<List<Category>> _categoryData;
        IDataResult<List<User>> _userData;

        //Global variables
        List<int> _managementIndexes = new();
        List<int> _departmentIndexes = new();
        List<int> _categoryIndexes = new();
        List<int> _userIndexes = new();
        bool isRestriced = false;

        public CreateProjectForm(ManagementManager managementManager, DepartmentManager departmentManager, CategoryManager categoryManager, ProjectManager projectManager, UserManager userManager)
        {
            _managementManager = managementManager;
            _departmentManager = departmentManager;
            _categoryManager = categoryManager;
            _projectManager = projectManager;
            _userManager = userManager;

            InitializeComponent();
            new DropShadow().ApplyShadows(this);

        }

        public CreateProjectForm(Management management, Department department, CategoryManager categoryManager, ProjectManager projectManager, UserManager userManager)
        {
            _management = management;
            _department = department;
            _categoryManager = categoryManager;
            _projectManager = projectManager;
            _userManager = userManager;
            isRestriced = true;

            InitializeComponent();
        }

        private void CreateProjectForm_Load(object sender, EventArgs e)
        {
            //fetch data from database
            if (!isRestriced)
                _managementData = _managementManager.GetAll();

            _categoryData = _categoryManager.GetAll();
            _userData = _userManager.GetAll();

            #region Management Data
            if (!isRestriced)
            {
                if (_managementData.Success)
                {
                    foreach (var management in _managementData.Data)
                    {
                        comboBoxManagement.Items.Add(management.ManagementName);
                        _managementIndexes.Add(management.ManagementId);
                    }
                }
                else
                {
                    MessageBox.Show(_managementData.Massage, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                comboBoxManagement.Items.Add(_management.ManagementName);
                comboBoxDepartment.Items.Add(_department.DepartmentName);
                comboBoxManagement.SelectedIndex = 0;
                comboBoxDepartment.SelectedIndex = 0;
            }
            #endregion

            #region Category Data
            if (_categoryData.Success)
            {
                foreach (var category in _categoryData.Data)
                {
                    comboBoxCategory.Items.Add(category.CategoryName);
                    _categoryIndexes.Add(category.CategoryId);
                }
            }
            else
            {
                MessageBox.Show(_categoryData.Massage, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            #region User Data
            if (_userData.Success)
            {
                foreach (var user in _userData.Data)
                {
                    comboBoxUser.Items.Add(user.UserName);
                    _userIndexes.Add(user.UserId);
                }
            }
            else
            {
                MessageBox.Show(_userData.Massage, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

        }

        private void CreateProjectForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void comboBoxManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isRestriced)
            {
                comboBoxDepartment.Items.Clear();
                comboBoxDepartment.SelectedIndex = -1;

                #region Department Data
                _departmentData = _departmentManager.GetAllByManagementId(_managementIndexes[comboBoxManagement.SelectedIndex]);

                if (_departmentData.Success)
                {
                    _departmentIndexes.Clear();
                    foreach (var department in _departmentData.Data)
                    {
                        comboBoxDepartment.Items.Add(department.DepartmentName);
                        _departmentIndexes.Add(department.DepartmentId);
                    }
                }
                else
                    MessageBox.Show(_departmentData.Massage, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                #endregion
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textBoxProject.Text != "" && comboBoxManagement.SelectedIndex > -1 && comboBoxDepartment.SelectedIndex > -1 && comboBoxCategory.SelectedIndex > -1 && comboBoxUser.SelectedIndex > -1)
            {
                Project projectToCreate = new();
                projectToCreate.ProjectName = textBoxProject.Text;

                if (!isRestriced)
                {
                    projectToCreate.ManagementId = _managementIndexes[comboBoxManagement.SelectedIndex];
                    projectToCreate.DepartmentId = _departmentIndexes[comboBoxDepartment.SelectedIndex];
                }
                else
                {
                    projectToCreate.ManagementId = _management.ManagementId;
                    projectToCreate.DepartmentId = _department.DepartmentId;
                }

                projectToCreate.CategoryId = _categoryIndexes[comboBoxCategory.SelectedIndex];
                projectToCreate.UserId = _userIndexes[comboBoxUser.SelectedIndex];

                DateTime startDate = dateTimePickerStart.Value;
                startDate = new DateTime(startDate.Year, startDate.Month, 01);
                projectToCreate.StartDate = startDate;

                projectToCreate.IsCompleted = checkBoxCompleted.Checked;

                if (checkBoxCompleted.Checked)
                {
                    DateTime endDate = dateTimePickerEnd.Value;
                    endDate = new DateTime(endDate.Year, endDate.Month, 01);
                    projectToCreate.EndDate = endDate;
                }

                var projectOperation = _projectManager.Add(projectToCreate);
                if (projectOperation.Success)
                {
                    MessageBox.Show(projectOperation.Massage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show(projectOperation.Massage, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Please fill empty selections!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCompleted.Checked) { dateTimePickerEnd.Enabled = true; }
            else { dateTimePickerEnd.Enabled = false; }
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
