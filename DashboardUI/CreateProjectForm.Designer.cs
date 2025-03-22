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
            buttonCreate = new Button();
            buttonCancel = new Button();
            checkBoxCompleted = new CheckBox();
            labelEndDate = new Label();
            labelStartDate = new Label();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            labelUser = new Label();
            comboBoxUser = new ComboBox();
            label7 = new Label();
            labelProjectName = new Label();
            labelCategory = new Label();
            labelDepartment = new Label();
            labelManagement = new Label();
            comboBoxCategory = new ComboBox();
            comboBoxDepartment = new ComboBox();
            comboBoxManagement = new ComboBox();
            textBoxProject = new TextBox();
            SuspendLayout();
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.FromArgb(58, 154, 193);
            buttonCreate.FlatAppearance.BorderColor = Color.FromArgb(58, 154, 193);
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreate.ForeColor = SystemColors.ButtonHighlight;
            buttonCreate.Location = new Point(11, 246);
            buttonCreate.Margin = new Padding(2);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(172, 27);
            buttonCreate.TabIndex = 23;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Silver;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = SystemColors.ActiveCaptionText;
            buttonCancel.Location = new Point(205, 246);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(172, 26);
            buttonCancel.TabIndex = 32;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // checkBoxCompleted
            // 
            checkBoxCompleted.AutoSize = true;
            checkBoxCompleted.Font = new Font("Segoe UI Semibold", 6.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkBoxCompleted.Location = new Point(205, 101);
            checkBoxCompleted.Name = "checkBoxCompleted";
            checkBoxCompleted.Size = new Size(98, 16);
            checkBoxCompleted.TabIndex = 52;
            checkBoxCompleted.Text = "Project Completed";
            checkBoxCompleted.UseVisualStyleBackColor = true;
            checkBoxCompleted.CheckedChanged += checkBoxCompleted_CheckedChanged;
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelEndDate.Location = new Point(296, 130);
            labelEndDate.Margin = new Padding(2, 0, 2, 0);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(46, 12);
            labelEndDate.TabIndex = 51;
            labelEndDate.Text = "End Date";
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelStartDate.Location = new Point(205, 130);
            labelStartDate.Margin = new Padding(2, 0, 2, 0);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(50, 12);
            labelStartDate.TabIndex = 50;
            labelStartDate.Text = "Start Date";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CustomFormat = "MMM-yy";
            dateTimePickerStart.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.ImeMode = ImeMode.NoControl;
            dateTimePickerStart.Location = new Point(205, 144);
            dateTimePickerStart.Margin = new Padding(2);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(81, 20);
            dateTimePickerStart.TabIndex = 48;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CustomFormat = "MMM-yy";
            dateTimePickerEnd.Enabled = false;
            dateTimePickerEnd.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.ImeMode = ImeMode.NoControl;
            dateTimePickerEnd.Location = new Point(296, 144);
            dateTimePickerEnd.Margin = new Padding(2);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(81, 20);
            dateTimePickerEnd.TabIndex = 49;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelUser.Location = new Point(204, 178);
            labelUser.Margin = new Padding(2, 0, 2, 0);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(70, 12);
            labelUser.TabIndex = 47;
            labelUser.Text = "Project Owner";
            // 
            // comboBoxUser
            // 
            comboBoxUser.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxUser.FormattingEnabled = true;
            comboBoxUser.Location = new Point(205, 192);
            comboBoxUser.Margin = new Padding(2);
            comboBoxUser.Name = "comboBoxUser";
            comboBoxUser.Size = new Size(172, 20);
            comboBoxUser.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(157, 13);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 45;
            label7.Text = "NEW PROJECT";
            // 
            // labelProjectName
            // 
            labelProjectName.AutoSize = true;
            labelProjectName.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelProjectName.Location = new Point(11, 43);
            labelProjectName.Margin = new Padding(2, 0, 2, 0);
            labelProjectName.Name = "labelProjectName";
            labelProjectName.Size = new Size(67, 12);
            labelProjectName.TabIndex = 44;
            labelProjectName.Text = "Project Name";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelCategory.Location = new Point(11, 178);
            labelCategory.Margin = new Padding(2, 0, 2, 0);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(46, 12);
            labelCategory.TabIndex = 43;
            labelCategory.Text = "Category";
            // 
            // labelDepartment
            // 
            labelDepartment.AutoSize = true;
            labelDepartment.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelDepartment.Location = new Point(11, 133);
            labelDepartment.Margin = new Padding(2, 0, 2, 0);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new Size(59, 12);
            labelDepartment.TabIndex = 42;
            labelDepartment.Text = "Department";
            // 
            // labelManagement
            // 
            labelManagement.AutoSize = true;
            labelManagement.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelManagement.Location = new Point(11, 88);
            labelManagement.Margin = new Padding(2, 0, 2, 0);
            labelManagement.Name = "labelManagement";
            labelManagement.Size = new Size(65, 12);
            labelManagement.TabIndex = 41;
            labelManagement.Text = "Management";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(11, 192);
            comboBoxCategory.Margin = new Padding(2);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(172, 20);
            comboBoxCategory.TabIndex = 40;
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(11, 147);
            comboBoxDepartment.Margin = new Padding(2);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(172, 20);
            comboBoxDepartment.TabIndex = 39;
            // 
            // comboBoxManagement
            // 
            comboBoxManagement.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxManagement.FormattingEnabled = true;
            comboBoxManagement.Location = new Point(11, 102);
            comboBoxManagement.Margin = new Padding(2);
            comboBoxManagement.Name = "comboBoxManagement";
            comboBoxManagement.Size = new Size(172, 20);
            comboBoxManagement.TabIndex = 38;
            comboBoxManagement.SelectedIndexChanged += comboBoxManagement_SelectedIndexChanged;
            // 
            // textBoxProject
            // 
            textBoxProject.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProject.Location = new Point(11, 57);
            textBoxProject.Margin = new Padding(2);
            textBoxProject.Name = "textBoxProject";
            textBoxProject.Size = new Size(172, 20);
            textBoxProject.TabIndex = 37;
            // 
            // CreateProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 308);
            Controls.Add(checkBoxCompleted);
            Controls.Add(labelEndDate);
            Controls.Add(labelStartDate);
            Controls.Add(dateTimePickerStart);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(labelUser);
            Controls.Add(comboBoxUser);
            Controls.Add(label7);
            Controls.Add(labelProjectName);
            Controls.Add(labelCategory);
            Controls.Add(labelDepartment);
            Controls.Add(labelManagement);
            Controls.Add(comboBoxCategory);
            Controls.Add(comboBoxDepartment);
            Controls.Add(comboBoxManagement);
            Controls.Add(textBoxProject);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCreate);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "CreateProjectForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DeleteForm";
            TopMost = true;
            Load += CreateProjectForm_Load;
            MouseDown += CreateProjectForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonCreate;
        private Button buttonCancel;
        private CheckBox checkBoxCompleted;
        private Label labelEndDate;
        private Label labelStartDate;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Label labelUser;
        private ComboBox comboBoxUser;
        private Label label7;
        private Label labelProjectName;
        private Label labelCategory;
        private Label labelDepartment;
        private Label labelManagement;
        private ComboBox comboBoxCategory;
        private ComboBox comboBoxDepartment;
        private ComboBox comboBoxManagement;
        private TextBox textBoxProject;
    }
}