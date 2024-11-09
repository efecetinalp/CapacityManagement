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
            textBoxUserName.Location = new Point(41, 44);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(326, 23);
            textBoxUserName.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(41, 102);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(326, 23);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelUserName.Location = new Point(41, 24);
            labelUserName.Margin = new Padding(2, 0, 2, 0);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(73, 17);
            labelUserName.TabIndex = 28;
            labelUserName.Text = "User Name";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelPassword.Location = new Point(41, 82);
            labelPassword.Margin = new Padding(2, 0, 2, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(62, 17);
            labelPassword.TabIndex = 29;
            labelPassword.Text = "Password";
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonLogin.Location = new Point(41, 148);
            buttonLogin.Margin = new Padding(2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(143, 29);
            buttonLogin.TabIndex = 30;
            buttonLogin.Text = "Log In";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonCancel.Location = new Point(224, 148);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(143, 29);
            buttonCancel.TabIndex = 31;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 202);
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