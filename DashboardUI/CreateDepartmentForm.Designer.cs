namespace DashboardUI
{
    partial class CreateDepartmentForm
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
            label4 = new Label();
            textBoxDepartment = new TextBox();
            buttonCreate = new Button();
            label1 = new Label();
            lblManagement = new Label();
            comboBoxManagement = new ComboBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(42, 142);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 43;
            label4.Text = "Department";
            // 
            // textBoxDepartment
            // 
            textBoxDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDepartment.Location = new Point(40, 160);
            textBoxDepartment.Margin = new Padding(2);
            textBoxDepartment.Name = "textBoxDepartment";
            textBoxDepartment.Size = new Size(260, 23);
            textBoxDepartment.TabIndex = 42;
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonCreate.BackColor = Color.FromArgb(58, 154, 193);
            buttonCreate.FlatAppearance.BorderColor = Color.FromArgb(58, 154, 193);
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.ForeColor = SystemColors.ControlLightLight;
            buttonCreate.Location = new Point(70, 350);
            buttonCreate.Margin = new Padding(2);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(200, 32);
            buttonCreate.TabIndex = 41;
            buttonCreate.Text = "Create Department";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(122, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 19);
            label1.TabIndex = 40;
            label1.Text = "DEPARTMENT";
            // 
            // lblManagement
            // 
            lblManagement.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblManagement.AutoSize = true;
            lblManagement.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblManagement.Location = new Point(39, 91);
            lblManagement.Margin = new Padding(2, 0, 2, 0);
            lblManagement.Name = "lblManagement";
            lblManagement.Size = new Size(79, 15);
            lblManagement.TabIndex = 39;
            lblManagement.Text = "Management";
            // 
            // comboBoxManagement
            // 
            comboBoxManagement.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxManagement.FormattingEnabled = true;
            comboBoxManagement.Location = new Point(40, 110);
            comboBoxManagement.Margin = new Padding(2);
            comboBoxManagement.Name = "comboBoxManagement";
            comboBoxManagement.Size = new Size(260, 23);
            comboBoxManagement.TabIndex = 38;
            // 
            // CreateDepartmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 450);
            Controls.Add(label4);
            Controls.Add(textBoxDepartment);
            Controls.Add(buttonCreate);
            Controls.Add(label1);
            Controls.Add(lblManagement);
            Controls.Add(comboBoxManagement);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "CreateDepartmentForm";
            Text = "CreateDepartmentForm";
            Load += CreateDepartmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBoxDepartment;
        private Button buttonCreate;
        private Label label1;
        private Label lblManagement;
        private ComboBox comboBoxManagement;
    }
}