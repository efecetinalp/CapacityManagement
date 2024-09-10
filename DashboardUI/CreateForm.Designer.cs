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
            this.comboBoxManagement = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxProject = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.lblManagement = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxManagement
            // 
            this.comboBoxManagement.FormattingEnabled = true;
            this.comboBoxManagement.Location = new System.Drawing.Point(78, 116);
            this.comboBoxManagement.Name = "comboBoxManagement";
            this.comboBoxManagement.Size = new System.Drawing.Size(322, 33);
            this.comboBoxManagement.TabIndex = 0;
            this.comboBoxManagement.SelectedIndexChanged += new System.EventHandler(this.comboBoxManagement_SelectedIndexChanged);
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(78, 207);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(322, 33);
            this.comboBoxDepartment.TabIndex = 1;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(78, 293);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(322, 33);
            this.comboBoxCategory.TabIndex = 2;
            // 
            // textBoxProject
            // 
            this.textBoxProject.Location = new System.Drawing.Point(78, 379);
            this.textBoxProject.Name = "textBoxProject";
            this.textBoxProject.Size = new System.Drawing.Size(322, 31);
            this.textBoxProject.TabIndex = 3;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(78, 479);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(311, 41);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(78, 569);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(311, 41);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // lblManagement
            // 
            this.lblManagement.AutoSize = true;
            this.lblManagement.Location = new System.Drawing.Point(78, 88);
            this.lblManagement.Name = "lblManagement";
            this.lblManagement.Size = new System.Drawing.Size(117, 25);
            this.lblManagement.TabIndex = 6;
            this.lblManagement.Text = "Management";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(78, 179);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(107, 25);
            this.lblDepartment.TabIndex = 7;
            this.lblDepartment.Text = "Department";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(78, 265);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(84, 25);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(82, 351);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(66, 25);
            this.lblProject.TabIndex = 9;
            this.lblProject.Text = "Project";
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 680);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblManagement);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxProject);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.comboBoxManagement);
            this.Name = "CreateForm";
            this.Text = "CreateForm";
            this.Load += new System.EventHandler(this.CreateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxManagement;
        private ComboBox comboBoxDepartment;
        private ComboBox comboBoxCategory;
        private TextBox textBoxProject;
        private Button buttonCreate;
        private Button buttonCancel;
        private Label lblManagement;
        private Label lblDepartment;
        private Label lblCategory;
        private Label lblProject;
    }
}