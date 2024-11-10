namespace DashboardUI
{
    partial class UpdateDepartmentForm
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
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonCancel = new Button();
            buttonUpdate = new Button();
            comboBoxManagement = new ComboBox();
            textBoxDepartment = new TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(100, 50);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(160, 19);
            label7.TabIndex = 29;
            label7.Text = "UPDATE DEPARTMENT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(50, 143);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 24;
            label2.Text = "Department Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(50, 93);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 23;
            label1.Text = "Management";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(197, 224);
            buttonCancel.Margin = new Padding(2, 2, 2, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(113, 32);
            buttonCancel.TabIndex = 22;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(58, 154, 193);
            buttonUpdate.FlatAppearance.BorderColor = Color.FromArgb(58, 154, 193);
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.ForeColor = SystemColors.ButtonHighlight;
            buttonUpdate.Location = new Point(50, 224);
            buttonUpdate.Margin = new Padding(2, 2, 2, 2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(113, 32);
            buttonUpdate.TabIndex = 21;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // comboBoxManagement
            // 
            comboBoxManagement.FormattingEnabled = true;
            comboBoxManagement.Location = new Point(50, 110);
            comboBoxManagement.Margin = new Padding(2, 2, 2, 2);
            comboBoxManagement.Name = "comboBoxManagement";
            comboBoxManagement.Size = new Size(260, 23);
            comboBoxManagement.TabIndex = 16;
            // 
            // textBoxDepartment
            // 
            textBoxDepartment.Location = new Point(50, 160);
            textBoxDepartment.Margin = new Padding(2, 2, 2, 2);
            textBoxDepartment.Name = "textBoxDepartment";
            textBoxDepartment.Size = new Size(260, 23);
            textBoxDepartment.TabIndex = 15;
            // 
            // UpdateDepartmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 300);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonUpdate);
            Controls.Add(comboBoxManagement);
            Controls.Add(textBoxDepartment);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "UpdateDepartmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Department";
            Load += UpdateDepartmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label2;
        private Label label1;
        private Button buttonCancel;
        private Button buttonUpdate;
        private ComboBox comboBoxManagement;
        private TextBox textBoxDepartment;
    }
}