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

namespace DashboardUI
{
    public partial class AdminForm : Form
    {

        UserManager userManager;

        public AdminForm()
        {
            InitializeComponent();
            userManager = new UserManager(new EfUserDal());
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            userDataGrid.DataSource = userManager.GetAll();
        }
    }
}
