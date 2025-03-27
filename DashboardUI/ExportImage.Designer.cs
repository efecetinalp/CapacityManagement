namespace DashboardUI
{
    partial class ExportImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportImage));
            labelTitle = new Label();
            labelFileName = new Label();
            labelExportPath = new Label();
            buttonExport = new Button();
            textBoxFileName = new TextBox();
            textBoxExportPath = new TextBox();
            buttonBrowse = new Button();
            pictureBox1 = new PictureBox();
            buttonQuit = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(41, 16);
            labelTitle.Margin = new Padding(2, 0, 2, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(113, 16);
            labelTitle.TabIndex = 36;
            labelTitle.Text = "Export Chart File";
            // 
            // labelFileName
            // 
            labelFileName.AutoSize = true;
            labelFileName.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelFileName.Location = new Point(41, 97);
            labelFileName.Margin = new Padding(2, 0, 2, 0);
            labelFileName.Name = "labelFileName";
            labelFileName.Size = new Size(52, 12);
            labelFileName.TabIndex = 35;
            labelFileName.Text = "File Name";
            // 
            // labelExportPath
            // 
            labelExportPath.AutoSize = true;
            labelExportPath.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelExportPath.Location = new Point(41, 61);
            labelExportPath.Margin = new Padding(2, 0, 2, 0);
            labelExportPath.Name = "labelExportPath";
            labelExportPath.Size = new Size(58, 12);
            labelExportPath.TabIndex = 34;
            labelExportPath.Text = "Export Path";
            // 
            // buttonExport
            // 
            buttonExport.BackColor = Color.FromArgb(58, 154, 193);
            buttonExport.FlatAppearance.BorderSize = 0;
            buttonExport.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonExport.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonExport.FlatStyle = FlatStyle.Flat;
            buttonExport.Font = new Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExport.ForeColor = SystemColors.ButtonHighlight;
            buttonExport.Location = new Point(74, 156);
            buttonExport.Margin = new Padding(2);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(89, 25);
            buttonExport.TabIndex = 32;
            buttonExport.Text = "Export";
            buttonExport.UseVisualStyleBackColor = false;
            buttonExport.Click += buttonExport_Click;
            // 
            // textBoxFileName
            // 
            textBoxFileName.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFileName.Location = new Point(41, 109);
            textBoxFileName.Margin = new Padding(2);
            textBoxFileName.Name = "textBoxFileName";
            textBoxFileName.Size = new Size(222, 20);
            textBoxFileName.TabIndex = 30;
            // 
            // textBoxExportPath
            // 
            textBoxExportPath.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxExportPath.Location = new Point(41, 73);
            textBoxExportPath.Margin = new Padding(2);
            textBoxExportPath.Name = "textBoxExportPath";
            textBoxExportPath.Size = new Size(222, 20);
            textBoxExportPath.TabIndex = 37;
            // 
            // buttonBrowse
            // 
            buttonBrowse.FlatAppearance.BorderSize = 0;
            buttonBrowse.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonBrowse.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonBrowse.FlatStyle = FlatStyle.Flat;
            buttonBrowse.ForeColor = SystemColors.ButtonHighlight;
            buttonBrowse.Image = (Image)resources.GetObject("buttonBrowse.Image");
            buttonBrowse.Location = new Point(13, 71);
            buttonBrowse.Margin = new Padding(2);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Padding = new Padding(0, 0, 2, 2);
            buttonBrowse.Size = new Size(20, 20);
            buttonBrowse.TabIndex = 38;
            buttonBrowse.UseVisualStyleBackColor = false;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 39;
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
            buttonQuit.Location = new Point(276, 5);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Padding = new Padding(0, 0, 1, 1);
            buttonQuit.Size = new Size(12, 12);
            buttonQuit.TabIndex = 41;
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.White;
            buttonCancel.FlatAppearance.BorderColor = Color.FromArgb(46, 52, 63);
            buttonCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.Black;
            buttonCancel.Location = new Point(174, 156);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(89, 25);
            buttonCancel.TabIndex = 42;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // ExportImage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(295, 192);
            Controls.Add(buttonCancel);
            Controls.Add(buttonQuit);
            Controls.Add(pictureBox1);
            Controls.Add(buttonBrowse);
            Controls.Add(textBoxExportPath);
            Controls.Add(labelTitle);
            Controls.Add(labelFileName);
            Controls.Add(labelExportPath);
            Controls.Add(buttonExport);
            Controls.Add(textBoxFileName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExportImage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MouseDown += ExportImage_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelFileName;
        private Label labelExportPath;
        private Button buttonExport;
        private TextBox textBoxFileName;
        private TextBox textBoxExportPath;
        private Button buttonBrowse;
        private PictureBox pictureBox1;
        private Button buttonQuit;
        private Button buttonCancel;
    }
}