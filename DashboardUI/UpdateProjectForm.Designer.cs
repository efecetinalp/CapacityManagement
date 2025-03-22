namespace DashboardUI
{
    partial class UpdateProjectForm
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
            textBoxProject = new TextBox();
            comboBoxManagement = new ComboBox();
            comboBoxDepartment = new ComboBox();
            comboBoxCategory = new ComboBox();
            buttonUpdate = new Button();
            buttonCancel = new Button();
            labelManagement = new Label();
            labelDepartment = new Label();
            labelCategory = new Label();
            labelProjectName = new Label();
            label7 = new Label();
            labelUser = new Label();
            comboBoxUser = new ComboBox();
            labelEndDate = new Label();
            labelStartDate = new Label();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            checkBoxCompleted = new CheckBox();
            SuspendLayout();
            // 
            // textBoxProject
            // 
            textBoxProject.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProject.Location = new Point(29, 69);
            textBoxProject.Margin = new Padding(2);
            textBoxProject.Name = "textBoxProject";
            textBoxProject.Size = new Size(172, 20);
            textBoxProject.TabIndex = 0;
            // 
            // comboBoxManagement
            // 
            comboBoxManagement.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxManagement.FormattingEnabled = true;
            comboBoxManagement.Location = new Point(29, 114);
            comboBoxManagement.Margin = new Padding(2);
            comboBoxManagement.Name = "comboBoxManagement";
            comboBoxManagement.Size = new Size(172, 20);
            comboBoxManagement.TabIndex = 1;
            comboBoxManagement.SelectedIndexChanged += comboBoxManagement_SelectedIndexChanged;
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(29, 159);
            comboBoxDepartment.Margin = new Padding(2);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(172, 20);
            comboBoxDepartment.TabIndex = 2;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(29, 204);
            comboBoxCategory.Margin = new Padding(2);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(172, 20);
            comboBoxCategory.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(58, 154, 193);
            buttonUpdate.FlatAppearance.BorderColor = Color.FromArgb(58, 154, 193);
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUpdate.ForeColor = SystemColors.ButtonHighlight;
            buttonUpdate.Location = new Point(28, 266);
            buttonUpdate.Margin = new Padding(2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(173, 29);
            buttonUpdate.TabIndex = 6;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(223, 266);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(172, 29);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelManagement
            // 
            labelManagement.AutoSize = true;
            labelManagement.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelManagement.Location = new Point(29, 100);
            labelManagement.Margin = new Padding(2, 0, 2, 0);
            labelManagement.Name = "labelManagement";
            labelManagement.Size = new Size(65, 12);
            labelManagement.TabIndex = 8;
            labelManagement.Text = "Management";
            // 
            // labelDepartment
            // 
            labelDepartment.AutoSize = true;
            labelDepartment.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelDepartment.Location = new Point(29, 145);
            labelDepartment.Margin = new Padding(2, 0, 2, 0);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new Size(59, 12);
            labelDepartment.TabIndex = 9;
            labelDepartment.Text = "Department";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelCategory.Location = new Point(29, 190);
            labelCategory.Margin = new Padding(2, 0, 2, 0);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(46, 12);
            labelCategory.TabIndex = 10;
            labelCategory.Text = "Category";
            // 
            // labelProjectName
            // 
            labelProjectName.AutoSize = true;
            labelProjectName.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelProjectName.Location = new Point(29, 55);
            labelProjectName.Margin = new Padding(2, 0, 2, 0);
            labelProjectName.Name = "labelProjectName";
            labelProjectName.Size = new Size(67, 12);
            labelProjectName.TabIndex = 13;
            labelProjectName.Text = "Project Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(170, 25);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 14;
            label7.Text = "EDIT PROJECT";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelUser.Location = new Point(222, 190);
            labelUser.Margin = new Padding(2, 0, 2, 0);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(70, 12);
            labelUser.TabIndex = 16;
            labelUser.Text = "Project Owner";
            // 
            // comboBoxUser
            // 
            comboBoxUser.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxUser.FormattingEnabled = true;
            comboBoxUser.Location = new Point(223, 204);
            comboBoxUser.Margin = new Padding(2);
            comboBoxUser.Name = "comboBoxUser";
            comboBoxUser.Size = new Size(172, 20);
            comboBoxUser.TabIndex = 15;
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelEndDate.Location = new Point(314, 142);
            labelEndDate.Margin = new Padding(2, 0, 2, 0);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(46, 12);
            labelEndDate.TabIndex = 35;
            labelEndDate.Text = "End Date";
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelStartDate.Location = new Point(223, 142);
            labelStartDate.Margin = new Padding(2, 0, 2, 0);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(50, 12);
            labelStartDate.TabIndex = 34;
            labelStartDate.Text = "Start Date";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CustomFormat = "MMM-yy";
            dateTimePickerStart.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.ImeMode = ImeMode.NoControl;
            dateTimePickerStart.Location = new Point(223, 156);
            dateTimePickerStart.Margin = new Padding(2);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(81, 20);
            dateTimePickerStart.TabIndex = 32;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CustomFormat = "MMM-yy";
            dateTimePickerEnd.Enabled = false;
            dateTimePickerEnd.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.ImeMode = ImeMode.NoControl;
            dateTimePickerEnd.Location = new Point(314, 156);
            dateTimePickerEnd.Margin = new Padding(2);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(81, 20);
            dateTimePickerEnd.TabIndex = 33;
            // 
            // checkBoxCompleted
            // 
            checkBoxCompleted.AutoSize = true;
            checkBoxCompleted.Font = new Font("Segoe UI Semibold", 6.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkBoxCompleted.Location = new Point(223, 113);
            checkBoxCompleted.Name = "checkBoxCompleted";
            checkBoxCompleted.Size = new Size(98, 16);
            checkBoxCompleted.TabIndex = 36;
            checkBoxCompleted.Text = "Project Completed";
            checkBoxCompleted.UseVisualStyleBackColor = true;
            checkBoxCompleted.CheckedChanged += checkBoxCompleted_CheckedChanged;
            // 
            // UpdateProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 326);
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
            Controls.Add(buttonCancel);
            Controls.Add(buttonUpdate);
            Controls.Add(comboBoxCategory);
            Controls.Add(comboBoxDepartment);
            Controls.Add(comboBoxManagement);
            Controls.Add(textBoxProject);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "UpdateProjectForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Project";
            TopMost = true;
            Load += UpdateProjectForm_Load;
            MouseDown += UpdateProjectForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProject;
        private ComboBox comboBoxManagement;
        private ComboBox comboBoxDepartment;
        private ComboBox comboBoxCategory;
        private Button buttonUpdate;
        private Button buttonCancel;
        private Label labelManagement;
        private Label labelDepartment;
        private Label labelCategory;
        private Label labelProjectName;
        private Label label7;
        private Label labelUser;
        private ComboBox comboBoxUser;
        private Label labelEndDate;
        private Label labelStartDate;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private CheckBox checkBoxCompleted;
    }
}