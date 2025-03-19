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
            panel1 = new Panel();
            labelProjectDetails = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            imgEdit = new PictureBox();
            imageClose = new PictureBox();
            label6 = new Label();
            buttonClose = new Button();
            comboBoxManagement = new ComboBox();
            comboBoxUser = new ComboBox();
            comboBoxCategory = new ComboBox();
            comboBoxDepartment = new ComboBox();
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
            checkBoxIsProgressing = new CheckBox();
            label7 = new Label();
            lblStatus = new Label();
            imgSave = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgProjectPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgSave).BeginInit();
            SuspendLayout();
            // 
            // imgProjectPicture
            // 
            imgProjectPicture.BackColor = SystemColors.ActiveCaption;
            imgProjectPicture.Image = (Image)resources.GetObject("imgProjectPicture.Image");
            imgProjectPicture.Location = new Point(13, 12);
            imgProjectPicture.Name = "imgProjectPicture";
            imgProjectPicture.Size = new Size(48, 43);
            imgProjectPicture.SizeMode = PictureBoxSizeMode.Zoom;
            imgProjectPicture.TabIndex = 0;
            imgProjectPicture.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(13, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 1);
            panel1.TabIndex = 2;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 100);
            label2.Name = "label2";
            label2.Size = new Size(64, 11);
            label2.TabIndex = 4;
            label2.Text = "Management:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 121);
            label1.Name = "label1";
            label1.Size = new Size(60, 11);
            label1.TabIndex = 5;
            label1.Text = "Department:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 142);
            label3.Name = "label3";
            label3.Size = new Size(49, 11);
            label3.TabIndex = 6;
            label3.Text = "Category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 182);
            label4.Name = "label4";
            label4.Size = new Size(52, 11);
            label4.TabIndex = 7;
            label4.Text = "Start Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(22, 203);
            label5.Name = "label5";
            label5.Size = new Size(60, 11);
            label5.TabIndex = 8;
            label5.Text = "Finish Date:";
            // 
            // imgEdit
            // 
            imgEdit.BackColor = SystemColors.ActiveCaption;
            imgEdit.Image = (Image)resources.GetObject("imgEdit.Image");
            imgEdit.Location = new Point(193, 65);
            imgEdit.Name = "imgEdit";
            imgEdit.Size = new Size(21, 20);
            imgEdit.SizeMode = PictureBoxSizeMode.AutoSize;
            imgEdit.TabIndex = 9;
            imgEdit.TabStop = false;
            imgEdit.Click += imgEdit_Click;
            // 
            // imageClose
            // 
            imageClose.BackColor = SystemColors.ActiveCaption;
            imageClose.Image = (Image)resources.GetObject("imageClose.Image");
            imageClose.Location = new Point(200, 3);
            imageClose.Name = "imageClose";
            imageClose.Size = new Size(20, 17);
            imageClose.SizeMode = PictureBoxSizeMode.AutoSize;
            imageClose.TabIndex = 10;
            imageClose.TabStop = false;
            imageClose.Click += imageClose_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(45, 224);
            label6.Name = "label6";
            label6.Size = new Size(37, 11);
            label6.TabIndex = 11;
            label6.Text = "Owner:";
            // 
            // buttonClose
            // 
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClose.Location = new Point(145, 259);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 13;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // comboBoxManagement
            // 
            comboBoxManagement.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            comboBoxManagement.FormattingEnabled = true;
            comboBoxManagement.Location = new Point(88, 96);
            comboBoxManagement.Name = "comboBoxManagement";
            comboBoxManagement.Size = new Size(126, 20);
            comboBoxManagement.TabIndex = 14;
            comboBoxManagement.Visible = false;
            // 
            // comboBoxUser
            // 
            comboBoxUser.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            comboBoxUser.FormattingEnabled = true;
            comboBoxUser.Location = new Point(88, 218);
            comboBoxUser.Name = "comboBoxUser";
            comboBoxUser.Size = new Size(126, 20);
            comboBoxUser.TabIndex = 16;
            comboBoxUser.Visible = false;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(88, 138);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(126, 20);
            comboBoxCategory.TabIndex = 19;
            comboBoxCategory.Visible = false;
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(88, 117);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(126, 20);
            comboBoxDepartment.TabIndex = 20;
            comboBoxDepartment.Visible = false;
            // 
            // txtProjectName
            // 
            txtProjectName.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtProjectName.Location = new Point(67, 28);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(146, 31);
            txtProjectName.TabIndex = 21;
            txtProjectName.Visible = false;
            // 
            // lblManagement
            // 
            lblManagement.AutoSize = true;
            lblManagement.BackColor = Color.Transparent;
            lblManagement.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblManagement.Location = new Point(88, 100);
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
            lblDepartment.Location = new Point(88, 121);
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
            lblCategory.Location = new Point(88, 142);
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
            lblStartDate.Location = new Point(88, 182);
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
            lblEndDate.Location = new Point(88, 203);
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
            lblOwner.Location = new Point(88, 224);
            lblOwner.Name = "lblOwner";
            lblOwner.Size = new Size(27, 12);
            lblOwner.TabIndex = 27;
            lblOwner.Text = "User1";
            // 
            // lblProjectName
            // 
            lblProjectName.AutoSize = true;
            lblProjectName.BackColor = Color.Transparent;
            lblProjectName.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProjectName.Location = new Point(76, 32);
            lblProjectName.Name = "lblProjectName";
            lblProjectName.Size = new Size(118, 23);
            lblProjectName.TabIndex = 28;
            lblProjectName.Text = "Project Name";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CustomFormat = "MMM-yy";
            dateTimePickerStart.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.ImeMode = ImeMode.NoControl;
            dateTimePickerStart.Location = new Point(88, 176);
            dateTimePickerStart.Margin = new Padding(2);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(126, 20);
            dateTimePickerStart.TabIndex = 29;
            dateTimePickerStart.Visible = false;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CustomFormat = "MMM-yy";
            dateTimePickerEnd.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.ImeMode = ImeMode.NoControl;
            dateTimePickerEnd.Location = new Point(88, 197);
            dateTimePickerEnd.Margin = new Padding(2);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(126, 20);
            dateTimePickerEnd.TabIndex = 30;
            dateTimePickerEnd.Visible = false;
            // 
            // checkBoxIsProgressing
            // 
            checkBoxIsProgressing.AutoSize = true;
            checkBoxIsProgressing.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            checkBoxIsProgressing.Location = new Point(88, 159);
            checkBoxIsProgressing.Name = "checkBoxIsProgressing";
            checkBoxIsProgressing.Size = new Size(94, 16);
            checkBoxIsProgressing.TabIndex = 31;
            checkBoxIsProgressing.Text = "Project Completed";
            checkBoxIsProgressing.UseVisualStyleBackColor = true;
            checkBoxIsProgressing.Visible = false;
            checkBoxIsProgressing.CheckedChanged += checkBoxIsProgressing_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(46, 162);
            label7.Name = "label7";
            label7.Size = new Size(36, 11);
            label7.TabIndex = 32;
            label7.Text = "Status:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblStatus.Location = new Point(88, 161);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(34, 12);
            lblStatus.TabIndex = 33;
            lblStatus.Text = "Status1";
            // 
            // imgSave
            // 
            imgSave.BackColor = SystemColors.ActiveCaption;
            imgSave.Image = (Image)resources.GetObject("imgSave.Image");
            imgSave.Location = new Point(166, 65);
            imgSave.Name = "imgSave";
            imgSave.Size = new Size(20, 21);
            imgSave.SizeMode = PictureBoxSizeMode.AutoSize;
            imgSave.TabIndex = 34;
            imgSave.TabStop = false;
            imgSave.Visible = false;
            imgSave.Click += imgSave_Click;
            // 
            // DataCardUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 290);
            Controls.Add(imgSave);
            Controls.Add(lblStatus);
            Controls.Add(label7);
            Controls.Add(checkBoxIsProgressing);
            Controls.Add(lblProjectName);
            Controls.Add(lblOwner);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(lblCategory);
            Controls.Add(lblDepartment);
            Controls.Add(lblManagement);
            Controls.Add(txtProjectName);
            Controls.Add(comboBoxDepartment);
            Controls.Add(comboBoxCategory);
            Controls.Add(comboBoxUser);
            Controls.Add(comboBoxManagement);
            Controls.Add(buttonClose);
            Controls.Add(label6);
            Controls.Add(imageClose);
            Controls.Add(imgEdit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(labelProjectDetails);
            Controls.Add(panel1);
            Controls.Add(imgProjectPicture);
            Controls.Add(dateTimePickerStart);
            Controls.Add(dateTimePickerEnd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DataCardUI";
            StartPosition = FormStartPosition.Manual;
            Text = "DataCard";
            Load += DataCardUI_Load;
            ((System.ComponentModel.ISupportInitialize)imgProjectPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgSave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgProjectPicture;
        private Panel panel1;
        private Label labelProjectDetails;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox imgEdit;
        private PictureBox imageClose;
        private Label label6;
        private Button buttonClose;
        private ComboBox comboBoxManagement;
        private ComboBox comboBoxUser;
        private ComboBox comboBoxCategory;
        private ComboBox comboBoxDepartment;
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
        private CheckBox checkBoxIsProgressing;
        private Label label7;
        private Label lblStatus;
        private PictureBox imgSave;
    }
}