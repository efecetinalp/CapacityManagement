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
    public partial class LoginForm : Form
    {
        UserManager _userManager;
        public User currentUser;

        public LoginForm(UserManager userManager)
        {
            _userManager = userManager;
 
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void buttonLogin_Click(object sender, EventArgs e)
        //{
        //    if (textBoxUserName.Text != "" && textBoxPassword.Text != "")
        //    {
        //        var userDataResult = _userManager.GetByUserName(textBoxUserName.Text.ToUpper());
        //        if (userDataResult.Success)
        //        {

        //            if (userDataResult.Data.Password == textBoxPassword.Text)
        //            {
        //                Debug.Print("login success");
        //                currentUser = userDataResult.Data;
        //                this.Close();
        //            }
        //            else
        //                Debug.Print("incorrect");
        //        }
        //        else
        //            Debug.Print("not avaiable");
        //    }
        //    else
        //    {
        //        Debug.Print("empty fields");
        //    }
        //}
    }
}
