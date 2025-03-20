namespace DashboardUI
{
    partial class AdminForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            adminDataGrid = new DataGridView();
            textBoxPath = new TextBox();
            buttonBrowse = new Button();
            labelDatabase = new Label();
            buttonManagement = new Button();
            buttonDepartment = new Button();
            buttonCategory = new Button();
            buttonUser = new Button();
            buttonNew = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)adminDataGrid).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // adminDataGrid
            // 
            adminDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            adminDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            adminDataGrid.BackgroundColor = SystemColors.ButtonHighlight;
            adminDataGrid.BorderStyle = BorderStyle.None;
            adminDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            adminDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            adminDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.AliceBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            adminDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            adminDataGrid.Location = new Point(22, 114);
            adminDataGrid.Margin = new Padding(2);
            adminDataGrid.Name = "adminDataGrid";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            adminDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            adminDataGrid.RowHeadersVisible = false;
            adminDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            adminDataGrid.RowTemplate.Height = 25;
            adminDataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            adminDataGrid.Size = new Size(1233, 524);
            adminDataGrid.TabIndex = 0;
            adminDataGrid.CellBeginEdit += userDataGrid_CellBeginEdit;
            adminDataGrid.CellContentClick += userDataGrid_CellContentClick;
            adminDataGrid.CellEndEdit += userDataGrid_CellEndEdit;
            // 
            // textBoxPath
            // 
            textBoxPath.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPath.Location = new Point(11, 23);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Size = new Size(270, 20);
            textBoxPath.TabIndex = 35;
            // 
            // buttonBrowse
            // 
            buttonBrowse.BackColor = Color.Transparent;
            buttonBrowse.FlatAppearance.BorderColor = Color.FromArgb(58, 154, 193);
            buttonBrowse.FlatAppearance.BorderSize = 0;
            buttonBrowse.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonBrowse.FlatStyle = FlatStyle.Flat;
            buttonBrowse.ForeColor = SystemColors.ControlLightLight;
            buttonBrowse.Image = (Image)resources.GetObject("buttonBrowse.Image");
            buttonBrowse.Location = new Point(289, 23);
            buttonBrowse.Margin = new Padding(2);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Padding = new Padding(0, 0, 1, 1);
            buttonBrowse.Size = new Size(20, 20);
            buttonBrowse.TabIndex = 38;
            buttonBrowse.UseVisualStyleBackColor = false;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // labelDatabase
            // 
            labelDatabase.AutoSize = true;
            labelDatabase.Font = new Font("Segoe UI Semibold", 6.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelDatabase.Location = new Point(11, 8);
            labelDatabase.Margin = new Padding(2, 0, 2, 0);
            labelDatabase.Name = "labelDatabase";
            labelDatabase.Size = new Size(64, 12);
            labelDatabase.TabIndex = 40;
            labelDatabase.Text = "Database Path";
            // 
            // buttonManagement
            // 
            buttonManagement.BackColor = Color.Transparent;
            buttonManagement.Cursor = Cursors.Hand;
            buttonManagement.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            buttonManagement.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonManagement.FlatStyle = FlatStyle.Flat;
            buttonManagement.Font = new Font("Calibri", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonManagement.ForeColor = Color.Black;
            buttonManagement.Image = (Image)resources.GetObject("buttonManagement.Image");
            buttonManagement.ImageAlign = ContentAlignment.TopCenter;
            buttonManagement.Location = new Point(22, 12);
            buttonManagement.Margin = new Padding(2);
            buttonManagement.Name = "buttonManagement";
            buttonManagement.Padding = new Padding(0, 15, 0, 15);
            buttonManagement.Size = new Size(72, 87);
            buttonManagement.TabIndex = 47;
            buttonManagement.Text = "MANAGEMENT";
            buttonManagement.TextAlign = ContentAlignment.BottomCenter;
            buttonManagement.UseVisualStyleBackColor = false;
            buttonManagement.Click += buttonManagement_Click;
            // 
            // buttonDepartment
            // 
            buttonDepartment.BackColor = Color.Transparent;
            buttonDepartment.Cursor = Cursors.Hand;
            buttonDepartment.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            buttonDepartment.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonDepartment.FlatStyle = FlatStyle.Flat;
            buttonDepartment.Font = new Font("Calibri", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDepartment.ForeColor = Color.Black;
            buttonDepartment.Image = (Image)resources.GetObject("buttonDepartment.Image");
            buttonDepartment.ImageAlign = ContentAlignment.TopCenter;
            buttonDepartment.Location = new Point(98, 12);
            buttonDepartment.Margin = new Padding(2);
            buttonDepartment.Name = "buttonDepartment";
            buttonDepartment.Padding = new Padding(0, 15, 0, 15);
            buttonDepartment.Size = new Size(72, 87);
            buttonDepartment.TabIndex = 48;
            buttonDepartment.Text = "DEPARTMENT";
            buttonDepartment.TextAlign = ContentAlignment.BottomCenter;
            buttonDepartment.UseVisualStyleBackColor = false;
            buttonDepartment.Click += buttonDepartment_Click;
            // 
            // buttonCategory
            // 
            buttonCategory.BackColor = Color.Transparent;
            buttonCategory.Cursor = Cursors.Hand;
            buttonCategory.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            buttonCategory.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonCategory.FlatStyle = FlatStyle.Flat;
            buttonCategory.Font = new Font("Calibri", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCategory.ForeColor = Color.Black;
            buttonCategory.Image = (Image)resources.GetObject("buttonCategory.Image");
            buttonCategory.ImageAlign = ContentAlignment.TopCenter;
            buttonCategory.Location = new Point(174, 12);
            buttonCategory.Margin = new Padding(2);
            buttonCategory.Name = "buttonCategory";
            buttonCategory.Padding = new Padding(0, 15, 0, 15);
            buttonCategory.Size = new Size(72, 87);
            buttonCategory.TabIndex = 49;
            buttonCategory.Text = "CATEGORY";
            buttonCategory.TextAlign = ContentAlignment.BottomCenter;
            buttonCategory.UseVisualStyleBackColor = false;
            buttonCategory.Click += buttonCategory_Click;
            // 
            // buttonUser
            // 
            buttonUser.BackColor = Color.Transparent;
            buttonUser.Cursor = Cursors.Hand;
            buttonUser.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            buttonUser.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonUser.FlatStyle = FlatStyle.Flat;
            buttonUser.Font = new Font("Calibri", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUser.ForeColor = Color.Black;
            buttonUser.Image = (Image)resources.GetObject("buttonUser.Image");
            buttonUser.ImageAlign = ContentAlignment.TopCenter;
            buttonUser.Location = new Point(250, 12);
            buttonUser.Margin = new Padding(2);
            buttonUser.Name = "buttonUser";
            buttonUser.Padding = new Padding(0, 15, 0, 15);
            buttonUser.Size = new Size(72, 87);
            buttonUser.TabIndex = 50;
            buttonUser.Text = "USER";
            buttonUser.TextAlign = ContentAlignment.BottomCenter;
            buttonUser.UseVisualStyleBackColor = false;
            buttonUser.Click += buttonUser_Click;
            // 
            // buttonNew
            // 
            buttonNew.BackColor = Color.Transparent;
            buttonNew.Cursor = Cursors.Hand;
            buttonNew.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonNew.FlatAppearance.BorderSize = 0;
            buttonNew.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonNew.FlatStyle = FlatStyle.Flat;
            buttonNew.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNew.ForeColor = Color.White;
            buttonNew.Image = (Image)resources.GetObject("buttonNew.Image");
            buttonNew.Location = new Point(339, 78);
            buttonNew.Margin = new Padding(2);
            buttonNew.Name = "buttonNew";
            buttonNew.Padding = new Padding(0, 0, 1, 1);
            buttonNew.Size = new Size(20, 20);
            buttonNew.TabIndex = 53;
            buttonNew.UseVisualStyleBackColor = false;
            buttonNew.Click += buttonNew_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBoxPath);
            panel2.Controls.Add(labelDatabase);
            panel2.Controls.Add(buttonBrowse);
            panel2.Location = new Point(927, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 56);
            panel2.TabIndex = 52;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1280, 660);
            Controls.Add(buttonNew);
            Controls.Add(panel2);
            Controls.Add(buttonUser);
            Controls.Add(buttonCategory);
            Controls.Add(buttonDepartment);
            Controls.Add(buttonManagement);
            Controls.Add(adminDataGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)adminDataGrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView adminDataGrid;
        private TextBox textBoxPath;
        private Button buttonBrowse;
        private Label labelDatabase;
        private Button buttonManagement;
        private Button buttonDepartment;
        private Button buttonCategory;
        private Button buttonUser;
        private Panel panel2;
        private Button buttonNew;
    }
}