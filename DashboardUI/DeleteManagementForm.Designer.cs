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
            labelDelete = new Label();
            textBoxDelete = new TextBox();
            label2 = new Label();
            buttonCancel = new Button();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // labelDelete
            // 
            labelDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelDelete.Location = new Point(12, 43);
            labelDelete.Name = "labelDelete";
            labelDelete.Size = new Size(311, 45);
            labelDelete.TabIndex = 0;
            labelDelete.Text = "label1";
            labelDelete.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxDelete
            // 
            textBoxDelete.Location = new Point(12, 91);
            textBoxDelete.Name = "textBoxDelete";
            textBoxDelete.PlaceholderText = "test";
            textBoxDelete.Size = new Size(311, 23);
            textBoxDelete.TabIndex = 1;
            textBoxDelete.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 18);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "WARNING";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(180, 131);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(143, 32);
            buttonCancel.TabIndex = 24;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(58, 154, 193);
            buttonDelete.FlatAppearance.BorderColor = Color.FromArgb(58, 154, 193);
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.ForeColor = SystemColors.ButtonHighlight;
            buttonDelete.Location = new Point(12, 131);
            buttonDelete.Margin = new Padding(2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(143, 32);
            buttonDelete.TabIndex = 23;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 186);
            Controls.Add(buttonCancel);
            Controls.Add(buttonDelete);
            Controls.Add(label2);
            Controls.Add(textBoxDelete);
            Controls.Add(labelDelete);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteForm";
            StartPosition = FormStartPosition.Manual;
            Text = "DeleteForm";
            Load += DeleteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDelete;
        private TextBox textBoxDelete;
        private Label label2;
        private Button buttonCancel;
        private Button buttonDelete;
    }
}