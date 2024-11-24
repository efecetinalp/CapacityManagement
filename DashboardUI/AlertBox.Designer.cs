﻿namespace DashboardUI
{
    partial class AlertBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureAlertBox = new PictureBox();
            txtAlertBox = new Label();
            timerAnimation = new System.Windows.Forms.Timer(components);
            AlertDuration = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureAlertBox).BeginInit();
            SuspendLayout();
            // 
            // pictureAlertBox
            // 
            pictureAlertBox.Location = new Point(12, 9);
            pictureAlertBox.Name = "pictureAlertBox";
            pictureAlertBox.Size = new Size(32, 32);
            pictureAlertBox.TabIndex = 0;
            pictureAlertBox.TabStop = false;
            // 
            // txtAlertBox
            // 
            txtAlertBox.AutoSize = true;
            txtAlertBox.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtAlertBox.Location = new Point(55, 17);
            txtAlertBox.Name = "txtAlertBox";
            txtAlertBox.Size = new Size(120, 16);
            txtAlertBox.TabIndex = 1;
            txtAlertBox.Text = "Test Text Template";
            // 
            // timerAnimation
            // 
            timerAnimation.Interval = 10;
            timerAnimation.Tick += timerAnimation_Tick;
            // 
            // AlertDuration
            // 
            AlertDuration.BackColor = SystemColors.ActiveCaptionText;
            AlertDuration.Location = new Point(0, 45);
            AlertDuration.Name = "AlertDuration";
            AlertDuration.Size = new Size(300, 5);
            AlertDuration.TabIndex = 2;
            // 
            // AlertBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 50);
            Controls.Add(AlertDuration);
            Controls.Add(txtAlertBox);
            Controls.Add(pictureAlertBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlertBox";
            Text = "AlertBox";
            Load += AlertBox_Load;
            Click += AlertBox_Click;
            ((System.ComponentModel.ISupportInitialize)pictureAlertBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureAlertBox;
        private Label txtAlertBox;
        private System.Windows.Forms.Timer timerAnimation;
        private Panel AlertDuration;
    }
}