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
    public partial class CreateProjectForm : Form
    {
        ManagementManager _managementManager;
        DepartmentManager _departmentManager;
        CategoryManager _categoryManager;
        ProjectManager _projectManager;

        public CreateProjectForm(ManagementManager managementManager, DepartmentManager departmentManager, CategoryManager categoryManager, ProjectManager projectManager)
        {
            _managementManager = managementManager;
            _departmentManager = departmentManager;
            _categoryManager = categoryManager;
            _projectManager = projectManager;

            InitializeComponent();
        }

        private void CreateProjectForm_Load(object sender, EventArgs e)
        {
            var managementResult = _managementManager.GetAll();
            foreach (var management in managementResult.Data)
            {
                comboBoxManagement.Items.Add(management.ManagementName);
            }

            var categoryResult = _categoryManager.GetAll();
            foreach (var category in categoryResult.Data)
            {
                comboBoxCategory.Items.Add(category.CategoryName);
            }
        }

        private void comboBoxManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            var departmentResult = _departmentManager.GetAllByManagementId(_managementManager.GetByName(comboBoxManagement.SelectedItem.ToString()).Data.ManagementId);

            foreach (var department in departmentResult.Data)
            {
                comboBoxDepartment.Items.Add(department.DepartmentName);
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Project projectToCreate = new();
            projectToCreate.ProjectName = textBoxProject.Text;
            projectToCreate.ManagementId = _managementManager.GetByName(comboBoxManagement.SelectedItem.ToString()).Data.ManagementId;
            projectToCreate.DepartmentId = _departmentManager.GetByName(comboBoxDepartment.SelectedItem.ToString()).Data.DepartmentId;
            projectToCreate.CategoryId = _categoryManager.GetByName(comboBoxCategory.SelectedItem.ToString()).Data.CategoryId;
            _projectManager.Add(projectToCreate);
            Debug.Print("Project created");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
