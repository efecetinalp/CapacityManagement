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
        private UserManager _userManager;
        private User userToDelete;

        public DeleteUserForm(UserManager userManager, User user)
        {
            _userManager = userManager;
            userToDelete = user;
            InitializeComponent();
        }

        private void DeleteUserForm_Load(object sender, EventArgs e)
        {
            labelDelete.Text = userToDelete.UserName + " is going to delete permanently!" + System.Environment.NewLine + "Type: " + userToDelete.UserName + " for approval";
            textBoxDelete.PlaceholderText = userToDelete.UserName;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxDelete.Text == textBoxDelete.PlaceholderText)
            {
                _userManager.Delete(userToDelete);
                Debug.Print("delete test worked!");
            }
            else
            {
                Debug.Print("wrong input");
            }

        }
    }
}
