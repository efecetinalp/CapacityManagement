namespace DashboardUI
{
    partial class UpdateUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateUserForm));
            label2 = new Label();
            panel1 = new Panel();
            checkBoxAuthor = new CheckBox();
            checkBoxAdmin = new CheckBox();
            pictureBox1 = new PictureBox();
            buttonQuit = new Button();
            label1 = new Label();
            buttonCancel = new Button();
            buttonUpdate = new Button();
            labelUserName = new Label();
            textBoxUserName = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(41, 98);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 12);
            label2.TabIndex = 51;
            label2.Text = "Credential";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(checkBoxAuthor);
            panel1.Controls.Add(checkBoxAdmin);
            panel1.ForeColor = Color.FromArgb(52, 73, 94);
            panel1.Location = new Point(41, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 25);
            panel1.TabIndex = 52;
            // 
            // checkBoxAuthor
            // 
            checkBoxAuthor.AutoSize = true;
            checkBoxAuthor.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAuthor.ForeColor = Color.Black;
            checkBoxAuthor.Location = new Point(31, 5);
            checkBoxAuthor.Name = "checkBoxAuthor";
            checkBoxAuthor.Size = new Size(54, 16);
            checkBoxAuthor.TabIndex = 37;
            checkBoxAuthor.Text = "Author";
            checkBoxAuthor.UseVisualStyleBackColor = true;
            checkBoxAuthor.CheckedChanged += checkBoxAuthor_CheckedChanged;
            // 
            // checkBoxAdmin
            // 
            checkBoxAdmin.AutoSize = true;
            checkBoxAdmin.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAdmin.ForeColor = Color.Black;
            checkBoxAdmin.Location = new Point(115, 5);
            checkBoxAdmin.Name = "checkBoxAdmin";
            checkBoxAdmin.Size = new Size(53, 16);
            checkBoxAdmin.TabIndex = 38;
            checkBoxAdmin.Text = "Admin";
            checkBoxAdmin.UseVisualStyleBackColor = true;
            checkBoxAdmin.CheckedChanged += checkBoxAdmin_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // buttonQuit
            // 
            buttonQuit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonQuit.FlatAppearance.BorderSize = 0;
            buttonQuit.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonQuit.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonQuit.FlatStyle = FlatStyle.Flat;
            buttonQuit.Image = (Image)resources.GetObject("buttonQuit.Image");
            buttonQuit.Location = new Point(264, 5);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Padding = new Padding(0, 0, 1, 1);
            buttonQuit.Size = new Size(12, 12);
            buttonQuit.TabIndex = 49;
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(41, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 16);
            label1.TabIndex = 48;
            label1.Text = "Update User";
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
            buttonCancel.Location = new Point(156, 167);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(85, 23);
            buttonCancel.TabIndex = 47;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(52, 73, 94);
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.ForeColor = SystemColors.ButtonHighlight;
            buttonUpdate.Location = new Point(41, 167);
            buttonUpdate.Margin = new Padding(2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(85, 23);
            buttonUpdate.TabIndex = 46;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.BackColor = Color.Transparent;
            labelUserName.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelUserName.ForeColor = SystemColors.ControlText;
            labelUserName.Location = new Point(41, 58);
            labelUserName.Margin = new Padding(2, 0, 2, 0);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(56, 12);
            labelUserName.TabIndex = 45;
            labelUserName.Text = "User Name";
            // 
            // textBoxUserName
            // 
            textBoxUserName.BackColor = SystemColors.ButtonHighlight;
            textBoxUserName.BorderStyle = BorderStyle.FixedSingle;
            textBoxUserName.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUserName.ForeColor = SystemColors.ControlText;
            textBoxUserName.Location = new Point(41, 73);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(200, 20);
            textBoxUserName.TabIndex = 44;
            // 
            // UpdateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(281, 204);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonQuit);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonUpdate);
            Controls.Add(labelUserName);
            Controls.Add(textBoxUserName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateUserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UpdateUserForm";
            TopMost = true;
            Load += UpdateUserForm_Load;
            MouseDown += UpdateUserForm_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private CheckBox checkBoxAuthor;
        private CheckBox checkBoxAdmin;
        private PictureBox pictureBox1;
        private Button buttonQuit;
        private Label label1;
        private Button buttonCancel;
        private Button buttonUpdate;
        private Label labelUserName;
        private TextBox textBoxUserName;
    }
}