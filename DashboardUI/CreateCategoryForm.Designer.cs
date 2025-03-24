namespace DashboardUI
{
    partial class CreateCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCategoryForm));
            label3 = new Label();
            textBoxCategory = new TextBox();
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
            label3.Location = new Point(24, 63);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 12);
            label3.TabIndex = 43;
            label3.Text = "Category Name";
            // 
            // textBoxCategory
            // 
            textBoxCategory.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCategory.Location = new Point(24, 77);
            textBoxCategory.Margin = new Padding(2);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(200, 20);
            textBoxCategory.TabIndex = 42;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.FromArgb(58, 154, 193);
            buttonCreate.FlatAppearance.BorderColor = Color.FromArgb(58, 154, 193);
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreate.ForeColor = SystemColors.ButtonHighlight;
            buttonCreate.Location = new Point(24, 131);
            buttonCreate.Margin = new Padding(2);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(85, 25);
            buttonCreate.TabIndex = 41;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(77, 32);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 40;
            label2.Text = "NEW CATEGORY";
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(58, 154, 193);
            buttonCancel.FlatAppearance.BorderColor = Color.FromArgb(58, 154, 193);
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = SystemColors.ControlLightLight;
            buttonCancel.Location = new Point(139, 133);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(85, 21);
            buttonCancel.TabIndex = 45;
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
            buttonQuit.Location = new Point(240, 3);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Padding = new Padding(0, 0, 1, 1);
            buttonQuit.Size = new Size(12, 12);
            buttonQuit.TabIndex = 46;
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // CreateCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 178);
            Controls.Add(buttonQuit);
            Controls.Add(buttonCancel);
            Controls.Add(label3);
            Controls.Add(textBoxCategory);
            Controls.Add(buttonCreate);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "CreateCategoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CreateCategoryForm";
            TopMost = true;
            MouseDown += CreateCategoryForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBoxCategory;
        private Button buttonCreate;
        private Label label2;
        private Button buttonCancel;
        private Button buttonQuit;
    }
}