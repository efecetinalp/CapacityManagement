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
            imgProjectPicture.Location = new Point(17, 30);
            imgProjectPicture.Name = "imgProjectPicture";
            imgProjectPicture.Size = new Size(24, 24);
            imgProjectPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            imgProjectPicture.TabIndex = 0;
            imgProjectPicture.TabStop = false;
            // 
            // panelSeperator
            // 
            panelSeperator.BackColor = Color.FromArgb(52, 73, 94);
            panelSeperator.ForeColor = Color.FromArgb(52, 73, 94);
            panelSeperator.Location = new Point(9, 59);
            panelSeperator.Name = "panelSeperator";
            panelSeperator.Size = new Size(380, 1);
            panelSeperator.TabIndex = 2;
            // 
            // labelProjectDetails
            // 
            labelProjectDetails.AutoSize = true;
            labelProjectDetails.BackColor = Color.Transparent;
            labelProjectDetails.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelProjectDetails.Location = new Point(17, 67);
            labelProjectDetails.Name = "labelProjectDetails";
            labelProjectDetails.Size = new Size(89, 16);
            labelProjectDetails.TabIndex = 3;
            labelProjectDetails.Text = "Project Details";
            // 
            // labelManagement
            // 
            labelManagement.AutoSize = true;
            labelManagement.BackColor = Color.Transparent;
            labelManagement.Font = new Font("Century Gothic", 7F, FontStyle.Bold, GraphicsUnit.Point);
            labelManagement.Location = new Point(25, 98);
            labelManagement.Name = "labelManagement";
            labelManagement.Size = new Size(77, 14);
            labelManagement.TabIndex = 4;
            labelManagement.Text = "Management:";
            // 
            // labelDepartment
            // 
            labelDepartment.AutoSize = true;
            labelDepartment.BackColor = Color.Transparent;
            labelDepartment.Font = new Font("Century Gothic", 7F, FontStyle.Bold, GraphicsUnit.Point);
            labelDepartment.Location = new Point(34, 119);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new Size(68, 14);
            labelDepartment.TabIndex = 5;
            labelDepartment.Text = "Department:";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.BackColor = Color.Transparent;
            labelCategory.Font = new Font("Century Gothic", 7F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategory.Location = new Point(46, 140);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(56, 14);
            labelCategory.TabIndex = 6;
            labelCategory.Text = "Category:";
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.BackColor = Color.Transparent;
            labelStartDate.Font = new Font("Century Gothic", 7F, FontStyle.Bold, GraphicsUnit.Point);
            labelStartDate.Location = new Point(220, 120);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(57, 14);
            labelStartDate.TabIndex = 7;
            labelStartDate.Text = "Start Date:";
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.BackColor = Color.Transparent;
            labelEndDate.Font = new Font("Century Gothic", 7F, FontStyle.Bold, GraphicsUnit.Point);
            labelEndDate.Location = new Point(216, 141);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(61, 14);
            labelEndDate.TabIndex = 8;
            labelEndDate.Text = "Finish Date:";
            // 
            // labelOwner
            // 
            labelOwner.AutoSize = true;
            labelOwner.BackColor = Color.Transparent;
            labelOwner.Font = new Font("Century Gothic", 7F, FontStyle.Bold, GraphicsUnit.Point);
            labelOwner.Location = new Point(61, 161);
            labelOwner.Name = "labelOwner";
            labelOwner.Size = new Size(41, 14);
            labelOwner.TabIndex = 11;
            labelOwner.Text = "Owner:";
            // 
            // buttonClose
            // 
            buttonClose.FlatAppearance.BorderColor = Color.FromArgb(52, 73, 94);
            buttonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClose.ForeColor = Color.Black;
            buttonClose.Location = new Point(302, 186);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(90, 25);
            buttonClose.TabIndex = 13;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // comboBoxUser
            // 
            comboBoxUser.BackColor = SystemColors.Window;
            comboBoxUser.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUser.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            comboBoxUser.FormattingEnabled = true;
            comboBoxUser.Location = new Point(107, 159);
            comboBoxUser.Name = "comboBoxUser";
            comboBoxUser.Size = new Size(89, 20);
            comboBoxUser.TabIndex = 16;
            comboBoxUser.Visible = false;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.BackColor = SystemColors.Window;
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(107, 138);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(89, 20);
            comboBoxCategory.TabIndex = 19;
            comboBoxCategory.Visible = false;
            // 
            // txtProjectName
            // 
            txtProjectName.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtProjectName.Location = new Point(44, 29);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(342, 27);
            txtProjectName.TabIndex = 21;
            txtProjectName.Visible = false;
            // 
            // lblManagement
            // 
            lblManagement.AutoSize = true;
            lblManagement.BackColor = Color.Transparent;
            lblManagement.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblManagement.Location = new Point(107, 100);
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
            lblDepartment.Location = new Point(107, 121);
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
            lblCategory.Location = new Point(107, 142);
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
            lblStartDate.Location = new Point(280, 122);
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
            lblEndDate.Location = new Point(280, 143);
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
            lblOwner.Location = new Point(107, 163);
            lblOwner.Name = "lblOwner";
            lblOwner.Size = new Size(27, 12);
            lblOwner.TabIndex = 27;
            lblOwner.Text = "User1";
            // 
            // lblProjectName
            // 
            lblProjectName.AutoSize = true;
            lblProjectName.BackColor = Color.Transparent;
            lblProjectName.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblProjectName.Location = new Point(47, 33);
            lblProjectName.Name = "lblProjectName";
            lblProjectName.Size = new Size(114, 19);
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
            dateTimePickerStart.Location = new Point(280, 118);
            dateTimePickerStart.Margin = new Padding(2);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.ShowUpDown = true;
            dateTimePickerStart.Size = new Size(78, 20);
            dateTimePickerStart.TabIndex = 29;
            dateTimePickerStart.Visible = false;
            dateTimePickerStart.ValueChanged += dateTimePickerStart_ValueChanged;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.AllowDrop = true;
            dateTimePickerEnd.Checked = false;
            dateTimePickerEnd.CustomFormat = "MMM-yy";
            dateTimePickerEnd.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.ImeMode = ImeMode.NoControl;
            dateTimePickerEnd.Location = new Point(280, 139);
            dateTimePickerEnd.Margin = new Padding(2);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.ShowUpDown = true;
            dateTimePickerEnd.Size = new Size(78, 20);
            dateTimePickerEnd.TabIndex = 30;
            dateTimePickerEnd.Visible = false;
            // 
            // checkBoxCompleted
            // 
            checkBoxCompleted.AutoSize = true;
            checkBoxCompleted.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            checkBoxCompleted.Location = new Point(280, 99);
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
            labelStatus.Font = new Font("Century Gothic", 7F, FontStyle.Bold, GraphicsUnit.Point);
            labelStatus.Location = new Point(239, 100);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(38, 14);
            labelStatus.TabIndex = 32;
            labelStatus.Text = "Status:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblStatus.Location = new Point(280, 101);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(34, 12);
            lblStatus.TabIndex = 33;
            lblStatus.Text = "Status1";
            // 
            // buttonSave
            // 
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(365, 63);
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
            buttonDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.Location = new Point(9, 190);
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
            buttonQuit.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonQuit.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
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
            buttonEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Image = (Image)resources.GetObject("buttonEdit.Image");
            buttonEdit.Location = new Point(365, 63);
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
            BackColor = Color.White;
            ClientSize = new Size(398, 218);
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