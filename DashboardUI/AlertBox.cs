using DashboardUI.Properties;
using EntityFrameworkCore.Jet.Data.Properties;
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
    public partial class AlertBox : Form
    {
        public int _xPos, _yPos;
        private Form _form;

        public AlertBox(Form form)
        {
            _form = form;
            InitializeComponent();
        }

        private void AlertBox_Load(object sender, EventArgs e)
        {
            _xPos = _form.Left + 15;
            _yPos = _form.Bottom - 15;

            DialogAction();
        }

        private void DialogAction()
        {
            //for the first initialize
            this.Left = _xPos;
            this.Top = _yPos - this.Height;

            AlertDuration.Width = 0;

            for (int i = 0; i < this.Width; i++)
            {
                timerAnimation.Start();
            }
        }

        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            AlertDuration.Width = AlertDuration.Width + 2;
            if (AlertDuration.Width >= this.Width)
            {
                this.Hide();
            }
        }

        private void HideImages()
        {
            imgError.Visible = false;
            imgSuccess.Visible = false;
            imgWarning.Visible = false;
        }

        public void SuccessAlert(string alertText)
        {
            HideImages();
            txtAlertBox.Text = alertText;
            this.Left = _xPos;
            this.Top = _yPos - this.Height;
            AlertDuration.Width = 0;
            this.BackColor = Color.LightGreen;
            txtAlertBox.ForeColor = Color.DarkGreen;
            lblCloseIcon.ForeColor = Color.DarkGreen;
            AlertDuration.BackColor = Color.DarkGreen;
            txtAlertBox.Left = (this.Width / 2) - (txtAlertBox.Width /2) + 8;
            imgSuccess.Left = txtAlertBox.Left - imgSuccess.Width - 2;
            imgSuccess.Visible = true;
            this.Show();
        }

        public void ErrorAlert(string alertText)
        {
            HideImages();
            txtAlertBox.Text = alertText;
            this.Left = _xPos;
            this.Top = _yPos - this.Height;
            AlertDuration.Width = 0;
            this.BackColor = Color.LightPink;
            txtAlertBox.ForeColor = Color.DarkRed;
            lblCloseIcon.ForeColor = Color.DarkRed;
            AlertDuration.BackColor = Color.DarkRed;
            txtAlertBox.Left = (this.Width / 2) - (txtAlertBox.Width / 2) + 8;
            imgError.Left = txtAlertBox.Left - imgError.Width - 2;
            imgError.Visible = true;
            this.Show();
        }

        public void WarningAlert(string alertText)
        {
            HideImages();
            txtAlertBox.Text = alertText;
            this.Left = _xPos;
            this.Top = _yPos - this.Height;
            AlertDuration.Width = 0;
            this.BackColor = Color.LightGoldenrodYellow;
            txtAlertBox.ForeColor = Color.DarkOrange;
            lblCloseIcon.ForeColor = Color.DarkOrange;
            AlertDuration.BackColor = Color.DarkOrange;
            txtAlertBox.Left = (this.Width / 2) - (txtAlertBox.Width / 2) + 8;
            imgWarning.Left = txtAlertBox.Left - imgWarning.Width - 2;
            imgWarning.Visible = true;
            this.Show();
        }

        private void lblCloseIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtAlertBox_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AlertBox_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
