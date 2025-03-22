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
            buttonEdit = new Button();
            buttonReset = new Button();
            dateTimePickerEnd = new DateTimePicker();
            comboBoxDepartment = new ComboBox();
            comboBoxManagement = new ComboBox();
            dateTimePickerStart = new DateTimePicker();
            dbGrid = new DataGridView();
            labelManagement = new Label();
            labelDepartment = new Label();
            labelStartDate = new Label();
            labelEndDate = new Label();
            buttonNew = new Button();
            buttonExportToExcel = new Button();
            buttonList = new Button();
            buttonChart = new Button();
            buttonCard = new Button();
            buttonShowHide = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBoxLocked = new PictureBox();
            pictureBoxUnlocked = new PictureBox();
            labelLockStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dbGrid).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLocked).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUnlocked).BeginInit();
            SuspendLayout();
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEdit.BackColor = Color.Transparent;
            buttonEdit.Cursor = Cursors.Hand;
            buttonEdit.Enabled = false;
            buttonEdit.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Image = (Image)resources.GetObject("buttonEdit.Image");
            buttonEdit.Location = new Point(27, 2);
            buttonEdit.Margin = new Padding(2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Padding = new Padding(0, 0, 1, 1);
            buttonEdit.Size = new Size(20, 20);
            buttonEdit.TabIndex = 26;
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += btnEdit_Click;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.Transparent;
            buttonReset.Cursor = Cursors.Hand;
            buttonReset.Enabled = false;
            buttonReset.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonReset.FlatAppearance.BorderSize = 0;
            buttonReset.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReset.Image = (Image)resources.GetObject("buttonReset.Image");
            buttonReset.Location = new Point(28, 2);
            buttonReset.Margin = new Padding(2);
            buttonReset.Name = "buttonReset";
            buttonReset.Padding = new Padding(0, 0, 1, 1);
            buttonReset.Size = new Size(20, 20);
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
            dateTimePickerEnd.Location = new Point(423, 46);
            dateTimePickerEnd.Margin = new Padding(2);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(76, 20);
            dateTimePickerEnd.TabIndex = 23;
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDepartment.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(181, 46);
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
            comboBoxManagement.Location = new Point(21, 46);
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
            dateTimePickerStart.Location = new Point(345, 46);
            dateTimePickerStart.Margin = new Padding(2);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(74, 20);
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
            dbGrid.ColumnHeadersVisible = false;
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
            dbGrid.Location = new Point(21, 79);
            dbGrid.Margin = new Padding(2);
            dbGrid.Name = "dbGrid";
            dbGrid.ReadOnly = true;
            dbGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(46, 52, 63);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dbGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dbGrid.RowHeadersVisible = false;
            dbGrid.RowHeadersWidth = 62;
            dbGrid.RowTemplate.Height = 33;
            dbGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dbGrid.Size = new Size(1236, 558);
            dbGrid.TabIndex = 17;
            dbGrid.CellBeginEdit += dbGrid_CellBeginEdit;
            dbGrid.CellEndEdit += dbGrid_CellEndEdit;
            dbGrid.CellMouseMove += dbGrid_CellMouseMove;
            dbGrid.ColumnAdded += dbGrid_ColumnAdded;
            // 
            // labelManagement
            // 
            labelManagement.AutoSize = true;
            labelManagement.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelManagement.Location = new Point(21, 32);
            labelManagement.Margin = new Padding(2, 0, 2, 0);
            labelManagement.Name = "labelManagement";
            labelManagement.Size = new Size(65, 12);
            labelManagement.TabIndex = 27;
            labelManagement.Text = "Management";
            // 
            // labelDepartment
            // 
            labelDepartment.AutoSize = true;
            labelDepartment.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelDepartment.Location = new Point(181, 32);
            labelDepartment.Margin = new Padding(2, 0, 2, 0);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new Size(59, 12);
            labelDepartment.TabIndex = 28;
            labelDepartment.Text = "Department";
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelStartDate.Location = new Point(343, 32);
            labelStartDate.Margin = new Padding(2, 0, 2, 0);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(50, 12);
            labelStartDate.TabIndex = 30;
            labelStartDate.Text = "Start Date";
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelEndDate.Location = new Point(423, 32);
            labelEndDate.Margin = new Padding(2, 0, 2, 0);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(46, 12);
            labelEndDate.TabIndex = 31;
            labelEndDate.Text = "End Date";
            // 
            // buttonNew
            // 
            buttonNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonNew.BackColor = Color.Transparent;
            buttonNew.Cursor = Cursors.Hand;
            buttonNew.Enabled = false;
            buttonNew.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonNew.FlatAppearance.BorderSize = 0;
            buttonNew.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonNew.FlatStyle = FlatStyle.Flat;
            buttonNew.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNew.ForeColor = Color.White;
            buttonNew.Image = (Image)resources.GetObject("buttonNew.Image");
            buttonNew.Location = new Point(3, 2);
            buttonNew.Margin = new Padding(2);
            buttonNew.Name = "buttonNew";
            buttonNew.Padding = new Padding(0, 0, 1, 1);
            buttonNew.Size = new Size(20, 20);
            buttonNew.TabIndex = 32;
            buttonNew.UseVisualStyleBackColor = false;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonExportToExcel
            // 
            buttonExportToExcel.BackColor = Color.Transparent;
            buttonExportToExcel.Cursor = Cursors.Hand;
            buttonExportToExcel.Enabled = false;
            buttonExportToExcel.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonExportToExcel.FlatAppearance.BorderSize = 0;
            buttonExportToExcel.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonExportToExcel.FlatStyle = FlatStyle.Flat;
            buttonExportToExcel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExportToExcel.Image = (Image)resources.GetObject("buttonExportToExcel.Image");
            buttonExportToExcel.Location = new Point(124, 2);
            buttonExportToExcel.Margin = new Padding(2);
            buttonExportToExcel.Name = "buttonExportToExcel";
            buttonExportToExcel.Padding = new Padding(0, 0, 1, 1);
            buttonExportToExcel.Size = new Size(20, 20);
            buttonExportToExcel.TabIndex = 35;
            buttonExportToExcel.UseVisualStyleBackColor = false;
            buttonExportToExcel.Click += buttonExportToExcel_Click;
            // 
            // buttonList
            // 
            buttonList.BackColor = Color.Transparent;
            buttonList.Cursor = Cursors.Hand;
            buttonList.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonList.FlatAppearance.BorderSize = 0;
            buttonList.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonList.FlatStyle = FlatStyle.Flat;
            buttonList.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonList.Image = (Image)resources.GetObject("buttonList.Image");
            buttonList.Location = new Point(4, 2);
            buttonList.Margin = new Padding(2);
            buttonList.Name = "buttonList";
            buttonList.Padding = new Padding(0, 0, 1, 1);
            buttonList.Size = new Size(20, 20);
            buttonList.TabIndex = 36;
            buttonList.UseVisualStyleBackColor = false;
            buttonList.Click += buttonList_Click;
            // 
            // buttonChart
            // 
            buttonChart.BackColor = Color.Transparent;
            buttonChart.Cursor = Cursors.Hand;
            buttonChart.Enabled = false;
            buttonChart.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonChart.FlatAppearance.BorderSize = 0;
            buttonChart.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonChart.FlatStyle = FlatStyle.Flat;
            buttonChart.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonChart.Image = (Image)resources.GetObject("buttonChart.Image");
            buttonChart.Location = new Point(100, 2);
            buttonChart.Margin = new Padding(2);
            buttonChart.Name = "buttonChart";
            buttonChart.Padding = new Padding(0, 0, 1, 1);
            buttonChart.Size = new Size(20, 20);
            buttonChart.TabIndex = 39;
            buttonChart.UseVisualStyleBackColor = false;
            buttonChart.Click += buttonChart_Click;
            // 
            // buttonCard
            // 
            buttonCard.BackColor = Color.Transparent;
            buttonCard.Cursor = Cursors.Hand;
            buttonCard.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonCard.FlatAppearance.BorderSize = 0;
            buttonCard.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonCard.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonCard.FlatStyle = FlatStyle.Flat;
            buttonCard.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCard.Image = (Image)resources.GetObject("buttonCard.Image");
            buttonCard.Location = new Point(1238, 79);
            buttonCard.Margin = new Padding(2);
            buttonCard.Name = "buttonCard";
            buttonCard.Padding = new Padding(0, 0, 1, 0);
            buttonCard.Size = new Size(20, 16);
            buttonCard.TabIndex = 40;
            buttonCard.UseVisualStyleBackColor = false;
            buttonCard.Click += buttonCard_Click;
            // 
            // buttonShowHide
            // 
            buttonShowHide.BackColor = Color.Transparent;
            buttonShowHide.Cursor = Cursors.Hand;
            buttonShowHide.Enabled = false;
            buttonShowHide.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonShowHide.FlatAppearance.BorderSize = 0;
            buttonShowHide.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonShowHide.FlatStyle = FlatStyle.Flat;
            buttonShowHide.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonShowHide.ForeColor = Color.White;
            buttonShowHide.Image = (Image)resources.GetObject("buttonShowHide.Image");
            buttonShowHide.Location = new Point(52, 2);
            buttonShowHide.Margin = new Padding(2);
            buttonShowHide.Name = "buttonShowHide";
            buttonShowHide.Padding = new Padding(0, 0, 1, 1);
            buttonShowHide.Size = new Size(20, 20);
            buttonShowHide.TabIndex = 41;
            buttonShowHide.UseVisualStyleBackColor = false;
            buttonShowHide.Click += buttonShowHide_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(buttonShowHide);
            panel1.Controls.Add(buttonChart);
            panel1.Controls.Add(buttonReset);
            panel1.Controls.Add(buttonList);
            panel1.Controls.Add(buttonExportToExcel);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(1044, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 23);
            panel1.TabIndex = 42;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(buttonEdit);
            panel2.Controls.Add(buttonNew);
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(1208, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(49, 23);
            panel2.TabIndex = 42;
            // 
            // pictureBoxLocked
            // 
            pictureBoxLocked.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxLocked.BackColor = Color.Transparent;
            pictureBoxLocked.Image = (Image)resources.GetObject("pictureBoxLocked.Image");
            pictureBoxLocked.Location = new Point(1238, 638);
            pictureBoxLocked.Name = "pictureBoxLocked";
            pictureBoxLocked.Padding = new Padding(2, 2, 0, 0);
            pictureBoxLocked.Size = new Size(20, 20);
            pictureBoxLocked.TabIndex = 43;
            pictureBoxLocked.TabStop = false;
            // 
            // pictureBoxUnlocked
            // 
            pictureBoxUnlocked.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxUnlocked.BackColor = Color.Transparent;
            pictureBoxUnlocked.Image = (Image)resources.GetObject("pictureBoxUnlocked.Image");
            pictureBoxUnlocked.Location = new Point(1238, 638);
            pictureBoxUnlocked.Name = "pictureBoxUnlocked";
            pictureBoxUnlocked.Padding = new Padding(2, 2, 0, 0);
            pictureBoxUnlocked.Size = new Size(20, 20);
            pictureBoxUnlocked.TabIndex = 44;
            pictureBoxUnlocked.TabStop = false;
            pictureBoxUnlocked.Visible = false;
            // 
            // labelLockStatus
            // 
            labelLockStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelLockStatus.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            labelLockStatus.Location = new Point(1098, 643);
            labelLockStatus.Name = "labelLockStatus";
            labelLockStatus.Size = new Size(140, 12);
            labelLockStatus.TabIndex = 45;
            labelLockStatus.Text = "Data editing is locked";
            labelLockStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DataGridForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1280, 660);
            Controls.Add(labelLockStatus);
            Controls.Add(pictureBoxUnlocked);
            Controls.Add(pictureBoxLocked);
            Controls.Add(buttonCard);
            Controls.Add(labelEndDate);
            Controls.Add(labelStartDate);
            Controls.Add(labelDepartment);
            Controls.Add(labelManagement);
            Controls.Add(comboBoxManagement);
            Controls.Add(comboBoxDepartment);
            Controls.Add(dateTimePickerStart);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dbGrid);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "DataGridForm";
            Text = "DataGridForm";
            Load += DataGridForm_Load;
            ((System.ComponentModel.ISupportInitialize)dbGrid).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLocked).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUnlocked).EndInit();
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
        private Label labelManagement;
        private Label labelDepartment;
        private Label labelStartDate;
        private Label labelEndDate;
        private Button buttonNew;
        private Button buttonExportToExcel;
        private Button buttonList;
        private Button buttonChart;
        private Button buttonCard;
        private Button buttonShowHide;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBoxLocked;
        private PictureBox pictureBoxUnlocked;
        private Label labelLockStatus;
    }
}