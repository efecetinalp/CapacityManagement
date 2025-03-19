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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            buttonEdit = new Button();
            buttonReset = new Button();
            dateTimePickerEnd = new DateTimePicker();
            comboBoxDepartment = new ComboBox();
            comboBoxManagement = new ComboBox();
            dateTimePickerStart = new DateTimePicker();
            dbGrid = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonNew = new Button();
            buttonRefresh = new Button();
            buttonExportToExcel = new Button();
            buttonList = new Button();
            imgProjectCardIcon = new PictureBox();
            checkBoxHideProjects = new CheckBox();
            buttonChart = new Button();
            ((System.ComponentModel.ISupportInitialize)dbGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgProjectCardIcon).BeginInit();
            SuspendLayout();
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEdit.BackColor = Color.Transparent;
            buttonEdit.Cursor = Cursors.Hand;
            buttonEdit.Enabled = false;
            buttonEdit.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Image = (Image)resources.GetObject("buttonEdit.Image");
            buttonEdit.Location = new Point(1226, 25);
            buttonEdit.Margin = new Padding(2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(32, 32);
            buttonEdit.TabIndex = 26;
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += btnEdit_Click;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.Transparent;
            buttonReset.Cursor = Cursors.Hand;
            buttonReset.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReset.Image = (Image)resources.GetObject("buttonReset.Image");
            buttonReset.Location = new Point(684, 25);
            buttonReset.Margin = new Padding(2);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(32, 32);
            buttonReset.TabIndex = 25;
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CustomFormat = "MMM-yy";
            dateTimePickerEnd.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.ImeMode = ImeMode.NoControl;
            dateTimePickerEnd.Location = new Point(488, 33);
            dateTimePickerEnd.Margin = new Padding(2);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(106, 20);
            dateTimePickerEnd.TabIndex = 23;
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDepartment.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(190, 33);
            comboBoxDepartment.Margin = new Padding(2);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(150, 20);
            comboBoxDepartment.TabIndex = 21;
            // 
            // comboBoxManagement
            // 
            comboBoxManagement.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxManagement.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxManagement.FormattingEnabled = true;
            comboBoxManagement.Location = new Point(23, 33);
            comboBoxManagement.Margin = new Padding(2);
            comboBoxManagement.Name = "comboBoxManagement";
            comboBoxManagement.Size = new Size(150, 20);
            comboBoxManagement.TabIndex = 20;
            comboBoxManagement.SelectedIndexChanged += comboBoxManagement_SelectedIndexChanged;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CustomFormat = "MMM-yy";
            dateTimePickerStart.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.ImeMode = ImeMode.NoControl;
            dateTimePickerStart.Location = new Point(362, 33);
            dateTimePickerStart.Margin = new Padding(2);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(106, 20);
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(46, 52, 63);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dbGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dbGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dbGrid.DefaultCellStyle = dataGridViewCellStyle8;
            dbGrid.EnableHeadersVisualStyles = false;
            dbGrid.GridColor = SystemColors.ActiveCaption;
            dbGrid.Location = new Point(21, 79);
            dbGrid.Margin = new Padding(2);
            dbGrid.Name = "dbGrid";
            dbGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(46, 52, 63);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dbGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dbGrid.RowHeadersVisible = false;
            dbGrid.RowHeadersWidth = 62;
            dbGrid.RowTemplate.Height = 33;
            dbGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dbGrid.Size = new Size(1236, 558);
            dbGrid.TabIndex = 17;
            dbGrid.CellBeginEdit += dbGrid_CellBeginEdit;
            dbGrid.CellContentClick += dbGrid_CellContentClick;
            dbGrid.CellEndEdit += dbGrid_CellEndEdit;
            dbGrid.CellMouseMove += dbGrid_CellMouseMove;
            dbGrid.ColumnAdded += dbGrid_ColumnAdded;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(23, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 12);
            label1.TabIndex = 27;
            label1.Text = "Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(190, 19);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 12);
            label2.TabIndex = 28;
            label2.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(360, 19);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 12);
            label4.TabIndex = 30;
            label4.Text = "Start Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(485, 20);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 12);
            label5.TabIndex = 31;
            label5.Text = "End Date";
            // 
            // buttonNew
            // 
            buttonNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonNew.BackColor = Color.Transparent;
            buttonNew.Cursor = Cursors.Hand;
            buttonNew.Enabled = false;
            buttonNew.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonNew.FlatStyle = FlatStyle.Flat;
            buttonNew.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNew.ForeColor = Color.White;
            buttonNew.Image = (Image)resources.GetObject("buttonNew.Image");
            buttonNew.Location = new Point(1190, 25);
            buttonNew.Margin = new Padding(2);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(32, 32);
            buttonNew.TabIndex = 32;
            buttonNew.UseVisualStyleBackColor = false;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.Transparent;
            buttonRefresh.Cursor = Cursors.Hand;
            buttonRefresh.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRefresh.Image = (Image)resources.GetObject("buttonRefresh.Image");
            buttonRefresh.Location = new Point(648, 25);
            buttonRefresh.Margin = new Padding(2);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(32, 32);
            buttonRefresh.TabIndex = 33;
            buttonRefresh.UseVisualStyleBackColor = false;
            // 
            // buttonExportToExcel
            // 
            buttonExportToExcel.BackColor = Color.Transparent;
            buttonExportToExcel.Cursor = Cursors.Hand;
            buttonExportToExcel.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonExportToExcel.FlatStyle = FlatStyle.Flat;
            buttonExportToExcel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExportToExcel.Image = (Image)resources.GetObject("buttonExportToExcel.Image");
            buttonExportToExcel.Location = new Point(756, 25);
            buttonExportToExcel.Margin = new Padding(2);
            buttonExportToExcel.Name = "buttonExportToExcel";
            buttonExportToExcel.Size = new Size(32, 32);
            buttonExportToExcel.TabIndex = 35;
            buttonExportToExcel.UseVisualStyleBackColor = false;
            buttonExportToExcel.Click += buttonExportToExcel_Click;
            // 
            // buttonList
            // 
            buttonList.BackColor = Color.Transparent;
            buttonList.Cursor = Cursors.Hand;
            buttonList.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonList.FlatStyle = FlatStyle.Flat;
            buttonList.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonList.Image = (Image)resources.GetObject("buttonList.Image");
            buttonList.Location = new Point(612, 25);
            buttonList.Margin = new Padding(2);
            buttonList.Name = "buttonList";
            buttonList.Size = new Size(32, 32);
            buttonList.TabIndex = 36;
            buttonList.UseVisualStyleBackColor = false;
            buttonList.Click += buttonList_Click;
            // 
            // imgProjectCardIcon
            // 
            imgProjectCardIcon.Image = (Image)resources.GetObject("imgProjectCardIcon.Image");
            imgProjectCardIcon.Location = new Point(1237, 79);
            imgProjectCardIcon.Name = "imgProjectCardIcon";
            imgProjectCardIcon.Size = new Size(20, 23);
            imgProjectCardIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            imgProjectCardIcon.TabIndex = 37;
            imgProjectCardIcon.TabStop = false;
            imgProjectCardIcon.Visible = false;
            imgProjectCardIcon.Click += imgProjectCardIcon_Click;
            // 
            // checkBoxHideProjects
            // 
            checkBoxHideProjects.AutoSize = true;
            checkBoxHideProjects.Font = new Font("Segoe UI Semibold", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxHideProjects.Location = new Point(23, 58);
            checkBoxHideProjects.Name = "checkBoxHideProjects";
            checkBoxHideProjects.Size = new Size(89, 16);
            checkBoxHideProjects.TabIndex = 38;
            checkBoxHideProjects.Text = "Hide Completed";
            checkBoxHideProjects.UseVisualStyleBackColor = true;
            checkBoxHideProjects.CheckedChanged += checkBoxHideProjects_CheckedChanged;
            // 
            // buttonChart
            // 
            buttonChart.BackColor = Color.Transparent;
            buttonChart.Cursor = Cursors.Hand;
            buttonChart.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonChart.FlatStyle = FlatStyle.Flat;
            buttonChart.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonChart.Image = (Image)resources.GetObject("buttonChart.Image");
            buttonChart.Location = new Point(720, 25);
            buttonChart.Margin = new Padding(2);
            buttonChart.Name = "buttonChart";
            buttonChart.Size = new Size(32, 32);
            buttonChart.TabIndex = 39;
            buttonChart.UseVisualStyleBackColor = false;
            buttonChart.Click += buttonChart_Click;
            // 
            // DataGridForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1280, 660);
            Controls.Add(buttonChart);
            Controls.Add(checkBoxHideProjects);
            Controls.Add(imgProjectCardIcon);
            Controls.Add(buttonList);
            Controls.Add(buttonExportToExcel);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonNew);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxManagement);
            Controls.Add(comboBoxDepartment);
            Controls.Add(dateTimePickerStart);
            Controls.Add(buttonEdit);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dbGrid);
            Controls.Add(buttonReset);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "DataGridForm";
            Text = "DataGridForm";
            Load += DataGridForm_Load;
            ((System.ComponentModel.ISupportInitialize)dbGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgProjectCardIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEdit;
        private Button buttonReset;
        private DateTimePicker dateTimePickerEnd;
        private ComboBox comboBoxDepartment;
        private ComboBox comboBoxManagement;
        private DateTimePicker dateTimePickerStart;
        private DataGridView dbGrid;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Button buttonNew;
        private Button buttonRefresh;
        private Button buttonExportToExcel;
        private Button buttonList;
        private PictureBox imgProjectCardIcon;
        private CheckBox checkBoxHideProjects;
        private Button buttonChart;
    }
}