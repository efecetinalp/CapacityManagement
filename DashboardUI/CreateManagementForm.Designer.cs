namespace DashboardUI
{
    partial class CreateManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateManagementForm));
            label3 = new Label();
            textBoxManagement = new TextBox();
            buttonCreate = new Button();
            label2 = new Label();
            buttonCancel = new Button();
            buttonQuit = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(21, 60);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 12);
            label3.TabIndex = 39;
            label3.Text = "Management Name";
            // 
            // textBoxManagement
            // 
            textBoxManagement.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxManagement.Location = new Point(21, 74);
            textBoxManagement.Margin = new Padding(2);
            textBoxManagement.Name = "textBoxManagement";
            textBoxManagement.Size = new Size(200, 20);
            textBoxManagement.TabIndex = 38;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.FromArgb(58, 154, 193);
            buttonCreate.FlatAppearance.BorderColor = Color.FromArgb(58, 154, 193);
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreate.ForeColor = SystemColors.ControlLightLight;
            buttonCreate.Location = new Point(21, 121);
            buttonCreate.Margin = new Padding(2);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(86, 24);
            buttonCreate.TabIndex = 37;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(64, 26);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 36;
            label2.Text = "NEW MANAGEMENT";
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Silver;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = SystemColors.ActiveCaptionText;
            buttonCancel.Location = new Point(135, 121);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(86, 24);
            buttonCancel.TabIndex = 40;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonQuit
            // 
            buttonQuit.FlatAppearance.BorderSize = 0;
            buttonQuit.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonQuit.FlatStyle = FlatStyle.Flat;
            buttonQuit.Image = (Image)resources.GetObject("buttonQuit.Image");
            buttonQuit.Location = new Point(236, 3);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Padding = new Padding(0, 0, 1, 1);
            buttonQuit.Size = new Size(12, 12);
            buttonQuit.TabIndex = 41;
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // CreateManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 174);
            Controls.Add(buttonQuit);
            Controls.Add(buttonCancel);
            Controls.Add(label3);
            Controls.Add(textBoxManagement);
            Controls.Add(buttonCreate);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "CreateManagementForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CreateManagement";
            TopMost = true;
            Load += CreateManagementForm_Load;
            MouseDown += CreateManagementForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBoxManagement;
        private Button buttonCreate;
        private Label label2;
        private Button buttonCancel;
        private Button buttonQuit;
    }
}