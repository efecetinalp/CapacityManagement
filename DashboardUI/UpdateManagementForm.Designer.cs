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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateManagementForm));
            label7 = new Label();
            label6 = new Label();
            buttonCancel = new Button();
            buttonUpdate = new Button();
            textBoxManagement = new TextBox();
            buttonQuit = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(71, 23);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(120, 15);
            label7.TabIndex = 29;
            label7.Text = "EDIT MANAGEMENT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(24, 66);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(96, 12);
            label6.TabIndex = 28;
            label6.Text = "Management Name";
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(152, 131);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(88, 25);
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
            buttonUpdate.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUpdate.ForeColor = SystemColors.ButtonHighlight;
            buttonUpdate.Location = new Point(24, 131);
            buttonUpdate.Margin = new Padding(2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(88, 25);
            buttonUpdate.TabIndex = 21;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBoxManagement
            // 
            textBoxManagement.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxManagement.Location = new Point(24, 80);
            textBoxManagement.Margin = new Padding(2);
            textBoxManagement.Name = "textBoxManagement";
            textBoxManagement.Size = new Size(216, 20);
            textBoxManagement.TabIndex = 15;
            // 
            // buttonQuit
            // 
            buttonQuit.FlatAppearance.BorderSize = 0;
            buttonQuit.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonQuit.FlatStyle = FlatStyle.Flat;
            buttonQuit.Image = (Image)resources.GetObject("buttonQuit.Image");
            buttonQuit.Location = new Point(248, 3);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Padding = new Padding(0, 0, 1, 1);
            buttonQuit.Size = new Size(12, 12);
            buttonQuit.TabIndex = 40;
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // UpdateManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 180);
            Controls.Add(buttonQuit);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(buttonCancel);
            Controls.Add(buttonUpdate);
            Controls.Add(textBoxManagement);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "UpdateManagementForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Management";
            TopMost = true;
            Load += UpdateManagementForm_Load;
            MouseDown += UpdateManagementForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Button buttonCancel;
        private Button buttonUpdate;
        private TextBox textBoxManagement;
        private Button buttonQuit;
    }
}