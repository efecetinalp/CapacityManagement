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
        UserManager _userManager;

        public CreateUserForm(UserManager userManager)
        {
            _userManager = userManager;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            comboBoxRoles.Items.Add("Author");
            comboBoxRoles.Items.Add("Admin");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            User newUser = new();
            newUser.UserName = textBoxUserName.Text.ToUpper();

            if (comboBoxRoles.SelectedIndex == 1)
            {
                newUser.Admin = true;
            }
            else if (comboBoxRoles.SelectedIndex == 0)
            {
                newUser.Author = true;
            }

            _userManager.Add(newUser);

            this.Close();
        }
    }
}
