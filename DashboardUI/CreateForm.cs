using Business.Concrete;
using Entities.Concrete;
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
            for (int i = 0; i < _managementManager.GetAll().Data.Count; i++)
            {
                comboBoxManagement.Items.Add(_managementManager.GetAll().Data[i].ManagementName);
            }

            for (int i = 0; i < _categoryManager.GetAll().Data.Count; i++)
            {
                comboBoxCategory.Items.Add(_categoryManager.GetAll().Data[i].CategoryName);
            }

        }

        private void comboBoxManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDepartment.Items.Clear();

            for (int i = 0; i < _departmentManager.GetAllByManagementId(comboBoxManagement.SelectedIndex + 1).Data.Count; i++)
            {
                comboBoxDepartment.Items.Add(_departmentManager.GetAllByManagementId(comboBoxManagement.SelectedIndex + 1).Data[i].DepartmentName);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            //create Project
            Project newProject = new();

            newProject.ManagementId = comboBoxManagement.SelectedIndex + 1;
            newProject.DepartmentId = _departmentManager.GetByDepartmentName(comboBoxDepartment.Text).Data.DepartmentId;
            newProject.CategoryId = comboBoxCategory.SelectedIndex + 1;
            newProject.ProjectName = textBoxProject.Text;

            if (_projectManager.Add(newProject).Success)
            {
                MessageBox.Show("Created");
            }

            this.Close();
        }

        private void buttonCreate2_Click(object sender, EventArgs e)
        {
            //create Project
            Department departmantToCreate = new();

            departmantToCreate.ManagementId = comboBoxManagement.SelectedIndex + 1;
            departmantToCreate.DepartmentName = textBoxDepartment.Text;

            if (_departmentManager.Add(departmantToCreate).Success)
            {
                MessageBox.Show("Created");
            }

            this.Close();
        }

        private void buttonCreate3_Click(object sender, EventArgs e)
        {
            //create Project
            Management managementToCreate = new();

            managementToCreate.ManagementName = textBoxManagement.Text;

            if (_managementManager.Add(managementToCreate).Success)
            {
                MessageBox.Show("Created");
            }

            this.Close();
        }
    }
}
