namespace DashboardUI
{
    partial class DataGridForm
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxManagement = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dbGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnEdit.Location = new System.Drawing.Point(1153, 74);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(149, 37);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonReset.Location = new System.Drawing.Point(1187, 125);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(115, 33);
            this.buttonReset.TabIndex = 25;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonList
            // 
            this.buttonList.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonList.Location = new System.Drawing.Point(1048, 125);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(115, 33);
            this.buttonList.TabIndex = 24;
            this.buttonList.Text = "List";
            this.buttonList.UseVisualStyleBackColor = false;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "MMM-yy";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(761, 128);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(134, 31);
            this.dateTimePickerEnd.TabIndex = 23;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(574, 126);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(161, 33);
            this.comboBoxCategory.TabIndex = 22;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(219, 126);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(336, 33);
            this.comboBoxDepartment.TabIndex = 21;
            // 
            // comboBoxManagement
            // 
            this.comboBoxManagement.FormattingEnabled = true;
            this.comboBoxManagement.Location = new System.Drawing.Point(219, 78);
            this.comboBoxManagement.Name = "comboBoxManagement";
            this.comboBoxManagement.Size = new System.Drawing.Size(336, 33);
            this.comboBoxManagement.TabIndex = 20;
            this.comboBoxManagement.SelectedIndexChanged += new System.EventHandler(this.comboBoxManagement_SelectedIndexChanged);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "MMM-yy";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerStart.Location = new System.Drawing.Point(761, 80);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(134, 31);
            this.dateTimePickerStart.TabIndex = 19;
            // 
            // dbGrid
            // 
            this.dbGrid.AllowDrop = true;
            this.dbGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGrid.Location = new System.Drawing.Point(0, 214);
            this.dbGrid.Name = "dbGrid";
            this.dbGrid.RowHeadersWidth = 62;
            this.dbGrid.RowTemplate.Height = 33;
            this.dbGrid.Size = new System.Drawing.Size(1500, 786);
            this.dbGrid.TabIndex = 17;
            this.dbGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dbGrid_CellBeginEdit);
            this.dbGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbGrid_CellContentClick);
            this.dbGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbGrid_CellEndEdit);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxManagement);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.dateTimePickerStart);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.comboBoxDepartment);
            this.panel1.Controls.Add(this.buttonList);
            this.panel1.Controls.Add(this.comboBoxCategory);
            this.panel1.Controls.Add(this.dateTimePickerEnd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 188);
            this.panel1.TabIndex = 27;
            // 
            // DataGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1500, 1000);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dbGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataGridForm";
            this.Text = "DataGridForm";
            this.Load += new System.EventHandler(this.DataGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnEdit;
        private Button buttonReset;
        private Button buttonList;
        private DateTimePicker dateTimePickerEnd;
        private ComboBox comboBoxCategory;
        private ComboBox comboBoxDepartment;
        private ComboBox comboBoxManagement;
        private DateTimePicker dateTimePickerStart;
        private DataGridView dbGrid;
        private Panel panel1;
    }
}