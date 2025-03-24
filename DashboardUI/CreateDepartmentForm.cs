using Business.Concrete;
using Core.Utilities.Results;
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
        //Form window drag to move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        ManagementManager _managementManager;
        DepartmentManager _departmentManager;

        IDataResult<List<Management>> _managementData;
        List<int> _managementIndexes = new();

        public CreateDepartmentForm(ManagementManager managementManager, DepartmentManager departmentManager)
        {
            _managementManager = managementManager;
            _departmentManager = departmentManager;
            InitializeComponent();
        }

        private void CreateDepartmentForm_Load(object sender, EventArgs e)
        {
            //fetch data from database
            _managementData = _managementManager.GetAll();

            #region Management Data
            if (_managementData.Success)
            {
                foreach (var management in _managementData.Data)
                {
                    comboBoxManagement.Items.Add(management.ManagementName);
                    _managementIndexes.Add(management.ManagementId);
                }
            }
            else
            {
                MessageBox.Show(_managementData.Massage, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

        }

        private void CreateDepartmentForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textBoxDepartment.Text != "" && comboBoxManagement.SelectedIndex > -1)
            {
                Department departmentToCreate = new();
                departmentToCreate.DepartmentName = textBoxDepartment.Text;
                departmentToCreate.ManagementId = _managementIndexes[comboBoxManagement.SelectedIndex];

                var departmentOperation = _departmentManager.Add(departmentToCreate);
                if (departmentOperation.Success)
                {
                    MessageBox.Show(departmentOperation.Massage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show(departmentOperation.Massage, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Please fill empty selections!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
