using Business.Concrete;
using Core.Utilities.Results;
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
    public partial class UpdateUserForm : Form
    {
        //Form window drag to move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //Class Instances
        UserManager _userManager;
        IDataResult<User> _userData;

        //Global variables
        int _userIndex;

        public UpdateUserForm(UserManager userManager, int index)
        {
            _userManager = userManager;
            _userIndex = index;

            InitializeComponent();
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            _userData = _userManager.GetById(_userIndex);

            if (_userData.Success)
            {
                textBoxUserName.Text = _userData.Data.UserName;

                if (_userData.Data.Admin)
                {
                    checkBoxAdmin.Checked = true;
                    checkBoxAuthor.Checked = false;
                }
                else
                {
                    checkBoxAdmin.Checked = false;
                    checkBoxAuthor.Checked = true;
                }
            }
            else
                MessageBox.Show(_userData.Massage, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UpdateUserForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text != "")
            {
                var userData = _userData;
                User userToUpdate = userData.Data;
                userToUpdate.UserName = textBoxUserName.Text;
                userToUpdate.Author = checkBoxAuthor.Checked;
                userToUpdate.Admin = checkBoxAdmin.Checked;

                var userOpertaion = _userManager.Update(userToUpdate);
                if (userOpertaion.Success)
                {
                    MessageBox.Show(userOpertaion.Massage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show(userOpertaion.Massage, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Please fill empty selections!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void checkBoxAuthor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAuthor.Checked) { checkBoxAdmin.Checked = false; }
            else if (!checkBoxAdmin.Checked) { checkBoxAuthor.Checked = true; }
        }

        private void checkBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdmin.Checked) { checkBoxAuthor.Checked = false; }
            else if (!checkBoxAuthor.Checked) { checkBoxAdmin.Checked = true; }
        }
    }
}
