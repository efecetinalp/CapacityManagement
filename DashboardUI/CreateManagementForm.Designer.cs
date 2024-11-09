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
            label3 = new Label();
            textBoxManagement = new TextBox();
            buttonCreate = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(39, 91);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 39;
            label3.Text = "Management";
            // 
            // textBoxManagement
            // 
            textBoxManagement.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxManagement.Location = new Point(40, 110);
            textBoxManagement.Margin = new Padding(2);
            textBoxManagement.Name = "textBoxManagement";
            textBoxManagement.Size = new Size(260, 23);
            textBoxManagement.TabIndex = 38;
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
            buttonCreate.TabIndex = 37;
            buttonCreate.Text = "Create Management";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(122, 50);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 17);
            label2.TabIndex = 36;
            label2.Text = "MANAGEMENT";
            // 
            // CreateManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 450);
            Controls.Add(label3);
            Controls.Add(textBoxManagement);
            Controls.Add(buttonCreate);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "CreateManagementForm";
            Text = "CreateManagement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBoxManagement;
        private Button buttonCreate;
        private Label label2;
    }
}