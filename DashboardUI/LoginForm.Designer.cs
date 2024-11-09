namespace DashboardUI
{
    partial class LoginForm
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
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            labelUserName = new Label();
            labelPassword = new Label();
            buttonLogin = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // textBoxUserName
            // 
            textBoxUserName.BackColor = Color.FromArgb(46, 52, 63);
            textBoxUserName.BorderStyle = BorderStyle.FixedSingle;
            textBoxUserName.ForeColor = SystemColors.Window;
            textBoxUserName.Location = new Point(41, 52);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(175, 23);
            textBoxUserName.TabIndex = 0;
            textBoxUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(46, 52, 63);
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.ForeColor = SystemColors.Window;
            textBoxPassword.Location = new Point(41, 110);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(175, 23);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelUserName.ForeColor = SystemColors.Window;
            labelUserName.Location = new Point(41, 32);
            labelUserName.Margin = new Padding(2, 0, 2, 0);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(67, 15);
            labelUserName.TabIndex = 28;
            labelUserName.Text = "User Name";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelPassword.ForeColor = SystemColors.Window;
            labelPassword.Location = new Point(41, 90);
            labelPassword.Margin = new Padding(2, 0, 2, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(59, 15);
            labelPassword.TabIndex = 29;
            labelPassword.Text = "Password";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(58, 154, 193);
            buttonLogin.FlatAppearance.BorderColor = Color.FromArgb(58, 154, 193);
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.ForeColor = SystemColors.ButtonHighlight;
            buttonLogin.Location = new Point(41, 170);
            buttonLogin.Margin = new Padding(2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(88, 29);
            buttonLogin.TabIndex = 30;
            buttonLogin.Text = "Log In";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Silver;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.ForeColor = SystemColors.ActiveCaptionText;
            buttonCancel.Location = new Point(147, 170);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(69, 29);
            buttonCancel.TabIndex = 31;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 52, 63);
            ClientSize = new Size(266, 227);
            Controls.Add(buttonCancel);
            Controls.Add(buttonLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelUserName);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private Label labelUserName;
        private Label labelPassword;
        private Button buttonLogin;
        private Button buttonCancel;
    }
}