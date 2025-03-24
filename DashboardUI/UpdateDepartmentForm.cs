using Business.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DashboardUI
{
    public partial class UpdateDepartmentForm : Form
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
        IDataResult<DepartmentDetailDto> _departmentData;
        IDataResult<List<Management>> _managementData;

        List<int> _managementIndex = new();
        int _departmentIndex;

        public UpdateDepartmentForm(ManagementManager managementManager, DepartmentManager departmentManager, int index)
        {
            _managementManager = managementManager;
            _departmentManager = departmentManager;
            _departmentIndex = index;

            InitializeComponent();
        }

        private void UpdateDepartmentForm_Load(object sender, EventArgs e)
        {
            //fetch data from database
            _managementData = _managementManager.GetAll();
            _departmentData = _departmentManager.GetDepartmentDetail(_departmentIndex);

            #region Department Data
            if (!_departmentData.Success)
            {
                MessageBox.Show(_departmentData.Massage, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            #region Management Data
            if (_managementData.Success)
            {
                foreach (var management in _managementData.Data)
                {
                    comboBoxManagement.Items.Add(management.ManagementName);
                    _managementIndex.Add(management.ManagementId);
                }
            }
            else
            {
                MessageBox.Show(_managementData.Massage, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion


            // update data in form window
            textBoxDepartment.Text = _departmentData.Data.DepartmentName;
            comboBoxManagement.SelectedIndex = comboBoxManagement.Items.IndexOf(_departmentData.Data.ManagementName);
        }

        private void UpdateDepartmentForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxDepartment.Text != "" && comboBoxManagement.SelectedIndex > -1)
            {
                var departmentData = _departmentManager.GetById(_departmentIndex);

                if (departmentData.Success)
                {
                    Department departmentToUpdate = departmentData.Data;
                    departmentToUpdate.DepartmentName = textBoxDepartment.Text;
                    departmentToUpdate.ManagementId = _managementIndex[comboBoxManagement.SelectedIndex];

                    var departmentOperation = _departmentManager.Update(departmentToUpdate);
                    if (departmentOperation.Success)
                    {
                        MessageBox.Show(departmentOperation.Massage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show(departmentOperation.Massage, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(departmentData.Massage, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
