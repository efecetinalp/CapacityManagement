namespace DashboardUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnCreate = new System.Windows.Forms.Button();
            this.dbGrid = new System.Windows.Forms.DataGridView();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.comboBoxManagement = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCreate.Location = new System.Drawing.Point(127, 198);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(149, 37);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dbGrid
            // 
            this.dbGrid.AllowDrop = true;
            this.dbGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGrid.Location = new System.Drawing.Point(282, 144);
            this.dbGrid.Name = "dbGrid";
            this.dbGrid.RowHeadersWidth = 62;
            this.dbGrid.RowTemplate.Height = 33;
            this.dbGrid.Size = new System.Drawing.Size(1108, 543);
            this.dbGrid.TabIndex = 1;
            this.dbGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dbGrid_CellBeginEdit);
            this.dbGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbGrid_CellContentClick);
            this.dbGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbGrid_CellEndEdit);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "MMM-yy";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerStart.Location = new System.Drawing.Point(824, 36);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(134, 31);
            this.dateTimePickerStart.TabIndex = 5;
            // 
            // comboBoxManagement
            // 
            this.comboBoxManagement.FormattingEnabled = true;
            this.comboBoxManagement.Location = new System.Drawing.Point(282, 34);
            this.comboBoxManagement.Name = "comboBoxManagement";
            this.comboBoxManagement.Size = new System.Drawing.Size(336, 33);
            this.comboBoxManagement.TabIndex = 7;
            this.comboBoxManagement.SelectedIndexChanged += new System.EventHandler(this.comboBoxManagement_SelectedIndexChanged);
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(282, 82);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(336, 33);
            this.comboBoxDepartment.TabIndex = 8;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(637, 82);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(161, 33);
            this.comboBoxCategory.TabIndex = 9;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "MMM-yy";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(824, 84);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(134, 31);
            this.dateTimePickerEnd.TabIndex = 10;
            // 
            // buttonList
            // 
            this.buttonList.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonList.Location = new System.Drawing.Point(1111, 81);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(115, 33);
            this.buttonList.TabIndex = 11;
            this.buttonList.Text = "List";
            this.buttonList.UseVisualStyleBackColor = false;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonReset.Location = new System.Drawing.Point(1250, 81);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(115, 33);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 513);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnEdit.Location = new System.Drawing.Point(127, 144);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(149, 37);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1416, 710);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.comboBoxManagement);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dbGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.Text = "Capacity Management Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnCreate;
        private DataGridView dbGrid;
        private DateTimePicker dateTimePickerStart;
        private ComboBox comboBoxManagement;
        private ComboBox comboBoxDepartment;
        private ComboBox comboBoxCategory;
        private DateTimePicker dateTimePickerEnd;
        private Button buttonList;
        private Button buttonReset;
        private PictureBox pictureBox1;
        private Button btnEdit;
    }
}