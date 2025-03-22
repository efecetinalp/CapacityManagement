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
            buttonCancel = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            labelStartDate = new Label();
            dateTimePickerStart = new DateTimePicker();
            SuspendLayout();
            // 
            // lblProjectCreate
            // 
            lblProjectCreate.AutoSize = true;
            lblProjectCreate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblProjectCreate.Location = new Point(91, 28);
            lblProjectCreate.Margin = new Padding(2, 0, 2, 0);
            lblProjectCreate.Name = "lblProjectCreate";
            lblProjectCreate.Size = new Size(68, 19);
            lblProjectCreate.TabIndex = 29;
            lblProjectCreate.Text = "PROJECT";
            lblProjectCreate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProject
            // 
            lblProject.AutoSize = true;
            lblProject.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProject.Location = new Point(22, 217);
            lblProject.Margin = new Padding(2, 0, 2, 0);
            lblProject.Name = "lblProject";
            lblProject.Size = new Size(42, 13);
            lblProject.TabIndex = 28;
            lblProject.Text = "Project";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategory.Location = new Point(22, 168);
            lblCategory.Margin = new Padding(2, 0, 2, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(53, 13);
            lblCategory.TabIndex = 27;
            lblCategory.Text = "Category";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDepartment.Location = new Point(22, 118);
            lblDepartment.Margin = new Padding(2, 0, 2, 0);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(68, 13);
            lblDepartment.TabIndex = 26;
            lblDepartment.Text = "Department";
            // 
            // lblManagement
            // 
            lblManagement.AutoSize = true;
            lblManagement.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblManagement.Location = new Point(22, 65);
            lblManagement.Margin = new Padding(2, 0, 2, 0);
            lblManagement.Name = "lblManagement";
            lblManagement.Size = new Size(75, 13);
            lblManagement.TabIndex = 25;
            lblManagement.Text = "Management";
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.FromArgb(58, 154, 193);
            buttonCreate.FlatAppearance.BorderColor = Color.FromArgb(58, 154, 193);
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.ForeColor = SystemColors.ButtonHighlight;
            buttonCreate.Location = new Point(22, 408);
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
            textBoxProject.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProject.Location = new Point(23, 234);
            textBoxProject.Margin = new Padding(2);
            textBoxProject.Name = "textBoxProject";
            textBoxProject.Size = new Size(199, 22);
            textBoxProject.TabIndex = 22;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(23, 184);
            comboBoxCategory.Margin = new Padding(2);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(199, 21);
            comboBoxCategory.TabIndex = 21;
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(23, 134);
            comboBoxDepartment.Margin = new Padding(2);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(199, 21);
            comboBoxDepartment.TabIndex = 20;
            // 
            // comboBoxManagement
            // 
            comboBoxManagement.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxManagement.FormattingEnabled = true;
            comboBoxManagement.Location = new Point(23, 84);
            comboBoxManagement.Margin = new Padding(2);
            comboBoxManagement.Name = "comboBoxManagement";
            comboBoxManagement.Size = new Size(199, 21);
            comboBoxManagement.TabIndex = 19;
            comboBoxManagement.SelectedIndexChanged += comboBoxManagement_SelectedIndexChanged;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Silver;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.ForeColor = SystemColors.ActiveCaptionText;
            buttonCancel.Location = new Point(22, 455);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(200, 29);
            buttonCancel.TabIndex = 32;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 270);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 13);
            label1.TabIndex = 34;
            label1.Text = "Project Owner";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(23, 287);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 22);
            textBox1.TabIndex = 33;
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelStartDate.Location = new Point(21, 326);
            labelStartDate.Margin = new Padding(2, 0, 2, 0);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(50, 12);
            labelStartDate.TabIndex = 36;
            labelStartDate.Text = "Start Date";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CustomFormat = "MMM-yy";
            dateTimePickerStart.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.ImeMode = ImeMode.NoControl;
            dateTimePickerStart.Location = new Point(23, 340);
            dateTimePickerStart.Margin = new Padding(2);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(199, 20);
            dateTimePickerStart.TabIndex = 35;
            // 
            // CreateProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 512);
            Controls.Add(labelStartDate);
            Controls.Add(dateTimePickerStart);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(buttonCancel);
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
        private Button buttonCancel;
        private Label label1;
        private TextBox textBox1;
        private Label labelStartDate;
        private DateTimePicker dateTimePickerStart;
    }
}