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
    public partial class DeleteManagementForm : Form
    {
        private Management _managementToDelete;
        private ManagementManager _managementManager;

        public DeleteManagementForm(ManagementManager managementManager, Management management)
        {
            _managementManager = managementManager;
            _managementToDelete = management;
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            labelDelete.Text = _managementToDelete.ManagementName + " is going to delete permanently!" + System.Environment.NewLine + "Type: " + _managementToDelete.ManagementName + " for approval";
            textBoxDelete.PlaceholderText = _managementToDelete.ManagementName;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxDelete.Text == textBoxDelete.PlaceholderText)
            {
                _managementManager.Delete(_managementToDelete);
                Debug.Print("delete test worked!");
            }
            else
            {
                Debug.Print("wrong input");
            }

        }
    }
}
