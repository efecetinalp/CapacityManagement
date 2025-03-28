namespace DashboardUI
{
    partial class CreateDepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDepartmentForm));
            label4 = new Label();
            textBoxDepartment = new TextBox();
            buttonCreate = new Button();
            label1 = new Label();
            lblManagement = new Label();
            comboBoxManagement = new ComboBox();
            buttonCancel = new Button();
            buttonQuit = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(40, 91);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 12);
            label4.TabIndex = 43;
            label4.Text = "Department Name";
            // 
            // textBoxDepartment
            // 
            textBoxDepartment.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDepartment.Location = new Point(41, 105);
            textBoxDepartment.Margin = new Padding(2);
            textBoxDepartment.Name = "textBoxDepartment";
            textBoxDepartment.Size = new Size(200, 20);
            textBoxDepartment.TabIndex = 42;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.FromArgb(52, 73, 94);
            buttonCreate.FlatAppearance.BorderSize = 0;
            buttonCreate.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonCreate.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCreate.ForeColor = SystemColors.ControlLightLight;
            buttonCreate.Location = new Point(41, 152);
            buttonCreate.Margin = new Padding(2);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(90, 25);
            buttonCreate.TabIndex = 41;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 16);
            label1.TabIndex = 40;
            label1.Text = "Create New Department";
            // 
            // lblManagement
            // 
            lblManagement.AutoSize = true;
            lblManagement.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblManagement.Location = new Point(41, 52);
            lblManagement.Margin = new Padding(2, 0, 2, 0);
            lblManagement.Name = "lblManagement";
            lblManagement.Size = new Size(65, 12);
            lblManagement.TabIndex = 39;
            lblManagement.Text = "Management";
            // 
            // comboBoxManagement
            // 
            comboBoxManagement.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxManagement.FormattingEnabled = true;
            comboBoxManagement.Location = new Point(41, 66);
            comboBoxManagement.Margin = new Padding(2);
            comboBoxManagement.Name = "comboBoxManagement";
            comboBoxManagement.Size = new Size(200, 20);
            comboBoxManagement.TabIndex = 38;
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
            buttonCancel.Location = new Point(161, 152);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(90, 25);
            buttonCancel.TabIndex = 44;
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
            buttonQuit.TabIndex = 45;
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // CreateDepartmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(281, 192);
            Controls.Add(pictureBox1);
            Controls.Add(buttonQuit);
            Controls.Add(buttonCancel);
            Controls.Add(label4);
            Controls.Add(textBoxDepartment);
            Controls.Add(buttonCreate);
            Controls.Add(label1);
            Controls.Add(lblManagement);
            Controls.Add(comboBoxManagement);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "CreateDepartmentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CreateDepartmentForm";
            TopMost = true;
            Load += CreateDepartmentForm_Load;
            MouseDown += CreateDepartmentForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBoxDepartment;
        private Button buttonCreate;
        private Label label1;
        private Label lblManagement;
        private ComboBox comboBoxManagement;
        private Button buttonCancel;
        private Button buttonQuit;
        private PictureBox pictureBox1;
    }
}