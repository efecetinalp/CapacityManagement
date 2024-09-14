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
            this.lblProjectCreate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreate2 = new System.Windows.Forms.Button();
            this.buttonCreate3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxManagement = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
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
            this.buttonCreate.Size = new System.Drawing.Size(322, 41);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Create Project";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(446, 580);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(322, 41);
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
            // lblProjectCreate
            // 
            this.lblProjectCreate.AutoSize = true;
            this.lblProjectCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProjectCreate.Location = new System.Drawing.Point(161, 45);
            this.lblProjectCreate.Name = "lblProjectCreate";
            this.lblProjectCreate.Size = new System.Drawing.Size(132, 25);
            this.lblProjectCreate.TabIndex = 10;
            this.lblProjectCreate.Text = "Create Project";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(533, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Create Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(523, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Create Management";
            // 
            // buttonCreate2
            // 
            this.buttonCreate2.Location = new System.Drawing.Point(446, 207);
            this.buttonCreate2.Name = "buttonCreate2";
            this.buttonCreate2.Size = new System.Drawing.Size(322, 41);
            this.buttonCreate2.TabIndex = 13;
            this.buttonCreate2.Text = "Create Department";
            this.buttonCreate2.UseVisualStyleBackColor = true;
            this.buttonCreate2.Click += new System.EventHandler(this.buttonCreate2_Click);
            // 
            // buttonCreate3
            // 
            this.buttonCreate3.Location = new System.Drawing.Point(446, 479);
            this.buttonCreate3.Name = "buttonCreate3";
            this.buttonCreate3.Size = new System.Drawing.Size(322, 41);
            this.buttonCreate3.TabIndex = 14;
            this.buttonCreate3.Text = "Create Management";
            this.buttonCreate3.UseVisualStyleBackColor = true;
            this.buttonCreate3.Click += new System.EventHandler(this.buttonCreate3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Management";
            // 
            // textBoxManagement
            // 
            this.textBoxManagement.Location = new System.Drawing.Point(446, 379);
            this.textBoxManagement.Name = "textBoxManagement";
            this.textBoxManagement.Size = new System.Drawing.Size(322, 31);
            this.textBoxManagement.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Department";
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Location = new System.Drawing.Point(446, 118);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(322, 31);
            this.textBoxDepartment.TabIndex = 17;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 680);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxManagement);
            this.Controls.Add(this.buttonCreate3);
            this.Controls.Add(this.buttonCreate2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProjectCreate);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private Label lblProjectCreate;
        private Label label1;
        private Label label2;
        private Button buttonCreate2;
        private Button buttonCreate3;
        private Label label3;
        private TextBox textBoxManagement;
        private Label label4;
        private TextBox textBoxDepartment;
    }
}