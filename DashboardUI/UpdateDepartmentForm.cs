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
    public partial class UpdateDepartmentForm : Form
    {
        ManagementManager _managementManager;
        DepartmentManager _departmentManager;
        string _departmentName;

        public UpdateDepartmentForm(ManagementManager managementManager, DepartmentManager departmentManager, string departmentName)
        {
            _managementManager = managementManager;
            _departmentManager = departmentManager;
            _departmentName = departmentName;

            InitializeComponent();
        }

        private void UpdateDepartmentForm_Load(object sender, EventArgs e)
        {
            var managements = _managementManager.GetAll();

            foreach (var management in managements.Data)
            {
                comboBoxManagement.Items.Add(management.ManagementName);
            }

            textBoxDepartment.Text = _departmentName;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxManagement.SelectedItem.ToString() != "")
            {
                Department departmentToUpdate = _departmentManager.GetByName(_departmentName).Data;

                departmentToUpdate.DepartmentName = textBoxDepartment.Text;
                departmentToUpdate.ManagementId = _managementManager.GetByName(comboBoxManagement.SelectedItem.ToString()).Data.ManagementId;
                _departmentManager.Update(departmentToUpdate);
                Debug.Print("department updated");
            }
            else
                MessageBox.Show("Management cannot null!");

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
