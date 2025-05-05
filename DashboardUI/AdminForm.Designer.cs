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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            textBoxPath = new TextBox();
            buttonBrowse = new Button();
            labelDatabase = new Label();
            buttonManagement = new Button();
            buttonDepartment = new Button();
            buttonCategory = new Button();
            buttonUser = new Button();
            panel2 = new Panel();
            adminDataGrid = new DataGridView();
            buttonDelete = new Button();
            buttonCreate = new Button();
            buttonEdit = new Button();
            buttonProject = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adminDataGrid).BeginInit();
            SuspendLayout();
            // 
            // textBoxPath
            // 
            textBoxPath.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPath.Location = new Point(11, 23);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Size = new Size(421, 20);
            textBoxPath.TabIndex = 35;
            // 
            // buttonBrowse
            // 
            buttonBrowse.BackColor = Color.Transparent;
            buttonBrowse.FlatAppearance.BorderColor = Color.FromArgb(58, 154, 193);
            buttonBrowse.FlatAppearance.BorderSize = 0;
            buttonBrowse.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonBrowse.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonBrowse.FlatStyle = FlatStyle.Flat;
            buttonBrowse.ForeColor = SystemColors.ControlLightLight;
            buttonBrowse.Image = (Image)resources.GetObject("buttonBrowse.Image");
            buttonBrowse.Location = new Point(437, 23);
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
            labelDatabase.Font = new Font("Calibri", 7F, FontStyle.Bold, GraphicsUnit.Point);
            labelDatabase.Location = new Point(11, 8);
            labelDatabase.Margin = new Padding(2, 0, 2, 0);
            labelDatabase.Name = "labelDatabase";
            labelDatabase.Size = new Size(72, 13);
            labelDatabase.TabIndex = 40;
            labelDatabase.Text = "DATABASE PATH";
            // 
            // buttonManagement
            // 
            buttonManagement.BackColor = Color.Transparent;
            buttonManagement.Cursor = Cursors.Hand;
            buttonManagement.FlatAppearance.BorderColor = Color.FromArgb(52, 73, 94);
            buttonManagement.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonManagement.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonManagement.FlatStyle = FlatStyle.Flat;
            buttonManagement.Font = new Font("Calibri", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonManagement.ForeColor = Color.FromArgb(46, 52, 63);
            buttonManagement.Image = (Image)resources.GetObject("buttonManagement.Image");
            buttonManagement.ImageAlign = ContentAlignment.TopCenter;
            buttonManagement.Location = new Point(70, 11);
            buttonManagement.Margin = new Padding(2);
            buttonManagement.Name = "buttonManagement";
            buttonManagement.Padding = new Padding(0, 10, 0, 15);
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
            buttonDepartment.FlatAppearance.BorderColor = Color.FromArgb(52, 73, 94);
            buttonDepartment.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonDepartment.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonDepartment.FlatStyle = FlatStyle.Flat;
            buttonDepartment.Font = new Font("Calibri", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDepartment.ForeColor = Color.FromArgb(46, 52, 63);
            buttonDepartment.Image = (Image)resources.GetObject("buttonDepartment.Image");
            buttonDepartment.ImageAlign = ContentAlignment.TopCenter;
            buttonDepartment.Location = new Point(148, 10);
            buttonDepartment.Margin = new Padding(2);
            buttonDepartment.Name = "buttonDepartment";
            buttonDepartment.Padding = new Padding(0, 10, 0, 15);
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
            buttonCategory.FlatAppearance.BorderColor = Color.FromArgb(52, 73, 94);
            buttonCategory.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonCategory.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonCategory.FlatStyle = FlatStyle.Flat;
            buttonCategory.Font = new Font("Calibri", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCategory.ForeColor = Color.FromArgb(46, 52, 63);
            buttonCategory.Image = (Image)resources.GetObject("buttonCategory.Image");
            buttonCategory.ImageAlign = ContentAlignment.TopCenter;
            buttonCategory.Location = new Point(304, 11);
            buttonCategory.Margin = new Padding(2);
            buttonCategory.Name = "buttonCategory";
            buttonCategory.Padding = new Padding(0, 10, 0, 15);
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
            buttonUser.FlatAppearance.BorderColor = Color.FromArgb(52, 73, 94);
            buttonUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonUser.FlatStyle = FlatStyle.Flat;
            buttonUser.Font = new Font("Calibri", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUser.ForeColor = Color.FromArgb(46, 52, 63);
            buttonUser.Image = (Image)resources.GetObject("buttonUser.Image");
            buttonUser.ImageAlign = ContentAlignment.TopCenter;
            buttonUser.Location = new Point(382, 11);
            buttonUser.Margin = new Padding(2);
            buttonUser.Name = "buttonUser";
            buttonUser.Padding = new Padding(0, 10, 0, 15);
            buttonUser.Size = new Size(72, 87);
            buttonUser.TabIndex = 50;
            buttonUser.Text = "USER";
            buttonUser.TextAlign = ContentAlignment.BottomCenter;
            buttonUser.UseVisualStyleBackColor = false;
            buttonUser.Click += buttonUser_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBoxPath);
            panel2.Controls.Add(labelDatabase);
            panel2.Controls.Add(buttonBrowse);
            panel2.ForeColor = Color.FromArgb(46, 52, 63);
            panel2.Location = new Point(735, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(475, 56);
            panel2.TabIndex = 52;
            // 
            // adminDataGrid
            // 
            adminDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            adminDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            adminDataGrid.BackgroundColor = SystemColors.ButtonHighlight;
            adminDataGrid.BorderStyle = BorderStyle.None;
            adminDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(169, 204, 227);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            adminDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            adminDataGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(169, 204, 227);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            adminDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            adminDataGrid.EnableHeadersVisualStyles = false;
            adminDataGrid.GridColor = Color.FromArgb(52, 73, 94);
            adminDataGrid.Location = new Point(70, 113);
            adminDataGrid.Margin = new Padding(2);
            adminDataGrid.Name = "adminDataGrid";
            adminDataGrid.ReadOnly = true;
            adminDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            adminDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(169, 204, 227);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            adminDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            adminDataGrid.RowTemplate.Height = 25;
            adminDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            adminDataGrid.Size = new Size(1140, 527);
            adminDataGrid.TabIndex = 55;
            adminDataGrid.CellClick += adminDataGrid_CellClick;
            adminDataGrid.CellMouseMove += adminDataGrid_CellMouseMove;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Transparent;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.Location = new Point(22, 137);
            buttonDelete.Margin = new Padding(2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Padding = new Padding(0, 0, 1, 1);
            buttonDelete.Size = new Size(20, 20);
            buttonDelete.TabIndex = 57;
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Visible = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.Transparent;
            buttonCreate.Cursor = Cursors.Hand;
            buttonCreate.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonCreate.FlatAppearance.BorderSize = 0;
            buttonCreate.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonCreate.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreate.ForeColor = Color.White;
            buttonCreate.Image = (Image)resources.GetObject("buttonCreate.Image");
            buttonCreate.Location = new Point(46, 113);
            buttonCreate.Margin = new Padding(2);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Padding = new Padding(0, 0, 1, 1);
            buttonCreate.Size = new Size(20, 20);
            buttonCreate.TabIndex = 56;
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Visible = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.Transparent;
            buttonEdit.Cursor = Cursors.Hand;
            buttonEdit.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Image = (Image)resources.GetObject("buttonEdit.Image");
            buttonEdit.Location = new Point(46, 137);
            buttonEdit.Margin = new Padding(2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Padding = new Padding(0, 0, 1, 1);
            buttonEdit.Size = new Size(20, 20);
            buttonEdit.TabIndex = 58;
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Visible = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonProject
            // 
            buttonProject.BackColor = Color.Transparent;
            buttonProject.Cursor = Cursors.Hand;
            buttonProject.FlatAppearance.BorderColor = Color.FromArgb(52, 73, 94);
            buttonProject.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonProject.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonProject.FlatStyle = FlatStyle.Flat;
            buttonProject.Font = new Font("Calibri", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProject.ForeColor = Color.FromArgb(46, 52, 63);
            buttonProject.Image = (Image)resources.GetObject("buttonProject.Image");
            buttonProject.ImageAlign = ContentAlignment.TopCenter;
            buttonProject.Location = new Point(226, 11);
            buttonProject.Margin = new Padding(2);
            buttonProject.Name = "buttonProject";
            buttonProject.Padding = new Padding(0, 10, 0, 15);
            buttonProject.Size = new Size(72, 87);
            buttonProject.TabIndex = 59;
            buttonProject.Text = "PROJECT";
            buttonProject.TextAlign = ContentAlignment.BottomCenter;
            buttonProject.UseVisualStyleBackColor = false;
            buttonProject.Click += buttonProject_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1280, 660);
            Controls.Add(buttonProject);
            Controls.Add(buttonEdit);
            Controls.Add(adminDataGrid);
            Controls.Add(buttonDelete);
            Controls.Add(buttonCreate);
            Controls.Add(panel2);
            Controls.Add(buttonUser);
            Controls.Add(buttonCategory);
            Controls.Add(buttonDepartment);
            Controls.Add(buttonManagement);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)adminDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBoxPath;
        private Button buttonBrowse;
        private Label labelDatabase;
        private Button buttonManagement;
        private Button buttonDepartment;
        private Button buttonCategory;
        private Button buttonUser;
        private Panel panel2;
        private DataGridView adminDataGrid;
        private Button buttonDelete;
        private Button buttonCreate;
        private Button buttonEdit;
        private Button buttonProject;
    }
}