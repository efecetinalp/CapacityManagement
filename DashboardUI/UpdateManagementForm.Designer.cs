namespace DashboardUI
{
    partial class UpdateManagementForm
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
            label6 = new Label();
            buttonCancel = new Button();
            buttonUpdate = new Button();
            textBoxManagement = new TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(100, 50);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(166, 19);
            label7.TabIndex = 29;
            label7.Text = "UPDATE MANAGEMENT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(50, 93);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 28;
            label6.Text = "Management Name";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(197, 170);
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
            buttonUpdate.Location = new Point(50, 170);
            buttonUpdate.Margin = new Padding(2, 2, 2, 2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(113, 32);
            buttonUpdate.TabIndex = 21;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBoxManagement
            // 
            textBoxManagement.Location = new Point(50, 110);
            textBoxManagement.Margin = new Padding(2, 2, 2, 2);
            textBoxManagement.Name = "textBoxManagement";
            textBoxManagement.Size = new Size(260, 23);
            textBoxManagement.TabIndex = 15;
            // 
            // UpdateManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 250);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(buttonCancel);
            Controls.Add(buttonUpdate);
            Controls.Add(textBoxManagement);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "UpdateManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Management";
            Load += UpdateManagementForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Button buttonCancel;
        private Button buttonUpdate;
        private TextBox textBoxManagement;
    }
}