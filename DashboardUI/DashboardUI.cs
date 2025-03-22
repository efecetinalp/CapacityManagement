using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.Data.SqlClient.Server;
using Microsoft.EntityFrameworkCore.Diagnostics.Internal;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace DashboardUI
{
    public partial class Dashboard : Form
    {
        DataGridForm dataGridForm;
        DashboardForm dashboardForm;
        ChartForm chartForm;
        AdminForm adminForm;

        //database manager referances
        ManagementManager managementManager;
        DepartmentManager departmentManager;
        CategoryManager categoryManager;
        ProjectManager projectManager;
        ProjectCapacityManager projectCapacityManager;
        DepartmentCapacityManager departmentCapacityManager;
        UserManager userManager;
        ColorCodeManager colorCodeManager;
        ColorPaletteManager colorPaletteManager;

        //user credentials
        public User activeUser;

        public Dashboard()
        {
            managementManager = new ManagementManager(new EfManagementDal());
            departmentManager = new DepartmentManager(new EfDepartmentDal());
            categoryManager = new CategoryManager(new EfCategoryDal());
            projectManager = new ProjectManager(new EfProjectDal());
            projectCapacityManager = new ProjectCapacityManager(new EfProjectCapacityDal());
            departmentCapacityManager = new DepartmentCapacityManager(new EfDepartmentCapacityDal());
            userManager = new UserManager(new EfUserDal());
            colorCodeManager = new ColorCodeManager(new EfColorCodeDal());
            colorPaletteManager = new ColorPaletteManager(new EfColorPaletteDal());

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Delete later
            //Start with datagrid form
            UserLogin();
            MoveSlideBar(panelDataGrid);
            dataGridForm = new(projectManager, departmentManager, managementManager, categoryManager, departmentCapacityManager, projectCapacityManager, userManager, this);
            dataGridForm.FormClosed += DataGridForm_FormClosed;
            dataGridForm.MdiParent = this;
            dataGridForm.Dock = DockStyle.Fill;
            dataGridForm.Show();
        }

        private void UserLogin()
        {
            activeUser = userManager.GetByUserName(Environment.UserName.ToUpper()).Data;
            labelActiveUser.Text = labelActiveUser.Text.Replace("Signing...", Environment.UserName.ToUpper());

            if (activeUser != null)
            {
                labelCredential.Text = "AUTHOR";

                if (activeUser.Admin)
                {
                    labelCredential.Text = "ADMIN";
                    buttonAdmin.Visible = true;
                }
            }
            else
                labelCredential.Text = "GUEST";

        }

        //MENU OPERATIONS
        private void MoveSlideBar(Control c)
        {
            panelSideBar.Top = c.Top;
            panelSideBar.Left = 0;
            panelSideBar.Height = c.Height;
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MoveSlideBar(panelDashboard);

            if (dashboardForm == null)
            {
                dashboardForm = new();
                dashboardForm.FormClosed += DashboardForm_FormClosed;
                dashboardForm.MdiParent = this;
                dashboardForm.Dock = DockStyle.Fill;
                dashboardForm.Show();
            }
            else
                dashboardForm.Activate();
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboardForm = null;
        }

        private void buttonDataGrid_Click(object sender, EventArgs e)
        {
            MoveSlideBar(panelDataGrid);

            if (dataGridForm == null)
            {
                dataGridForm = new(projectManager, departmentManager, managementManager, categoryManager, departmentCapacityManager, projectCapacityManager, userManager, this);
                dataGridForm.FormClosed += DataGridForm_FormClosed;
                dataGridForm.MdiParent = this;
                dataGridForm.Dock = DockStyle.Fill;
                dataGridForm.Show();
            }
            else
            {
                dataGridForm.Activate();
            }
        }

        private void DataGridForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridForm = null;
        }

        public void ChartGenerateAndActivate(object sender, EventArgs e)
        {

            MoveSlideBar(panelChart);

            if (chartForm == null)
            {
                ChartRequest chartRequest = new();

                chartForm = new(dataGridForm, colorCodeManager, colorPaletteManager);
                chartForm.FormClosed += ChartForm_FormClosed;
                chartForm.MdiParent = this;
                chartForm.Dock = DockStyle.Fill;
                chartForm.Show();
            }
            else
                chartForm.Activate();

            chartForm.buttonUpdate_Click(sender, e);
        }

        private void buttonChart_Click(object sender, EventArgs e)
        {
            MoveSlideBar(panelChart);

            if (chartForm == null)
            {
                ChartRequest chartRequest = new();

                chartForm = new(dataGridForm, colorCodeManager, colorPaletteManager);
                chartForm.FormClosed += ChartForm_FormClosed;
                chartForm.MdiParent = this;
                chartForm.Dock = DockStyle.Fill;
                chartForm.Show();
            }
            else
                chartForm.Activate();
        }

        private void ChartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            chartForm = null;
        }


        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            MoveSlideBar(panelAdmin);

            if (adminForm == null)
            {
                adminForm = new(this, managementManager, departmentManager, categoryManager, projectManager, userManager);
                adminForm.FormClosed += AdminForm_FormClosed;
                adminForm.MdiParent = this;
                adminForm.Dock = DockStyle.Fill;
                adminForm.Show();
            }
            else
                adminForm.Activate();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            adminForm = null;
        }

    }
}