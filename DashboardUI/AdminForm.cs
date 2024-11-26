using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DashboardUI
{
    public partial class AdminForm : Form
    {
        UserManager userManager;

        ToolTip toolTip;

        public AdminForm()
        {
            InitializeComponent();
            userManager = new UserManager(new EfUserDal());
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            userDataGrid.DataSource = userManager.GetAll().Data;
            toolTip = new ToolTip();
            toolTip.SetToolTip(this.buttonCreate, "Create New User");
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new();
            createUser.FormClosed += CreateUser_FormClosed;
            createUser.ShowDialog();
        }

        private void CreateUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshUserList();
        }

        private void RefreshUserList()
        {
            //reset gridview
            userDataGrid.DataSource = null;
            userDataGrid.Rows.Clear();
            userDataGrid.Columns.Clear();
            userDataGrid.DataSource = userManager.GetAll().Data;
        }
    }
}
