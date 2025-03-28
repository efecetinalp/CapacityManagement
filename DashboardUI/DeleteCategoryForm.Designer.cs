namespace DashboardUI
{
    partial class DeleteCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCategoryForm));
            checkBoxApproval = new CheckBox();
            buttonCancel = new Button();
            buttonDelete = new Button();
            textBoxDelete = new TextBox();
            labelDelete = new Label();
            buttonQuit = new Button();
            pictureBox1 = new PictureBox();
            labelTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkBoxApproval
            // 
            checkBoxApproval.AutoSize = true;
            checkBoxApproval.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxApproval.Location = new Point(12, 177);
            checkBoxApproval.Name = "checkBoxApproval";
            checkBoxApproval.Size = new Size(80, 17);
            checkBoxApproval.TabIndex = 42;
            checkBoxApproval.Text = "I am agree";
            checkBoxApproval.UseVisualStyleBackColor = true;
            checkBoxApproval.CheckedChanged += checkBoxApproval_CheckedChanged;
            // 
            // buttonCancel
            // 
            buttonCancel.FlatAppearance.BorderColor = Color.FromArgb(52, 73, 94);
            buttonCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.Black;
            buttonCancel.Location = new Point(288, 198);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(90, 25);
            buttonCancel.TabIndex = 41;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(52, 73, 94);
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.ForeColor = SystemColors.ButtonHighlight;
            buttonDelete.Location = new Point(185, 198);
            buttonDelete.Margin = new Padding(2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(90, 25);
            buttonDelete.TabIndex = 40;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxDelete
            // 
            textBoxDelete.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDelete.Location = new Point(12, 198);
            textBoxDelete.Name = "textBoxDelete";
            textBoxDelete.PlaceholderText = "Delete";
            textBoxDelete.Size = new Size(153, 22);
            textBoxDelete.TabIndex = 38;
            textBoxDelete.TabStop = false;
            // 
            // labelDelete
            // 
            labelDelete.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDelete.Location = new Point(12, 50);
            labelDelete.Name = "labelDelete";
            labelDelete.Size = new Size(366, 123);
            labelDelete.TabIndex = 37;
            labelDelete.Text = "Delete Label";
            labelDelete.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonQuit
            // 
            buttonQuit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonQuit.FlatAppearance.BorderSize = 0;
            buttonQuit.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonQuit.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonQuit.FlatStyle = FlatStyle.Flat;
            buttonQuit.Image = (Image)resources.GetObject("buttonQuit.Image");
            buttonQuit.Location = new Point(372, 5);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Padding = new Padding(0, 0, 1, 1);
            buttonQuit.Size = new Size(12, 12);
            buttonQuit.TabIndex = 43;
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(49, 23);
            labelTitle.Margin = new Padding(2, 0, 2, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(164, 16);
            labelTitle.TabIndex = 45;
            labelTitle.Text = "You Are About To Delete";
            // 
            // DeleteCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(389, 237);
            Controls.Add(labelTitle);
            Controls.Add(pictureBox1);
            Controls.Add(buttonQuit);
            Controls.Add(checkBoxApproval);
            Controls.Add(buttonCancel);
            Controls.Add(buttonDelete);
            Controls.Add(textBoxDelete);
            Controls.Add(labelDelete);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteCategoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DeleteCategoryForm";
            TopMost = true;
            Load += DeleteCategoryForm_Load;
            MouseDown += DeleteCategoryForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxApproval;
        private Button buttonCancel;
        private Button buttonDelete;
        private TextBox textBoxDelete;
        private Label labelDelete;
        private Button buttonQuit;
        private PictureBox pictureBox1;
        private Label labelTitle;
    }
}