using DashboardUI.Properties;
using EntityFrameworkCore.Jet.Data.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardUI
{
    public partial class AlertBox : Form
    {
        // public Color AlertBackColor { get; set; }
        // public Color AlertTextColor { get; set; }
        // public Image AlertImage { get; set; }
        // public string AlertText { get; set; }
        public int _xPos, _yPos;


        public AlertBox(int xPos, int yPos)
        {
            _xPos = xPos;
            _yPos = yPos;
            InitializeComponent();
        }

        private void PositionAlert()
        {
            this.Location = new Point(_xPos, _yPos);
        }

        private void AlertBox_Load(object sender, EventArgs e)
        {
            DialogAction();
        }

        private void DialogAction()
        {
            AlertDuration.Width = 0;

            PositionAlert();
            for (int i = 0; i < 250; i++)
            {
                timerAnimation.Start();
            }
        }

        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            AlertDuration.Width = AlertDuration.Width + 2;
            if (AlertDuration.Width >= 250)
            {
                this.Close();
            }
        }

        private void AlertBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SuccessAlert(string alertText)
        {
            AlertDuration.Width = 0;
            txtAlertBox.Text = alertText;
            this.BackColor = Color.LightGreen;
            txtAlertBox.ForeColor = Color.SeaGreen;
            AlertDuration.BackColor = Color.SeaGreen;
            pictureAlertBox.Image = Properties.Resources.success_alert;
            this.Show();
        }

        public void ErrorAlert(string alertText)
        {
            AlertDuration.Width = 0;
            txtAlertBox.Text = alertText;
            this.BackColor = Color.LightPink;
            txtAlertBox.ForeColor = Color.DarkRed;
            AlertDuration.BackColor = Color.DarkRed;
            pictureAlertBox.Image = Properties.Resources.error_alert;
            this.Show();
        }

        public void WarningAlert(string alertText)
        {
            AlertDuration.Width = 0;
            txtAlertBox.Text = alertText;
            this.BackColor = Color.LightGoldenrodYellow;
            txtAlertBox.ForeColor = Color.Goldenrod;
            AlertDuration.BackColor = Color.Goldenrod;
            pictureAlertBox.Image = Properties.Resources.warning_alert;
            this.Show();
        }

        public void InformationAlert(string alertText)
        {
            AlertDuration.Width = 0;
            txtAlertBox.Text = alertText;
            this.BackColor = Color.LightSteelBlue;
            txtAlertBox.ForeColor = Color.DodgerBlue;
            AlertDuration.BackColor = Color.DodgerBlue;
            pictureAlertBox.Image = Properties.Resources.info_alert;
            this.Show();
        }
    }
}
