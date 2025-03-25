namespace DashboardUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertBox));
            imgSuccess = new PictureBox();
            txtAlertBox = new Label();
            timerAnimation = new System.Windows.Forms.Timer(components);
            AlertDuration = new Panel();
            lblCloseIcon = new Label();
            imgWarning = new PictureBox();
            imgError = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgSuccess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgWarning).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgError).BeginInit();
            SuspendLayout();
            // 
            // imgSuccess
            // 
            imgSuccess.Image = (Image)resources.GetObject("imgSuccess.Image");
            imgSuccess.Location = new Point(5, 13);
            imgSuccess.Name = "imgSuccess";
            imgSuccess.Size = new Size(16, 16);
            imgSuccess.SizeMode = PictureBoxSizeMode.StretchImage;
            imgSuccess.TabIndex = 0;
            imgSuccess.TabStop = false;
            imgSuccess.Visible = false;
            // 
            // txtAlertBox
            // 
            txtAlertBox.AutoSize = true;
            txtAlertBox.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtAlertBox.Location = new Point(69, 15);
            txtAlertBox.Name = "txtAlertBox";
            txtAlertBox.Size = new Size(67, 13);
            txtAlertBox.TabIndex = 1;
            txtAlertBox.Text = "Notification";
            txtAlertBox.TextAlign = ContentAlignment.MiddleCenter;
            txtAlertBox.Click += txtAlertBox_Click;
            // 
            // timerAnimation
            // 
            timerAnimation.Interval = 10;
            timerAnimation.Tick += timerAnimation_Tick;
            // 
            // AlertDuration
            // 
            AlertDuration.BackColor = SystemColors.ActiveCaptionText;
            AlertDuration.Location = new Point(0, 41);
            AlertDuration.Name = "AlertDuration";
            AlertDuration.Size = new Size(206, 2);
            AlertDuration.TabIndex = 2;
            // 
            // lblCloseIcon
            // 
            lblCloseIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCloseIcon.AutoSize = true;
            lblCloseIcon.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCloseIcon.Location = new Point(192, -2);
            lblCloseIcon.Name = "lblCloseIcon";
            lblCloseIcon.Size = new Size(13, 15);
            lblCloseIcon.TabIndex = 3;
            lblCloseIcon.Text = "x";
            lblCloseIcon.TextAlign = ContentAlignment.MiddleCenter;
            lblCloseIcon.Click += lblCloseIcon_Click;
            // 
            // imgWarning
            // 
            imgWarning.Image = (Image)resources.GetObject("imgWarning.Image");
            imgWarning.Location = new Point(5, 13);
            imgWarning.Name = "imgWarning";
            imgWarning.Size = new Size(16, 16);
            imgWarning.SizeMode = PictureBoxSizeMode.StretchImage;
            imgWarning.TabIndex = 4;
            imgWarning.TabStop = false;
            imgWarning.Visible = false;
            // 
            // imgError
            // 
            imgError.Image = (Image)resources.GetObject("imgError.Image");
            imgError.Location = new Point(5, 13);
            imgError.Name = "imgError";
            imgError.Size = new Size(16, 16);
            imgError.SizeMode = PictureBoxSizeMode.StretchImage;
            imgError.TabIndex = 5;
            imgError.TabStop = false;
            imgError.Visible = false;
            // 
            // AlertBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(205, 43);
            Controls.Add(imgError);
            Controls.Add(imgWarning);
            Controls.Add(lblCloseIcon);
            Controls.Add(AlertDuration);
            Controls.Add(txtAlertBox);
            Controls.Add(imgSuccess);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlertBox";
            Text = "AlertBox";
            TopMost = true;
            Load += AlertBox_Load;
            Click += AlertBox_Click;
            ((System.ComponentModel.ISupportInitialize)imgSuccess).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgWarning).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgSuccess;
        private Label txtAlertBox;
        private System.Windows.Forms.Timer timerAnimation;
        private Panel AlertDuration;
        private Label lblCloseIcon;
        private PictureBox imgWarning;
        private PictureBox imgError;
    }
}