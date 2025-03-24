namespace DashboardUI
{
    partial class DeleteUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUserForm));
            buttonCancel = new Button();
            buttonDelete = new Button();
            label2 = new Label();
            textBoxDelete = new TextBox();
            labelDelete = new Label();
            checkBoxApproval = new CheckBox();
            buttonQuit = new Button();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(250, 189);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(108, 25);
            buttonCancel.TabIndex = 29;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(58, 154, 193);
            buttonDelete.FlatAppearance.BorderColor = Color.FromArgb(58, 154, 193);
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.ForeColor = SystemColors.ButtonHighlight;
            buttonDelete.Location = new Point(18, 189);
            buttonDelete.Margin = new Padding(2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(108, 25);
            buttonDelete.TabIndex = 28;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(143, 18);
            label2.Name = "label2";
            label2.Size = new Size(91, 17);
            label2.TabIndex = 27;
            label2.Text = "     WARNING";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxDelete
            // 
            textBoxDelete.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDelete.Location = new Point(18, 150);
            textBoxDelete.Name = "textBoxDelete";
            textBoxDelete.PlaceholderText = "Delete";
            textBoxDelete.Size = new Size(141, 22);
            textBoxDelete.TabIndex = 26;
            textBoxDelete.TabStop = false;
            // 
            // labelDelete
            // 
            labelDelete.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDelete.Location = new Point(18, 43);
            labelDelete.Name = "labelDelete";
            labelDelete.Size = new Size(340, 81);
            labelDelete.TabIndex = 25;
            labelDelete.Text = "Delete Label";
            labelDelete.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBoxApproval
            // 
            checkBoxApproval.AutoSize = true;
            checkBoxApproval.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxApproval.Location = new Point(18, 127);
            checkBoxApproval.Name = "checkBoxApproval";
            checkBoxApproval.Size = new Size(80, 17);
            checkBoxApproval.TabIndex = 30;
            checkBoxApproval.Text = "I am agree";
            checkBoxApproval.UseVisualStyleBackColor = true;
            checkBoxApproval.CheckedChanged += checkBoxApproval_CheckedChanged;
            // 
            // buttonQuit
            // 
            buttonQuit.FlatAppearance.BorderSize = 0;
            buttonQuit.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonQuit.FlatStyle = FlatStyle.Flat;
            buttonQuit.Image = (Image)resources.GetObject("buttonQuit.Image");
            buttonQuit.Location = new Point(362, 3);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Padding = new Padding(0, 0, 1, 1);
            buttonQuit.Size = new Size(12, 12);
            buttonQuit.TabIndex = 40;
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // DeleteUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 238);
            Controls.Add(buttonQuit);
            Controls.Add(checkBoxApproval);
            Controls.Add(buttonCancel);
            Controls.Add(buttonDelete);
            Controls.Add(label2);
            Controls.Add(textBoxDelete);
            Controls.Add(labelDelete);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteUserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DeleteUserForm";
            TopMost = true;
            Load += DeleteUserForm_Load;
            MouseDown += DeleteUserForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonDelete;
        private Label label2;
        private TextBox textBoxDelete;
        private Label labelDelete;
        private CheckBox checkBoxApproval;
        private Button buttonQuit;
    }
}