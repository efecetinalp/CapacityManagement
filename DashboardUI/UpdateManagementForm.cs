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
    public partial class UpdateManagementForm : Form
    {
        //form window drag to move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        ManagementManager _managementManager;
        IDataResult<Management> _managementData;
        int _managementIndex;

        public UpdateManagementForm(ManagementManager managementManager, int index)
        {
            _managementIndex = index;
            _managementManager = managementManager;

            InitializeComponent();
            new DropShadow().ApplyShadows(this);

        }

        private void UpdateManagementForm_Load(object sender, EventArgs e)
        {
            _managementData = _managementManager.GetById(_managementIndex);

            if (_managementData.Success)
            {
                textBoxManagement.Text = _managementData.Data.ManagementName;
            }
            else
                MessageBox.Show(_managementData.Massage, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UpdateManagementForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxManagement.Text != "")
            {
                Management managementToUpdate = _managementData.Data;
                managementToUpdate.ManagementName = textBoxManagement.Text;

                var managementOperation = _managementManager.Update(managementToUpdate);

                if (managementOperation.Success)
                {
                    MessageBox.Show(managementOperation.Massage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show(managementOperation.Massage, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please fill empty selections!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
