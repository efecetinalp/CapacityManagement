using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
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
    public partial class CreateUserForm : Form
    {
        //Form window drag to move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        UserManager _userManager;

        public CreateUserForm(UserManager userManager)
        {
            _userManager = userManager;
            InitializeComponent();
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            checkBoxAuthor.Checked = true;
        }

        private void CreateUserForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text != "")
            {
                User userToCreate = new();
                userToCreate.UserName = textBoxUserName.Text.ToUpper();
                userToCreate.Author = checkBoxAuthor.Checked;
                userToCreate.Admin = checkBoxAdmin.Checked;

                var userOpertaion = _userManager.Add(userToCreate);
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
