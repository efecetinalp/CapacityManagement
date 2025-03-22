namespace DashboardUI
{
    partial class UpdateUserForm
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
            label7 = new Label();
            label6 = new Label();
            buttonCancel = new Button();
            buttonUpdate = new Button();
            textBoxUserName = new TextBox();
            checkBoxAuthor = new CheckBox();
            checkBoxAdmin = new CheckBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(82, 17);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 34;
            label7.Text = "EDIT USER";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(21, 45);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(56, 12);
            label6.TabIndex = 33;
            label6.Text = "User Name";
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(133, 151);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(76, 25);
            buttonCancel.TabIndex = 32;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(58, 154, 193);
            buttonUpdate.FlatAppearance.BorderColor = Color.FromArgb(58, 154, 193);
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUpdate.ForeColor = SystemColors.ButtonHighlight;
            buttonUpdate.Location = new Point(21, 151);
            buttonUpdate.Margin = new Padding(2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(76, 25);
            buttonUpdate.TabIndex = 31;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUserName.Location = new Point(21, 59);
            textBoxUserName.Margin = new Padding(2);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(188, 20);
            textBoxUserName.TabIndex = 30;
            // 
            // checkBoxAuthor
            // 
            checkBoxAuthor.AutoSize = true;
            checkBoxAuthor.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAuthor.Location = new Point(21, 93);
            checkBoxAuthor.Name = "checkBoxAuthor";
            checkBoxAuthor.Size = new Size(54, 16);
            checkBoxAuthor.TabIndex = 35;
            checkBoxAuthor.Text = "Author";
            checkBoxAuthor.UseVisualStyleBackColor = true;
            checkBoxAuthor.CheckedChanged += checkBoxAuthor_CheckedChanged;
            // 
            // checkBoxAdmin
            // 
            checkBoxAdmin.AutoSize = true;
            checkBoxAdmin.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAdmin.Location = new Point(22, 115);
            checkBoxAdmin.Name = "checkBoxAdmin";
            checkBoxAdmin.Size = new Size(53, 16);
            checkBoxAdmin.TabIndex = 36;
            checkBoxAdmin.Text = "Admin";
            checkBoxAdmin.UseVisualStyleBackColor = true;
            checkBoxAdmin.CheckedChanged += checkBoxAdmin_CheckedChanged;
            // 
            // UpdateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 201);
            Controls.Add(checkBoxAdmin);
            Controls.Add(checkBoxAuthor);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(buttonCancel);
            Controls.Add(buttonUpdate);
            Controls.Add(textBoxUserName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateUserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UpdateUserForm";
            TopMost = true;
            Load += UpdateUserForm_Load;
            MouseDown += UpdateUserForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Button buttonCancel;
        private Button buttonUpdate;
        private TextBox textBoxUserName;
        private CheckBox checkBoxAuthor;
        private CheckBox checkBoxAdmin;
    }
}