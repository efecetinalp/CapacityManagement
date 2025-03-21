using Business.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardUI
{
    public partial class UpdateUserForm : Form
    {
        UserManager _userManager;
        string _tableValue;

        public UpdateUserForm(UserManager userManager, string value)
        {
            _userManager = userManager;
            _tableValue = value;

            InitializeComponent();
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
