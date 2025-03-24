using Business.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardUI
{
    public partial class DataCardUI : Form
    {
        //Form window drag to move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //Form wind rounded corner
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        //Class Instances
        ManagementManager _managementManager;
        DepartmentManager _departmentManager;
        ProjectManager _projectManager;
        CategoryManager _categoryManager;
        UserManager _userManager;
        ProjectDetailDto _projectDetail;
        ProjectCapacityManager _projectCapacityManager;

        IDataResult<List<Category>> _categoryData;
        IDataResult<List<User>> _userData;

        List<int> _categoryIndexes = new();
        List<int> _userIndexes = new();

        Form _deleteForm;

        public DataCardUI(ProjectDetailDto projectDetail, ManagementManager managementManager, DepartmentManager departmentManager, ProjectManager projectManager, CategoryManager categoryManager, 
            UserManager userManager, ProjectCapacityManager projectCapacityManager)
        {
            _projectDetail = projectDetail;
            InitializeComponent();
            _managementManager = managementManager;
            _departmentManager = departmentManager;
            _projectManager = projectManager;
            _categoryManager = categoryManager;
            _userManager = userManager;
            _projectCapacityManager = projectCapacityManager;
        }

        private void DataCardUI_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

            //Project Card Information
            lblProjectName.Text = _projectDetail.ProjectName;
            if (lblProjectName.Width > 340)
            {
                float i = 13;
                do
                {
                    lblProjectName.Font = new Font("Calibri", i);
                    i--;
                } while (lblProjectName.Width > 340);
            }

            lblManagement.Text = _projectDetail.ManagementName;
            lblDepartment.Text = _projectDetail.DepartmentName;
            lblCategory.Text = _projectDetail.CategoryName;
            lblStartDate.Text = _projectDetail.StartDate.ToString("MMM-yy");
            lblOwner.Text = _projectDetail.UserName;

            if (!_projectDetail.IsCompleted)
            {
                lblStatus.Text = "Progressing";
                lblEndDate.Text = "N/A";
            }
            else
            {
                lblStatus.Text = "Completed";
                lblEndDate.Text = _projectDetail.EndDate.ToString("MMM-yy");
            }

            //Project Card Edit Information
            txtProjectName.Text = _projectDetail.ProjectName;
            checkBoxCompleted.Checked = _projectDetail.IsCompleted;
            dateTimePickerStart.Value = _projectDetail.StartDate;
            dateTimePickerEnd.Value = _projectDetail.EndDate;

            _categoryData = _categoryManager.GetAll();
            _userData = _userManager.GetAll();

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

        private void DataCardUI_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void checkBoxIsProgressing_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxCompleted.Checked)
                dateTimePickerEnd.Enabled = false;
            else
                dateTimePickerEnd.Enabled = true;
        }

        #region Edit Button Function

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //start edit mode
            BeginEditMode();
        }

        private void BeginEditMode()
        {
            buttonEdit.Visible = false;
            buttonSave.Visible = true;
            buttonDelete.Visible = false;

            lblProjectName.Visible = false;
            lblCategory.Visible = false;
            lblStatus.Visible = false;
            lblStartDate.Visible = false;
            lblEndDate.Visible = false;
            lblOwner.Visible = false;

            txtProjectName.Visible = true;
            comboBoxCategory.Visible = true;
            dateTimePickerStart.Visible = true;
            dateTimePickerEnd.Visible = true;
            checkBoxCompleted.Visible = true;
            comboBoxUser.Visible = true;

            if (!_projectDetail.IsCompleted)
                dateTimePickerEnd.Enabled = false;
        }

        private void QuitEditMode()
        {
            buttonEdit.Visible = true;
            buttonSave.Visible = false;
            buttonDelete.Visible = true;

            lblProjectName.Visible = true;
            lblCategory.Visible = true;
            lblStatus.Visible = true;
            lblStartDate.Visible = true;
            lblEndDate.Visible = true;
            lblOwner.Visible = true;

            txtProjectName.Visible = false;
            comboBoxCategory.Visible = false;
            dateTimePickerStart.Visible = false;
            dateTimePickerEnd.Visible = false;
            checkBoxCompleted.Visible = false;
            comboBoxUser.Visible = false;
        }

        #endregion

        #region Save Button Function

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //save edited card
            if (txtProjectName.Text != "" && comboBoxCategory.SelectedIndex > -1 && comboBoxUser.SelectedIndex > -1)
            {
                var projectData = _projectManager.GetById(_projectDetail.ProjectId);

                if (projectData.Success)
                {
                    Project projectToUpdate = projectData.Data;
                    projectToUpdate.ProjectName = txtProjectName.Text;
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
                        //UI change
                        RefreshCard();
                        QuitEditMode();
                        MessageBox.Show(projectOperation.Massage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void RefreshCard()
        {
            lblProjectName.Text = txtProjectName.Text;
            if (lblProjectName.Width > 340)
            {
                float i = 13;
                do
                {
                    lblProjectName.Font = new Font("Calibri", i);
                    i--;
                } while (lblProjectName.Width > 340);
            }
            lblCategory.Text = comboBoxCategory.Text;
            lblOwner.Text = comboBoxUser.Text;
            lblStartDate.Text = dateTimePickerStart.Value.ToString("MMM-yy");
            if (!_projectDetail.IsCompleted)
            {
                lblStatus.Text = "Progressing";
                lblEndDate.Text = "N/A";
            }
            else
            {
                lblStatus.Text = "Completed";
                lblEndDate.Text = dateTimePickerEnd.Value.ToString("MMM-yy");
            }
        }
        #endregion

        #region Delete Button Function

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_deleteForm == null)
            {
                Project projectToDelete = _projectManager.GetById(_projectDetail.ProjectId).Data;
                _deleteForm = new DeleteProjectForm(_projectManager, _projectCapacityManager, projectToDelete);

                _deleteForm.Left = this.Left;
                _deleteForm.Top = this.Top;
                _deleteForm.FormClosed += DeleteForm_FormClosed;
                _deleteForm.ShowDialog();
            }
            else
                _deleteForm.Activate();
        }

        private void DeleteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _deleteForm = null;
        }

        #endregion

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
