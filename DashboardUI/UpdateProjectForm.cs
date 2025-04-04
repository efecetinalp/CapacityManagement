using Business.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace DashboardUI
{
    public partial class UpdateProjectForm : Form
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

        //Data results
        IDataResult<ProjectDetailDto> _projectData;
        IDataResult<List<Management>> _managementData;
        IDataResult<List<Department>> _departmentData;
        IDataResult<List<Category>> _categoryData;
        IDataResult<List<User>> _userData;

        //Global variables
        int _projectIndex;
        List<int> _managementIndexes = new();
        List<int> _departmentIndexes = new();
        List<int> _categoryIndexes = new();
        List<int> _userIndexes = new();

        public UpdateProjectForm(ManagementManager managementManager, DepartmentManager departmentManager, CategoryManager categoryManager, ProjectManager projectManager, UserManager userManager, int index)
        {
            _managementManager = managementManager;
            _departmentManager = departmentManager;
            _categoryManager = categoryManager;
            _projectManager = projectManager;
            _userManager = userManager;
            _projectIndex = index;

            InitializeComponent();
            new DropShadow().ApplyShadows(this);

        }

        private void UpdateProjectForm_Load(object sender, EventArgs e)
        {
            //fetch data from database
            _managementData = _managementManager.GetAll();
            _categoryData = _categoryManager.GetAll();
            _projectData = _projectManager.GetProjectDetail(_projectIndex);
            _userData = _userManager.GetAll();

            #region Project Data
            if (!_projectData.Success)
            {
                MessageBox.Show(_projectData.Massage, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            #region Management Data
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

            //update data in form window
            textBoxProject.Text = _projectData.Data.ProjectName;
            comboBoxManagement.SelectedIndex = comboBoxManagement.Items.IndexOf(_projectData.Data.ManagementName);
            comboBoxDepartment.SelectedIndex = comboBoxDepartment.Items.IndexOf(_projectData.Data.DepartmentName);
            comboBoxCategory.SelectedIndex = comboBoxCategory.Items.IndexOf(_projectData.Data.CategoryName);
            comboBoxUser.SelectedIndex = comboBoxUser.Items.IndexOf(_projectData.Data.UserName);
            dateTimePickerStart.Value = _projectData.Data.StartDate;
            checkBoxCompleted.Checked = _projectData.Data.IsCompleted;
            if (checkBoxCompleted.Checked)
            {
                dateTimePickerEnd.Enabled = true;
                dateTimePickerEnd.Value = _projectData.Data.EndDate;
            }
        }

        private void UpdateProjectForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxProject.Text != "" && comboBoxManagement.SelectedIndex > -1 && comboBoxDepartment.SelectedIndex > -1 && comboBoxCategory.SelectedIndex > -1 && comboBoxUser.SelectedIndex > -1)
            {
                var projectData = _projectManager.GetById(_projectIndex);

                if (projectData.Success)
                {
                    Project projectToUpdate = projectData.Data;
                    projectToUpdate.ProjectName = textBoxProject.Text;
                    projectToUpdate.ManagementId = _managementIndexes[comboBoxManagement.SelectedIndex];
                    projectToUpdate.DepartmentId = _departmentIndexes[comboBoxDepartment.SelectedIndex];
                    projectToUpdate.CategoryId = _categoryIndexes[comboBoxCategory.SelectedIndex];
                    projectToUpdate.UserId = _userIndexes[comboBoxUser.SelectedIndex];

                    DateTime startDate = dateTimePickerStart.Value;
                    startDate = new DateTime(startDate.Year, startDate.Month, 01);
                    projectToUpdate.StartDate = startDate;

                    projectToUpdate.IsCompleted = checkBoxCompleted.Checked;

                    if (checkBoxCompleted.Checked)
                    {
                        DateTime endDate = dateTimePickerEnd.Value;
                        endDate = new DateTime(endDate.Year, endDate.Month, 01);
                        projectToUpdate.EndDate = endDate;
                    }


                    var projectOperation = _projectManager.Update(projectToUpdate);
                    if (projectOperation.Success)
                    {
                        MessageBox.Show(projectOperation.Massage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show(projectOperation.Massage, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(projectData.Massage, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void comboBoxManagement_SelectedIndexChanged(object sender, EventArgs e)
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
