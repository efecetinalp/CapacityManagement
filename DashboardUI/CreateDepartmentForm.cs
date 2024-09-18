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
    public partial class CreateDepartmentForm : Form
    {
        ManagementManager _managementManager;
        DepartmentManager _departmentManager;

        public CreateDepartmentForm(ManagementManager managementManager, DepartmentManager departmentManager)
        {
            _managementManager = managementManager;
            _departmentManager = departmentManager;
            InitializeComponent();
        }

        private void CreateDepartmentForm_Load(object sender, EventArgs e)
        {
            var managementResult = _managementManager.GetAll();

            foreach (var management in managementResult.Data)
            {
                comboBoxManagement.Items.Add(management.ManagementName);
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (comboBoxManagement.SelectedItem.ToString() != "")
            {
                Department departmentToCreate = new();
                departmentToCreate.ManagementId = _managementManager.GetByName(comboBoxManagement.SelectedItem.ToString()).Data.ManagementId;
                departmentToCreate.DepartmentName = textBoxDepartment.Text;
                _departmentManager.Add(departmentToCreate);
                Debug.Print("Department created");
            }
            else
            {
                MessageBox.Show("Management cannot be null");
            }
        }
    }
}
