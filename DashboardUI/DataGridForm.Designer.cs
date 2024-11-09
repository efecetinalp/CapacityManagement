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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnEdit = new Button();
            buttonReset = new Button();
            buttonList = new Button();
            dateTimePickerEnd = new DateTimePicker();
            comboBoxCategory = new ComboBox();
            comboBoxDepartment = new ComboBox();
            comboBoxManagement = new ComboBox();
            dateTimePickerStart = new DateTimePicker();
            dbGrid = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonNew = new Button();
            ((System.ComponentModel.ISupportInitialize)dbGrid).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BackColor = Color.FromArgb(46, 52, 63);
            btnEdit.Enabled = false;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(1144, 79);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(7, 0, 0, 0);
            btnEdit.Size = new Size(113, 38);
            btnEdit.TabIndex = 26;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = SystemColors.HighlightText;
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReset.Location = new Point(607, 47);
            buttonReset.Margin = new Padding(2);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(108, 25);
            buttonReset.TabIndex = 25;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonList
            // 
            buttonList.BackColor = SystemColors.HighlightText;
            buttonList.FlatStyle = FlatStyle.Flat;
            buttonList.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonList.Location = new Point(607, 93);
            buttonList.Margin = new Padding(2);
            buttonList.Name = "buttonList";
            buttonList.Size = new Size(108, 25);
            buttonList.TabIndex = 24;
            buttonList.Text = "List";
            buttonList.UseVisualStyleBackColor = false;
            buttonList.Click += buttonList_Click;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CustomFormat = "MMM-yy";
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.ImeMode = ImeMode.NoControl;
            dateTimePickerEnd.Location = new Point(460, 93);
            dateTimePickerEnd.Margin = new Padding(2);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(106, 23);
            dateTimePickerEnd.TabIndex = 23;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(284, 94);
            comboBoxCategory.Margin = new Padding(2);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(147, 23);
            comboBoxCategory.TabIndex = 22;
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(21, 94);
            comboBoxDepartment.Margin = new Padding(2);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(236, 23);
            comboBoxDepartment.TabIndex = 21;
            // 
            // comboBoxManagement
            // 
            comboBoxManagement.FormattingEnabled = true;
            comboBoxManagement.Location = new Point(21, 45);
            comboBoxManagement.Margin = new Padding(2);
            comboBoxManagement.Name = "comboBoxManagement";
            comboBoxManagement.Size = new Size(236, 23);
            comboBoxManagement.TabIndex = 20;
            comboBoxManagement.SelectedIndexChanged += comboBoxManagement_SelectedIndexChanged;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CustomFormat = "MMM-yy";
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.ImeMode = ImeMode.NoControl;
            dateTimePickerStart.Location = new Point(460, 45);
            dateTimePickerStart.Margin = new Padding(2);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(106, 23);
            dateTimePickerStart.TabIndex = 19;
            // 
            // dbGrid
            // 
            dbGrid.AllowDrop = true;
            dbGrid.AllowUserToAddRows = false;
            dbGrid.AllowUserToDeleteRows = false;
            dbGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dbGrid.BackgroundColor = Color.White;
            dbGrid.BorderStyle = BorderStyle.None;
            dbGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 52, 63);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dbGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dbGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dbGrid.DefaultCellStyle = dataGridViewCellStyle2;
            dbGrid.EnableHeadersVisualStyles = false;
            dbGrid.GridColor = SystemColors.ActiveCaption;
            dbGrid.Location = new Point(21, 146);
            dbGrid.Margin = new Padding(2);
            dbGrid.Name = "dbGrid";
            dbGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(46, 52, 63);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dbGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dbGrid.RowHeadersWidth = 62;
            dbGrid.RowTemplate.Height = 33;
            dbGrid.Size = new Size(1236, 491);
            dbGrid.TabIndex = 17;
            dbGrid.CellBeginEdit += dbGrid_CellBeginEdit;
            dbGrid.CellContentClick += dbGrid_CellContentClick;
            dbGrid.CellEndEdit += dbGrid_CellEndEdit;
            dbGrid.ColumnAdded += dbGrid_ColumnAdded;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(21, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 17);
            label1.TabIndex = 27;
            label1.Text = "Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(21, 75);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 28;
            label2.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(284, 75);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 29;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(460, 26);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 17);
            label4.TabIndex = 30;
            label4.Text = "Start Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(460, 74);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 17);
            label5.TabIndex = 31;
            label5.Text = "End Date";
            // 
            // buttonNew
            // 
            buttonNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonNew.BackColor = Color.FromArgb(58, 154, 193);
            buttonNew.FlatStyle = FlatStyle.Flat;
            buttonNew.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNew.ForeColor = Color.White;
            buttonNew.Image = (Image)resources.GetObject("buttonNew.Image");
            buttonNew.ImageAlign = ContentAlignment.MiddleLeft;
            buttonNew.Location = new Point(1012, 79);
            buttonNew.Margin = new Padding(2);
            buttonNew.Name = "buttonNew";
            buttonNew.Padding = new Padding(7, 0, 0, 0);
            buttonNew.Size = new Size(113, 38);
            buttonNew.TabIndex = 32;
            buttonNew.Text = "New";
            buttonNew.UseVisualStyleBackColor = false;
            buttonNew.Click += buttonNew_Click;
            // 
            // DataGridForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1280, 660);
            Controls.Add(buttonNew);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxManagement);
            Controls.Add(comboBoxDepartment);
            Controls.Add(dateTimePickerStart);
            Controls.Add(btnEdit);
            Controls.Add(comboBoxCategory);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(buttonList);
            Controls.Add(dbGrid);
            Controls.Add(buttonReset);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "DataGridForm";
            Text = "DataGridForm";
            Load += DataGridForm_Load;
            ((System.ComponentModel.ISupportInitialize)dbGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonNew;
    }
}