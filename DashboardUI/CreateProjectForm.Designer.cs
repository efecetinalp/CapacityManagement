namespace DashboardUI
{
    partial class CreateProjectForm
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
            lblProjectCreate = new Label();
            lblProject = new Label();
            lblCategory = new Label();
            lblDepartment = new Label();
            lblManagement = new Label();
            buttonCreate = new Button();
            textBoxProject = new TextBox();
            comboBoxCategory = new ComboBox();
            comboBoxDepartment = new ComboBox();
            comboBoxManagement = new ComboBox();
            SuspendLayout();
            // 
            // lblProjectCreate
            // 
            lblProjectCreate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblProjectCreate.AutoSize = true;
            lblProjectCreate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblProjectCreate.Location = new Point(140, 50);
            lblProjectCreate.Margin = new Padding(2, 0, 2, 0);
            lblProjectCreate.Name = "lblProjectCreate";
            lblProjectCreate.Size = new Size(68, 19);
            lblProjectCreate.TabIndex = 29;
            lblProjectCreate.Text = "PROJECT";
            lblProjectCreate.TextAlign = ContentAlignment.MiddleCenter;
            lblProjectCreate.Click += lblProjectCreate_Click;
            // 
            // lblProject
            // 
            lblProject.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblProject.AutoSize = true;
            lblProject.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblProject.Location = new Point(39, 243);
            lblProject.Margin = new Padding(2, 0, 2, 0);
            lblProject.Name = "lblProject";
            lblProject.Size = new Size(44, 15);
            lblProject.TabIndex = 28;
            lblProject.Text = "Project";
            // 
            // lblCategory
            // 
            lblCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCategory.Location = new Point(39, 194);
            lblCategory.Margin = new Padding(2, 0, 2, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(57, 15);
            lblCategory.TabIndex = 27;
            lblCategory.Text = "Category";
            // 
            // lblDepartment
            // 
            lblDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDepartment.Location = new Point(39, 144);
            lblDepartment.Margin = new Padding(2, 0, 2, 0);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(73, 15);
            lblDepartment.TabIndex = 26;
            lblDepartment.Text = "Department";
            // 
            // lblManagement
            // 
            lblManagement.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblManagement.AutoSize = true;
            lblManagement.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblManagement.Location = new Point(39, 91);
            lblManagement.Margin = new Padding(2, 0, 2, 0);
            lblManagement.Name = "lblManagement";
            lblManagement.Size = new Size(79, 15);
            lblManagement.TabIndex = 25;
            lblManagement.Text = "Management";
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonCreate.BackColor = Color.FromArgb(58, 154, 193);
            buttonCreate.FlatAppearance.BorderColor = Color.FromArgb(58, 154, 193);
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.ForeColor = SystemColors.ButtonHighlight;
            buttonCreate.Location = new Point(70, 350);
            buttonCreate.Margin = new Padding(2);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(200, 32);
            buttonCreate.TabIndex = 23;
            buttonCreate.Text = "Create Project";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // textBoxProject
            // 
            textBoxProject.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxProject.Location = new Point(40, 260);
            textBoxProject.Margin = new Padding(2);
            textBoxProject.Name = "textBoxProject";
            textBoxProject.Size = new Size(260, 23);
            textBoxProject.TabIndex = 22;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(40, 210);
            comboBoxCategory.Margin = new Padding(2);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(260, 23);
            comboBoxCategory.TabIndex = 21;
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(40, 160);
            comboBoxDepartment.Margin = new Padding(2);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(260, 23);
            comboBoxDepartment.TabIndex = 20;
            // 
            // comboBoxManagement
            // 
            comboBoxManagement.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxManagement.FormattingEnabled = true;
            comboBoxManagement.Location = new Point(40, 110);
            comboBoxManagement.Margin = new Padding(2);
            comboBoxManagement.Name = "comboBoxManagement";
            comboBoxManagement.Size = new Size(260, 23);
            comboBoxManagement.TabIndex = 19;
            comboBoxManagement.SelectedIndexChanged += comboBoxManagement_SelectedIndexChanged;
            // 
            // CreateProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 450);
            Controls.Add(lblProjectCreate);
            Controls.Add(lblProject);
            Controls.Add(lblCategory);
            Controls.Add(lblDepartment);
            Controls.Add(lblManagement);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxProject);
            Controls.Add(comboBoxCategory);
            Controls.Add(comboBoxDepartment);
            Controls.Add(comboBoxManagement);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "CreateProjectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteForm";
            Load += CreateProjectForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblProjectCreate;
        private Label lblProject;
        private Label lblCategory;
        private Label lblDepartment;
        private Label lblManagement;
        private Button buttonCreate;
        private TextBox textBoxProject;
        private ComboBox comboBoxCategory;
        private ComboBox comboBoxDepartment;
        private ComboBox comboBoxManagement;
    }
}