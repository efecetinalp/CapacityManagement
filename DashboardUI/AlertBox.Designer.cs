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
            pictureAlertBox = new PictureBox();
            txtAlertBox = new Label();
            timerAnimation = new System.Windows.Forms.Timer(components);
            AlertDuration = new Panel();
            lblCloseIcon = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureAlertBox).BeginInit();
            SuspendLayout();
            // 
            // pictureAlertBox
            // 
            pictureAlertBox.Location = new Point(12, 6);
            pictureAlertBox.Name = "pictureAlertBox";
            pictureAlertBox.Size = new Size(25, 25);
            pictureAlertBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureAlertBox.TabIndex = 0;
            pictureAlertBox.TabStop = false;
            pictureAlertBox.Click += pictureAlertBox_Click;
            // 
            // txtAlertBox
            // 
            txtAlertBox.AutoSize = true;
            txtAlertBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtAlertBox.Location = new Point(43, 12);
            txtAlertBox.Name = "txtAlertBox";
            txtAlertBox.Size = new Size(114, 15);
            txtAlertBox.TabIndex = 1;
            txtAlertBox.Text = "Test Text Template";
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
            AlertDuration.Location = new Point(0, 37);
            AlertDuration.Name = "AlertDuration";
            AlertDuration.Size = new Size(350, 10);
            AlertDuration.TabIndex = 2;
            // 
            // lblCloseIcon
            // 
            lblCloseIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCloseIcon.AutoSize = true;
            lblCloseIcon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCloseIcon.Location = new Point(332, 2);
            lblCloseIcon.Name = "lblCloseIcon";
            lblCloseIcon.Size = new Size(14, 15);
            lblCloseIcon.TabIndex = 3;
            lblCloseIcon.Text = "x";
            lblCloseIcon.TextAlign = ContentAlignment.MiddleCenter;
            lblCloseIcon.Click += lblCloseIcon_Click;
            // 
            // AlertBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 43);
            Controls.Add(lblCloseIcon);
            Controls.Add(AlertDuration);
            Controls.Add(txtAlertBox);
            Controls.Add(pictureAlertBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlertBox";
            Text = "AlertBox";
            TopMost = true;
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
        private Label lblCloseIcon;
    }
}