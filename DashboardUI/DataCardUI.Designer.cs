namespace DashboardUI
{
    partial class DataCardUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataCardUI));
            imgProjectPicture = new PictureBox();
            panelSeperator = new Panel();
            labelProjectDetails = new Label();
            labelManagement = new Label();
            labelDepartment = new Label();
            labelCategory = new Label();
            labelStartDate = new Label();
            labelEndDate = new Label();
            labelOwner = new Label();
            buttonClose = new Button();
            comboBoxUser = new ComboBox();
            comboBoxCategory = new ComboBox();
            txtProjectName = new TextBox();
            lblManagement = new Label();
            lblDepartment = new Label();
            lblCategory = new Label();
            lblStartDate = new Label();
            lblEndDate = new Label();
            lblOwner = new Label();
            lblProjectName = new Label();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            checkBoxCompleted = new CheckBox();
            labelStatus = new Label();
            lblStatus = new Label();
            buttonSave = new Button();
            buttonDelete = new Button();
            buttonQuit = new Button();
            buttonEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)imgProjectPicture).BeginInit();
            SuspendLayout();
            // 
            // imgProjectPicture
            // 
            imgProjectPicture.BackColor = Color.Transparent;
            imgProjectPicture.Image = (Image)resources.GetObject("imgProjectPicture.Image");
            imgProjectPicture.Location = new Point(13, 25);
            imgProjectPicture.Name = "imgProjectPicture";
            imgProjectPicture.Size = new Size(32, 32);
            imgProjectPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            imgProjectPicture.TabIndex = 0;
            imgProjectPicture.TabStop = false;
            // 
            // panelSeperator
            // 
            panelSeperator.BackColor = SystemColors.ControlDarkDark;
            panelSeperator.Location = new Point(9, 59);
            panelSeperator.Name = "panelSeperator";
            panelSeperator.Size = new Size(380, 1);
            panelSeperator.TabIndex = 2;
            // 
            // labelProjectDetails
            // 
            labelProjectDetails.AutoSize = true;
            labelProjectDetails.BackColor = Color.Transparent;
            labelProjectDetails.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelProjectDetails.Location = new Point(13, 76);
            labelProjectDetails.Name = "labelProjectDetails";
            labelProjectDetails.Size = new Size(86, 15);
            labelProjectDetails.TabIndex = 3;
            labelProjectDetails.Text = "Project Details";
            // 
            // labelManagement
            // 
            labelManagement.AutoSize = true;
            labelManagement.BackColor = Color.Transparent;
            labelManagement.Font = new Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelManagement.Location = new Point(8, 100);
            labelManagement.Name = "labelManagement";
            labelManagement.Size = new Size(64, 11);
            labelManagement.TabIndex = 4;
            labelManagement.Text = "Management:";
            // 
            // labelDepartment
            // 
            labelDepartment.AutoSize = true;
            labelDepartment.BackColor = Color.Transparent;
            labelDepartment.Font = new Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDepartment.Location = new Point(12, 121);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new Size(60, 11);
            labelDepartment.TabIndex = 5;
            labelDepartment.Text = "Department:";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.BackColor = Color.Transparent;
            labelCategory.Font = new Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategory.Location = new Point(23, 142);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(49, 11);
            labelCategory.TabIndex = 6;
            labelCategory.Text = "Category:";
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.BackColor = Color.Transparent;
            labelStartDate.Font = new Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelStartDate.Location = new Point(234, 120);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(52, 11);
            labelStartDate.TabIndex = 7;
            labelStartDate.Text = "Start Date:";
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.BackColor = Color.Transparent;
            labelEndDate.Font = new Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelEndDate.Location = new Point(226, 141);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(60, 11);
            labelEndDate.TabIndex = 8;
            labelEndDate.Text = "Finish Date:";
            // 
            // labelOwner
            // 
            labelOwner.AutoSize = true;
            labelOwner.BackColor = Color.Transparent;
            labelOwner.Font = new Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelOwner.Location = new Point(35, 163);
            labelOwner.Name = "labelOwner";
            labelOwner.Size = new Size(37, 11);
            labelOwner.TabIndex = 11;
            labelOwner.Text = "Owner:";
            // 
            // buttonClose
            // 
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClose.Location = new Point(311, 196);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 13;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // comboBoxUser
            // 
            comboBoxUser.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            comboBoxUser.FormattingEnabled = true;
            comboBoxUser.Location = new Point(78, 159);
            comboBoxUser.Name = "comboBoxUser";
            comboBoxUser.Size = new Size(126, 20);
            comboBoxUser.TabIndex = 16;
            comboBoxUser.Visible = false;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(78, 138);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(126, 20);
            comboBoxCategory.TabIndex = 19;
            comboBoxCategory.Visible = false;
            // 
            // txtProjectName
            // 
            txtProjectName.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtProjectName.Location = new Point(44, 27);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(342, 31);
            txtProjectName.TabIndex = 21;
            txtProjectName.Visible = false;
            // 
            // lblManagement
            // 
            lblManagement.AutoSize = true;
            lblManagement.BackColor = Color.Transparent;
            lblManagement.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblManagement.Location = new Point(78, 100);
            lblManagement.Name = "lblManagement";
            lblManagement.Size = new Size(61, 12);
            lblManagement.TabIndex = 22;
            lblManagement.Text = "Management1";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.BackColor = Color.Transparent;
            lblDepartment.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblDepartment.Location = new Point(78, 121);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(56, 12);
            lblDepartment.TabIndex = 23;
            lblDepartment.Text = "Department1";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblCategory.Location = new Point(78, 142);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(45, 12);
            lblCategory.TabIndex = 24;
            lblCategory.Text = "Category1";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.BackColor = Color.Transparent;
            lblStartDate.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblStartDate.Location = new Point(292, 120);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(28, 12);
            lblStartDate.TabIndex = 25;
            lblStartDate.Text = "Date1";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.BackColor = Color.Transparent;
            lblEndDate.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblEndDate.Location = new Point(292, 141);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(28, 12);
            lblEndDate.TabIndex = 26;
            lblEndDate.Text = "Date2";
            // 
            // lblOwner
            // 
            lblOwner.AutoSize = true;
            lblOwner.BackColor = Color.Transparent;
            lblOwner.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblOwner.Location = new Point(78, 163);
            lblOwner.Name = "lblOwner";
            lblOwner.Size = new Size(27, 12);
            lblOwner.TabIndex = 27;
            lblOwner.Text = "User1";
            // 
            // lblProjectName
            // 
            lblProjectName.AutoSize = true;
            lblProjectName.BackColor = Color.Transparent;
            lblProjectName.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblProjectName.Location = new Point(47, 30);
            lblProjectName.Name = "lblProjectName";
            lblProjectName.Size = new Size(118, 23);
            lblProjectName.TabIndex = 28;
            lblProjectName.Text = "Project Name";
            lblProjectName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CustomFormat = "MMM-yy";
            dateTimePickerStart.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.ImeMode = ImeMode.NoControl;
            dateTimePickerStart.Location = new Point(292, 114);
            dateTimePickerStart.Margin = new Padding(2);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(94, 20);
            dateTimePickerStart.TabIndex = 29;
            dateTimePickerStart.Visible = false;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CustomFormat = "MMM-yy";
            dateTimePickerEnd.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.ImeMode = ImeMode.NoControl;
            dateTimePickerEnd.Location = new Point(292, 135);
            dateTimePickerEnd.Margin = new Padding(2);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(94, 20);
            dateTimePickerEnd.TabIndex = 30;
            dateTimePickerEnd.Visible = false;
            // 
            // checkBoxCompleted
            // 
            checkBoxCompleted.AutoSize = true;
            checkBoxCompleted.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            checkBoxCompleted.Location = new Point(292, 97);
            checkBoxCompleted.Name = "checkBoxCompleted";
            checkBoxCompleted.Size = new Size(94, 16);
            checkBoxCompleted.TabIndex = 31;
            checkBoxCompleted.Text = "Project Completed";
            checkBoxCompleted.UseVisualStyleBackColor = true;
            checkBoxCompleted.Visible = false;
            checkBoxCompleted.CheckedChanged += checkBoxIsProgressing_CheckedChanged;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.BackColor = Color.Transparent;
            labelStatus.Font = new Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelStatus.Location = new Point(250, 100);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(36, 11);
            labelStatus.TabIndex = 32;
            labelStatus.Text = "Status:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblStatus.Location = new Point(292, 99);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(34, 12);
            lblStatus.TabIndex = 33;
            lblStatus.Text = "Status1";
            // 
            // buttonSave
            // 
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(366, 63);
            buttonSave.Name = "buttonSave";
            buttonSave.Padding = new Padding(0, 0, 1, 1);
            buttonSave.Size = new Size(20, 20);
            buttonSave.TabIndex = 37;
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Visible = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.Location = new Point(8, 200);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Padding = new Padding(0, 0, 1, 1);
            buttonDelete.Size = new Size(20, 20);
            buttonDelete.TabIndex = 38;
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonQuit
            // 
            buttonQuit.FlatAppearance.BorderSize = 0;
            buttonQuit.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonQuit.FlatStyle = FlatStyle.Flat;
            buttonQuit.Image = (Image)resources.GetObject("buttonQuit.Image");
            buttonQuit.Location = new Point(380, 5);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Padding = new Padding(0, 0, 1, 1);
            buttonQuit.Size = new Size(12, 12);
            buttonQuit.TabIndex = 39;
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Image = (Image)resources.GetObject("buttonEdit.Image");
            buttonEdit.Location = new Point(366, 63);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Padding = new Padding(0, 0, 1, 1);
            buttonEdit.Size = new Size(20, 20);
            buttonEdit.TabIndex = 40;
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // DataCardUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(398, 231);
            Controls.Add(buttonEdit);
            Controls.Add(buttonQuit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Controls.Add(lblStatus);
            Controls.Add(labelStatus);
            Controls.Add(checkBoxCompleted);
            Controls.Add(lblProjectName);
            Controls.Add(lblOwner);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(lblCategory);
            Controls.Add(lblDepartment);
            Controls.Add(lblManagement);
            Controls.Add(txtProjectName);
            Controls.Add(comboBoxCategory);
            Controls.Add(comboBoxUser);
            Controls.Add(buttonClose);
            Controls.Add(labelOwner);
            Controls.Add(labelEndDate);
            Controls.Add(labelStartDate);
            Controls.Add(labelCategory);
            Controls.Add(labelDepartment);
            Controls.Add(labelManagement);
            Controls.Add(labelProjectDetails);
            Controls.Add(panelSeperator);
            Controls.Add(imgProjectPicture);
            Controls.Add(dateTimePickerStart);
            Controls.Add(dateTimePickerEnd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DataCardUI";
            StartPosition = FormStartPosition.Manual;
            Text = "DataCard";
            Load += DataCardUI_Load;
            MouseDown += DataCardUI_MouseDown;
            ((System.ComponentModel.ISupportInitialize)imgProjectPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgProjectPicture;
        private Panel panelSeperator;
        private Label labelProjectDetails;
        private Label labelManagement;
        private Label labelDepartment;
        private Label labelCategory;
        private Label labelStartDate;
        private Label labelEndDate;
        private PictureBox imageClose;
        private Label labelOwner;
        private Button buttonClose;
        private ComboBox comboBoxUser;
        private ComboBox comboBoxCategory;
        private TextBox txtProjectName;
        private Label lblManagement;
        private Label lblDepartment;
        private Label lblCategory;
        private Label lblStartDate;
        private Label lblEndDate;
        private Label lblOwner;
        private Label lblProjectName;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private CheckBox checkBoxCompleted;
        private Label labelStatus;
        private Label lblStatus;
        private PictureBox imageDelete;
        private Button buttonSave;
        private Button buttonDelete;
        private Button buttonQuit;
        private Button buttonEdit;
    }
}