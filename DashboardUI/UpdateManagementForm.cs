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
    public partial class UpdateManagementForm : Form
    {
        ManagementManager managementManager;
        string tableValue;

        public UpdateManagementForm(ManagementManager manager, string value)
        {
            tableValue = value;
            managementManager = manager;
            InitializeComponent();
        }
        
        private void UpdateManagementForm_Load(object sender, EventArgs e)
        {
            textBoxManagement.Text = tableValue;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Management managementToUpdate = managementManager.GetByName(tableValue).Data;
            managementToUpdate.ManagementName = textBoxManagement.Text;
            managementManager.Update(managementToUpdate);
            Debug.Print("management updated");
        }
    }
}
