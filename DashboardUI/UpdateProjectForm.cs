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
    public partial class UpdateProjectForm : Form
    {
        ManagementManager _managementManager;
        DepartmentManager _departmentManager;
        CategoryManager _categoryManager;
        ProjectManager _projectManager;
        string _projectName;

        public UpdateProjectForm(ManagementManager managementManager, DepartmentManager departmentManager, CategoryManager categoryManager, ProjectManager projectManager, string projectName)
        {
            _managementManager = managementManager;
            _departmentManager = departmentManager;
            _categoryManager = categoryManager;
            _projectManager = projectManager;
            _projectName = projectName;
            InitializeComponent();
        }

        private void UpdateProjectForm_Load(object sender, EventArgs e)
        {
            textBoxProject.Text = _projectName;

            var managementResult = _managementManager.GetAll();
            var categoryResult = _categoryManager.GetAll();

            foreach (var management in managementResult.Data)
            {
                comboBoxManagement.Items.Add(management.ManagementName);
            }

            foreach (var category in categoryResult.Data)
            {
                comboBoxCategory.Items.Add(category.CategoryName);
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedItem.ToString() != "" && comboBoxDepartment.SelectedItem.ToString() != "" && comboBoxManagement.SelectedItem.ToString() != "")
            {
                Project projectToUpdate = _projectManager.GetByName(_projectName).Data;
                projectToUpdate.ProjectName = textBoxProject.Text;
                projectToUpdate.ManagementId = _managementManager.GetByName(comboBoxManagement.SelectedItem.ToString()).Data.ManagementId;
                projectToUpdate.DepartmentId = _departmentManager.GetByName(comboBoxDepartment.SelectedItem.ToString()).Data.DepartmentId;
                projectToUpdate.CategoryId = _categoryManager.GetByName(comboBoxCategory.SelectedItem.ToString()).Data.CategoryId;
                _projectManager.Update(projectToUpdate);
                Debug.Print("Project updated");
            }
            else
            {
                MessageBox.Show("fill empty selections");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            var departmentResult = _departmentManager.GetAllByManagementId(_managementManager.GetByName(comboBoxManagement.SelectedItem.ToString()).Data.ManagementId);

            foreach (var department in departmentResult.Data)
            {
                comboBoxDepartment.Items.Add(department.DepartmentName);
            }
        }
    }
}
