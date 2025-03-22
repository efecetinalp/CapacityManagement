namespace DashboardUI
{
    partial class UpdateCategoryForm
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
            textBoxCategory = new TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(79, 24);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 34;
            label7.Text = "EDIT CATEGORY";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(21, 58);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(77, 12);
            label6.TabIndex = 33;
            label6.Text = "Category Name";
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(146, 125);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(88, 28);
            buttonCancel.TabIndex = 32;
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
            buttonUpdate.Location = new Point(21, 125);
            buttonUpdate.Margin = new Padding(2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(88, 28);
            buttonUpdate.TabIndex = 31;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBoxCategory
            // 
            textBoxCategory.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCategory.Location = new Point(21, 72);
            textBoxCategory.Margin = new Padding(2);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(213, 20);
            textBoxCategory.TabIndex = 30;
            // 
            // UpdateCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 178);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(buttonCancel);
            Controls.Add(buttonUpdate);
            Controls.Add(textBoxCategory);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateCategoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UpdateCategoryForm";
            TopMost = true;
            Load += UpdateCategoryForm_Load;
            MouseDown += UpdateCategoryForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Button buttonCancel;
        private Button buttonUpdate;
        private TextBox textBoxCategory;
    }
}