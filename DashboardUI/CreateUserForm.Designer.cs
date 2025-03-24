namespace DashboardUI
{
    partial class CreateUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUserForm));
            textBoxUserName = new TextBox();
            labelUserName = new Label();
            buttonCreate = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            checkBoxAdmin = new CheckBox();
            checkBoxAuthor = new CheckBox();
            buttonQuit = new Button();
            SuspendLayout();
            // 
            // textBoxUserName
            // 
            textBoxUserName.BackColor = SystemColors.ButtonHighlight;
            textBoxUserName.BorderStyle = BorderStyle.FixedSingle;
            textBoxUserName.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUserName.ForeColor = SystemColors.ControlText;
            textBoxUserName.Location = new Point(21, 64);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(188, 20);
            textBoxUserName.TabIndex = 0;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.BackColor = Color.Transparent;
            labelUserName.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelUserName.ForeColor = SystemColors.ControlText;
            labelUserName.Location = new Point(21, 49);
            labelUserName.Margin = new Padding(2, 0, 2, 0);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(56, 12);
            labelUserName.TabIndex = 28;
            labelUserName.Text = "User Name";
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.FromArgb(58, 154, 193);
            buttonCreate.FlatAppearance.BorderColor = Color.FromArgb(58, 154, 193);
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreate.ForeColor = SystemColors.ButtonHighlight;
            buttonCreate.Location = new Point(21, 152);
            buttonCreate.Margin = new Padding(2);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(85, 23);
            buttonCreate.TabIndex = 30;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Silver;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = SystemColors.ActiveCaptionText;
            buttonCancel.Location = new Point(124, 152);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(85, 23);
            buttonCancel.TabIndex = 31;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(82, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 32;
            label1.Text = "NEW USER";
            // 
            // checkBoxAdmin
            // 
            checkBoxAdmin.AutoSize = true;
            checkBoxAdmin.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAdmin.Location = new Point(81, 99);
            checkBoxAdmin.Name = "checkBoxAdmin";
            checkBoxAdmin.Size = new Size(53, 16);
            checkBoxAdmin.TabIndex = 38;
            checkBoxAdmin.Text = "Admin";
            checkBoxAdmin.UseVisualStyleBackColor = true;
            checkBoxAdmin.Click += checkBoxAdmin_CheckedChanged;
            // 
            // checkBoxAuthor
            // 
            checkBoxAuthor.AutoSize = true;
            checkBoxAuthor.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAuthor.Location = new Point(21, 99);
            checkBoxAuthor.Name = "checkBoxAuthor";
            checkBoxAuthor.Size = new Size(54, 16);
            checkBoxAuthor.TabIndex = 37;
            checkBoxAuthor.Text = "Author";
            checkBoxAuthor.UseVisualStyleBackColor = true;
            checkBoxAuthor.Click += checkBoxAuthor_CheckedChanged;
            // 
            // buttonQuit
            // 
            buttonQuit.FlatAppearance.BorderSize = 0;
            buttonQuit.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonQuit.FlatStyle = FlatStyle.Flat;
            buttonQuit.Image = (Image)resources.GetObject("buttonQuit.Image");
            buttonQuit.Location = new Point(215, 3);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Padding = new Padding(0, 0, 1, 1);
            buttonQuit.Size = new Size(12, 12);
            buttonQuit.TabIndex = 40;
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(230, 201);
            Controls.Add(buttonQuit);
            Controls.Add(checkBoxAdmin);
            Controls.Add(checkBoxAuthor);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCreate);
            Controls.Add(labelUserName);
            Controls.Add(textBoxUserName);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "CreateUserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CreateUserForm";
            TopMost = true;
            Load += CreateUser_Load;
            MouseDown += CreateUserForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUserName;
        private Label labelUserName;
        private Button buttonCreate;
        private Button buttonCancel;
        private Label label1;
        private CheckBox checkBoxAdmin;
        private CheckBox checkBoxAuthor;
        private Button buttonQuit;
    }
}