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
    public partial class DeleteDepartmentForm : Form
    {
        private Department _departmentToDelete;
        private DepartmentManager _departmentManager;

        public DeleteDepartmentForm(DepartmentManager departmentManager, Department department)
        {
            _departmentManager = departmentManager;
            _departmentToDelete = department;
            InitializeComponent();
        }
        private void DeleteDepartmentForm_Load(object sender, EventArgs e)
        {
            labelDelete.Text = _departmentToDelete.DepartmentName + " is going to delete permanently!" + System.Environment.NewLine + "Type: " + _departmentToDelete.DepartmentName + " for approval";
            textBoxDelete.PlaceholderText = _departmentToDelete.DepartmentName;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxDelete.Text == textBoxDelete.PlaceholderText)
            {
                _departmentManager.Delete(_departmentToDelete);
                Debug.Print("delete test worked!");
            }
            else
            {
                Debug.Print("wrong input");
            }

        }

        
    }
}
