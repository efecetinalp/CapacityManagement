namespace DashboardUI
{
    partial class CreateForm
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
            panel1 = new Panel();
            panel4 = new Panel();
            buttonManagement = new Button();
            panel2 = new Panel();
            buttonProject = new Button();
            panel3 = new Panel();
            buttonCategory = new Button();
            panel5 = new Panel();
            buttonDepartment = new Button();
            buttonCancel = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 52, 63);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 450);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(buttonManagement);
            panel4.Location = new Point(0, 334);
            panel4.Margin = new Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(205, 89);
            panel4.TabIndex = 5;
            // 
            // buttonManagement
            // 
            buttonManagement.BackColor = Color.FromArgb(46, 52, 63);
            buttonManagement.FlatStyle = FlatStyle.Flat;
            buttonManagement.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonManagement.ForeColor = Color.White;
            buttonManagement.Location = new Point(-10, -10);
            buttonManagement.Margin = new Padding(2, 2, 2, 2);
            buttonManagement.Name = "buttonManagement";
            buttonManagement.Size = new Size(171, 110);
            buttonManagement.TabIndex = 1;
            buttonManagement.Text = "New Management";
            buttonManagement.UseVisualStyleBackColor = false;
            buttonManagement.Click += buttonManagement_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonProject);
            panel2.Location = new Point(0, 25);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(205, 89);
            panel2.TabIndex = 2;
            // 
            // buttonProject
            // 
            buttonProject.BackColor = Color.FromArgb(46, 52, 63);
            buttonProject.FlatStyle = FlatStyle.Flat;
            buttonProject.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonProject.ForeColor = Color.White;
            buttonProject.Location = new Point(-10, -11);
            buttonProject.Margin = new Padding(2, 2, 2, 2);
            buttonProject.Name = "buttonProject";
            buttonProject.Size = new Size(171, 110);
            buttonProject.TabIndex = 1;
            buttonProject.Text = "New Project";
            buttonProject.UseVisualStyleBackColor = false;
            buttonProject.Click += buttonProject_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonCategory);
            panel3.Location = new Point(0, 128);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(205, 89);
            panel3.TabIndex = 3;
            // 
            // buttonCategory
            // 
            buttonCategory.BackColor = Color.FromArgb(46, 52, 63);
            buttonCategory.FlatStyle = FlatStyle.Flat;
            buttonCategory.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonCategory.ForeColor = Color.White;
            buttonCategory.Location = new Point(-10, -11);
            buttonCategory.Margin = new Padding(2, 2, 2, 2);
            buttonCategory.Name = "buttonCategory";
            buttonCategory.Size = new Size(171, 110);
            buttonCategory.TabIndex = 1;
            buttonCategory.Text = "New Category";
            buttonCategory.UseVisualStyleBackColor = false;
            buttonCategory.Click += buttonCategory_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(buttonDepartment);
            panel5.Location = new Point(0, 231);
            panel5.Margin = new Padding(2, 2, 2, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(205, 89);
            panel5.TabIndex = 4;
            // 
            // buttonDepartment
            // 
            buttonDepartment.BackColor = Color.FromArgb(46, 52, 63);
            buttonDepartment.FlatStyle = FlatStyle.Flat;
            buttonDepartment.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonDepartment.ForeColor = Color.White;
            buttonDepartment.Location = new Point(-10, -10);
            buttonDepartment.Margin = new Padding(2, 2, 2, 2);
            buttonDepartment.Name = "buttonDepartment";
            buttonDepartment.Size = new Size(171, 110);
            buttonDepartment.TabIndex = 1;
            buttonDepartment.Text = "New Department";
            buttonDepartment.UseVisualStyleBackColor = false;
            buttonDepartment.Click += buttonDepartment_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonCancel.Location = new Point(230, 400);
            buttonCancel.Margin = new Padding(2, 2, 2, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(200, 32);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 450);
            Controls.Add(buttonCancel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Margin = new Padding(2, 2, 2, 2);
            MinimumSize = new Size(500, 450);
            Name = "CreateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateForm";
            Load += CreateForm_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Button buttonManagement;
        private Panel panel2;
        private Button buttonProject;
        private Panel panel3;
        private Button buttonCategory;
        private Panel panel5;
        private Button buttonDepartment;
        private Button buttonCancel;
    }
}