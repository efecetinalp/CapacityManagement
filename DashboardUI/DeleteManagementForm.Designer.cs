namespace DashboardUI
{
    partial class DeleteManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteManagementForm));
            checkBoxApproval = new CheckBox();
            buttonCancel = new Button();
            buttonDelete = new Button();
            label2 = new Label();
            textBoxDelete = new TextBox();
            labelDelete = new Label();
            buttonQuit = new Button();
            SuspendLayout();
            // 
            // checkBoxApproval
            // 
            checkBoxApproval.AutoSize = true;
            checkBoxApproval.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxApproval.Location = new Point(17, 129);
            checkBoxApproval.Name = "checkBoxApproval";
            checkBoxApproval.Size = new Size(80, 17);
            checkBoxApproval.TabIndex = 42;
            checkBoxApproval.Text = "I am agree";
            checkBoxApproval.UseVisualStyleBackColor = true;
            checkBoxApproval.CheckedChanged += checkBoxApproval_CheckedChanged;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(251, 200);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(108, 25);
            buttonCancel.TabIndex = 41;
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
            buttonDelete.Location = new Point(17, 200);
            buttonDelete.Margin = new Padding(2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(108, 25);
            buttonDelete.TabIndex = 40;
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
            label2.Location = new Point(144, 14);
            label2.Name = "label2";
            label2.Size = new Size(91, 17);
            label2.TabIndex = 39;
            label2.Text = "     WARNING";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxDelete
            // 
            textBoxDelete.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDelete.Location = new Point(17, 152);
            textBoxDelete.Name = "textBoxDelete";
            textBoxDelete.PlaceholderText = "Delete";
            textBoxDelete.Size = new Size(153, 22);
            textBoxDelete.TabIndex = 38;
            textBoxDelete.TabStop = false;
            // 
            // labelDelete
            // 
            labelDelete.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDelete.Location = new Point(19, 39);
            labelDelete.Name = "labelDelete";
            labelDelete.Size = new Size(340, 85);
            labelDelete.TabIndex = 37;
            labelDelete.Text = "Delete Label";
            labelDelete.TextAlign = ContentAlignment.MiddleCenter;
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
            buttonQuit.TabIndex = 43;
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // DeleteManagementForm
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
            Name = "DeleteManagementForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DeleteForm";
            TopMost = true;
            Load += DeleteForm_Load;
            MouseDown += DeleteManagementForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxApproval;
        private Button buttonCancel;
        private Button buttonDelete;
        private Label label2;
        private TextBox textBoxDelete;
        private Label labelDelete;
        private Button buttonQuit;
    }
}