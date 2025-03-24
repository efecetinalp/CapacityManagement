using Business.Concrete;
using Entities.Concrete;
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
    public partial class DeleteUserForm : Form
    {
        //Form window drag to move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private UserManager _userManager;
        private ProjectManager _projectManager;
        private User _userToDelete;

        public DeleteUserForm(UserManager userManager, ProjectManager projectManageer, User user)
        {
            _userManager = userManager;
            _projectManager = projectManageer;
            _userToDelete = user;
            InitializeComponent();
        }

        private void DeleteUserForm_Load(object sender, EventArgs e)
        {
            textBoxDelete.Enabled = false;

            var projectList = _projectManager.GetAllByUserId(_userToDelete.UserId);

            labelDelete.Text = "You are going to delete " + _userToDelete.UserName + " permanently!"
                + Environment.NewLine + projectList.Data.Count + " project(s) will effect by this action and datas will be lost! "
                + Environment.NewLine + "Type: DELETE USER for approval";

            //Delete Confirmation
            textBoxDelete.PlaceholderText = "DELETE USER";
        }

        private void DeleteUserForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxDelete.Text.ToUpper() == textBoxDelete.PlaceholderText.ToUpper() && checkBoxApproval.Checked)
            {
                var userOperation = _userManager.Delete(_userToDelete);
                if (userOperation.Success)
                {
                    MessageBox.Show(userOperation.Massage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show(userOperation.Massage, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Wrong input entered!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxApproval_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxApproval.Checked)
                textBoxDelete.Enabled = true;
            else
                textBoxDelete.Enabled = false;
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
