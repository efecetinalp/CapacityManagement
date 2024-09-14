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

        //database manager referances
        ManagementManager managementManager;
        DepartmentManager departmentManager;
        CategoryManager categoryManager;
        ProjectManager projectManager;
        ProjectCapacityManager projectCapacityManager;
        DepartmentCapacityManager departmentCapacityManager;

        public Dashboard()
        {
            managementManager = new ManagementManager(new EfManagementDal());
            departmentManager = new DepartmentManager(new EfDepartmentDal());
            categoryManager = new CategoryManager(new EfCategoryDal());
            projectManager = new ProjectManager(new EfProjectDal());
            projectCapacityManager = new ProjectCapacityManager(new EfProjectCapacityDal());
            departmentCapacityManager = new DepartmentCapacityManager(new EfDepartmentCapacityDal());

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Delete later
            //Start with datagrid form
            MoveSlideBar(panelDataGrid);
            dataGridForm = new(projectManager, departmentManager, managementManager,categoryManager, departmentCapacityManager, projectCapacityManager);
            dataGridForm.FormClosed += DataGridForm_FormClosed;
            dataGridForm.MdiParent = this;
            dataGridForm.Dock = DockStyle.Fill;
            dataGridForm.Show();
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
        }

        private void buttonDataGrid_Click(object sender, EventArgs e)
        {
            MoveSlideBar(panelDataGrid);

            if (dataGridForm == null)
            {
                dataGridForm = new(projectManager, departmentManager, managementManager,categoryManager, departmentCapacityManager, projectCapacityManager);
                dataGridForm.FormClosed += DataGridForm_FormClosed;
                dataGridForm.MdiParent = this;
                dataGridForm.Dock = DockStyle.Fill;
                dataGridForm.Show();
            }
            else
                dataGridForm.Activate();
        }

        private void DataGridForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridForm = null;
        }

        private void buttonChart_Click(object sender, EventArgs e)
        {
            MoveSlideBar(panelChart);

        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            MoveSlideBar(panelAdmin);

            LoginForm loginForm = new();
            loginForm.Show();

        }

        private void buttonAdminCreate_Click(object sender, EventArgs e)
        {
            MoveSlideBar(panelAdminCreate);

            CreateForm createForm = new CreateForm(managementManager, departmentManager, categoryManager, projectManager);
            createForm.Show();
        }

        private void buttonAdminUpdate_Click(object sender, EventArgs e)
        {
            MoveSlideBar(panelAdminUpdate);

            UpdateForm updateForm = new UpdateForm(managementManager, departmentManager, categoryManager, projectManager);
            updateForm.Show();
        }

        private void buttonAdminDelete_Click(object sender, EventArgs e)
        {
            MoveSlideBar(panelAdminDelete);

            DeleteForm deleteForm = new DeleteForm(managementManager, departmentManager, categoryManager, projectManager);
            deleteForm.Show();
        }
    }
}