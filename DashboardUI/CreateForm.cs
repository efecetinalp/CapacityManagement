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
    public partial class CreateForm : Form
    {
        CreateProjectForm createProjectForm;
        CreateDepartmentForm createDepartmentForm;
        CreateManagementForm createManagementForm;
        CreateCategoryForm createCategoryForm;

        ManagementManager _managementManager;
        DepartmentManager _departmentManager;
        CategoryManager _categoryManager;
        ProjectManager _projectManager;

        public CreateForm(ManagementManager managementManager, DepartmentManager departmentManager, CategoryManager categoryManager, ProjectManager projectManager)
        {
            _managementManager = managementManager;
            _departmentManager = departmentManager;
            _categoryManager = categoryManager;
            _projectManager = projectManager;

            InitializeComponent();
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            //start with project form
            createProjectForm = new(_managementManager, _departmentManager, _categoryManager, _projectManager);
            createProjectForm.FormClosed += CreateProjectForm_FormClosed;
            createProjectForm.MdiParent = this;
            createProjectForm.Dock = DockStyle.Fill;
            createProjectForm.Show();
        }

        private void buttonProject_Click(object sender, EventArgs e)
        {
            if (createProjectForm == null)
            {
                createProjectForm = new(_managementManager, _departmentManager, _categoryManager, _projectManager);
                createProjectForm.FormClosed += CreateProjectForm_FormClosed;
                createProjectForm.MdiParent = this;
                createProjectForm.Dock = DockStyle.Fill;
                createProjectForm.Show();
            }
            else
                createProjectForm.Activate();
        }

        private void CreateProjectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            createProjectForm = null;
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            if (createCategoryForm == null)
            {
                createCategoryForm = new(_categoryManager);
                createCategoryForm.FormClosed += CreateProjectForm_FormClosed;
                createCategoryForm.MdiParent = this;
                createCategoryForm.Dock = DockStyle.Fill;
                createCategoryForm.Show();
            }
            else
                createCategoryForm.Activate();
        }

        private void CreateCategoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            createCategoryForm = null;
        }

        private void buttonDepartment_Click(object sender, EventArgs e)
        {
            if (createDepartmentForm == null)
            {
                createDepartmentForm = new(_managementManager, _departmentManager);
                createDepartmentForm.FormClosed += CreateProjectForm_FormClosed;
                createDepartmentForm.MdiParent = this;
                createDepartmentForm.Dock = DockStyle.Fill;
                createDepartmentForm.Show();
            }
            else
                createDepartmentForm.Activate();
        }

        private void CreateDepartmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            createDepartmentForm = null;
        }

        private void buttonManagement_Click(object sender, EventArgs e)
        {
            if (createManagementForm == null)
            {
                createManagementForm = new(_managementManager);
                createManagementForm.FormClosed += CreateProjectForm_FormClosed;
                createManagementForm.MdiParent = this;
                createManagementForm.Dock = DockStyle.Fill;
                createManagementForm.Show();
            }
            else
                createManagementForm.Activate();
        }

        private void CreateManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            createManagementForm = null;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
