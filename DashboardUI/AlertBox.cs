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
        private int _alertWidth;

        public AlertBox()
        {
            InitializeComponent();
        }

        private void AlertBox_Load(object sender, EventArgs e)
        {
            DialogAction();
        }

        private void DialogAction()
        {
            //for the first initialize
            this.Location = new Point(_xPos - _alertWidth - 20, _yPos - 70);

            AlertDuration.Width = 0;

            for (int i = 0; i < _alertWidth; i++)
            {
                timerAnimation.Start();
            }
        }

        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            AlertDuration.Width = AlertDuration.Width + 2;
            if (AlertDuration.Width >= _alertWidth)
            {
                this.Hide();
            }
        }

        public void SuccessAlert(string alertText, int xPos, int yPos)
        {
            if (this.Visible)
                this.Hide();

            _xPos = xPos;
            _yPos = yPos;
            txtAlertBox.Text = alertText;
            this.Width = txtAlertBox.Width + 70;
            _alertWidth = this.Width;
            this.Location = new Point(_xPos - _alertWidth - 20, _yPos - 70);
            AlertDuration.Width = 0;
            this.BackColor = Color.LightGreen;
            txtAlertBox.ForeColor = Color.SeaGreen;
            lblCloseIcon.ForeColor = Color.SeaGreen;
            AlertDuration.BackColor = Color.SeaGreen;
            pictureAlertBox.Image = Properties.Resources.success_alert;
            this.Show();
        }

        public void ErrorAlert(string alertText, int xPos, int yPos)
        {
            if (this.Visible)
                this.Hide();

            _xPos = xPos;
            _yPos = yPos;
            txtAlertBox.Text = alertText;
            this.Width = txtAlertBox.Width + 70;
            _alertWidth = this.Width;
            this.Location = new Point(_xPos - _alertWidth - 20, _yPos - 70);
            AlertDuration.Width = 0;
            this.BackColor = Color.LightPink;
            txtAlertBox.ForeColor = Color.DarkRed;
            lblCloseIcon.ForeColor = Color.DarkRed;
            AlertDuration.BackColor = Color.DarkRed;
            pictureAlertBox.Image = Properties.Resources.error_alert;
            this.Show();
        }

        public void WarningAlert(string alertText, int xPos, int yPos)
        {
            if (this.Visible)
                this.Hide();

            _xPos = xPos;
            _yPos = yPos;
            txtAlertBox.Text = alertText;
            this.Width = txtAlertBox.Width + 70;
            _alertWidth = this.Width;
            AlertDuration.Width = 0;
            this.Location = new Point(_xPos - _alertWidth - 20, _yPos - 70);
            this.BackColor = Color.LightGoldenrodYellow;
            txtAlertBox.ForeColor = Color.Goldenrod;
            lblCloseIcon.ForeColor = Color.Goldenrod;
            AlertDuration.BackColor = Color.Goldenrod;
            pictureAlertBox.Image = Properties.Resources.warning_alert;
            this.Show();
        }

        public void InformationAlert(string alertText, int xPos, int yPos)
        {
            if (this.Visible)
                this.Hide();

            _xPos = xPos;
            _yPos = yPos;
            txtAlertBox.Text = alertText;
            this.Width = txtAlertBox.Width + 70;
            _alertWidth = this.Width;
            this.Location = new Point(_xPos - _alertWidth - 20, _yPos - 70);
            AlertDuration.Width = 0;
            this.BackColor = Color.LightSteelBlue;
            txtAlertBox.ForeColor = Color.DodgerBlue;
            lblCloseIcon.ForeColor = Color.DodgerBlue;
            AlertDuration.BackColor = Color.DodgerBlue;
            pictureAlertBox.Image = Properties.Resources.info_alert;
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

        private void pictureAlertBox_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AlertBox_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
