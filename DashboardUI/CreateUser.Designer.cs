namespace DashboardUI
{
    partial class CreateUser
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
            labelUserName = new Label();
            labelPassword = new Label();
            buttonLogin = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            comboBoxRoles = new ComboBox();
            SuspendLayout();
            // 
            // textBoxUserName
            // 
            textBoxUserName.BackColor = Color.FromArgb(46, 52, 63);
            textBoxUserName.BorderStyle = BorderStyle.FixedSingle;
            textBoxUserName.ForeColor = SystemColors.Window;
            textBoxUserName.Location = new Point(41, 88);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(175, 23);
            textBoxUserName.TabIndex = 0;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelUserName.ForeColor = SystemColors.Window;
            labelUserName.Location = new Point(41, 68);
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
            labelPassword.Location = new Point(41, 129);
            labelPassword.Margin = new Padding(2, 0, 2, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(30, 15);
            labelPassword.TabIndex = 29;
            labelPassword.Text = "Role";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(58, 154, 193);
            buttonLogin.FlatAppearance.BorderColor = Color.FromArgb(58, 154, 193);
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.ForeColor = SystemColors.ButtonHighlight;
            buttonLogin.Location = new Point(41, 209);
            buttonLogin.Margin = new Padding(2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(175, 29);
            buttonLogin.TabIndex = 30;
            buttonLogin.Text = "Create";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Silver;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.ForeColor = SystemColors.ActiveCaptionText;
            buttonCancel.Location = new Point(41, 254);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(175, 29);
            buttonCancel.TabIndex = 31;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(78, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 32;
            label1.Text = "CREATE NEW USER";
            // 
            // comboBoxRoles
            // 
            comboBoxRoles.BackColor = Color.FromArgb(46, 52, 63);
            comboBoxRoles.FlatStyle = FlatStyle.Flat;
            comboBoxRoles.ForeColor = Color.White;
            comboBoxRoles.FormattingEnabled = true;
            comboBoxRoles.Location = new Point(41, 147);
            comboBoxRoles.Name = "comboBoxRoles";
            comboBoxRoles.Size = new Size(175, 23);
            comboBoxRoles.TabIndex = 33;
            // 
            // CreateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 52, 63);
            ClientSize = new Size(266, 316);
            Controls.Add(comboBoxRoles);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelUserName);
            Controls.Add(textBoxUserName);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "CreateUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateUserForm";
            Load += CreateUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUserName;
        private Label labelUserName;
        private Label labelPassword;
        private Button buttonLogin;
        private Button buttonCancel;
        private Label label1;
        private ComboBox comboBoxRoles;
    }
}