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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(41, 57);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 12);
            label3.TabIndex = 43;
            label3.Text = "Category Name";
            // 
            // textBoxCategory
            // 
            textBoxCategory.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCategory.Location = new Point(41, 71);
            textBoxCategory.Margin = new Padding(2);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(200, 20);
            textBoxCategory.TabIndex = 42;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.FromArgb(52, 73, 94);
            buttonCreate.FlatAppearance.BorderSize = 0;
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCreate.ForeColor = SystemColors.ButtonHighlight;
            buttonCreate.Location = new Point(41, 121);
            buttonCreate.Margin = new Padding(2);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(89, 25);
            buttonCreate.TabIndex = 41;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 20);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 16);
            label2.TabIndex = 40;
            label2.Text = "Create New Category";
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.White;
            buttonCancel.FlatAppearance.BorderColor = Color.FromArgb(52, 73, 94);
            buttonCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.Black;
            buttonCancel.Location = new Point(152, 121);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(89, 25);
            buttonCancel.TabIndex = 45;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonQuit
            // 
            buttonQuit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonQuit.FlatAppearance.BorderSize = 0;
            buttonQuit.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonQuit.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonQuit.FlatStyle = FlatStyle.Flat;
            buttonQuit.Image = (Image)resources.GetObject("buttonQuit.Image");
            buttonQuit.Location = new Point(266, 3);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Padding = new Padding(0, 0, 1, 1);
            buttonQuit.Size = new Size(12, 12);
            buttonQuit.TabIndex = 46;
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // CreateCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(281, 162);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}