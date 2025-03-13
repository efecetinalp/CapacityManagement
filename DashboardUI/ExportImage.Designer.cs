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
            labelTitle = new Label();
            labelFileName = new Label();
            labelExportPath = new Label();
            buttonCancel = new Button();
            buttonExport = new Button();
            textBoxFileName = new TextBox();
            textBoxExportPath = new TextBox();
            buttonBrowse = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelTitle.Location = new Point(144, 47);
            labelTitle.Margin = new Padding(2, 0, 2, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(113, 19);
            labelTitle.TabIndex = 36;
            labelTitle.Text = "EXPORT CHART";
            // 
            // labelFileName
            // 
            labelFileName.AutoSize = true;
            labelFileName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelFileName.Location = new Point(37, 139);
            labelFileName.Margin = new Padding(2, 0, 2, 0);
            labelFileName.Name = "labelFileName";
            labelFileName.Size = new Size(61, 15);
            labelFileName.TabIndex = 35;
            labelFileName.Text = "File Name";
            // 
            // labelExportPath
            // 
            labelExportPath.AutoSize = true;
            labelExportPath.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelExportPath.Location = new Point(37, 89);
            labelExportPath.Margin = new Padding(2, 0, 2, 0);
            labelExportPath.Name = "labelExportPath";
            labelExportPath.Size = new Size(70, 15);
            labelExportPath.TabIndex = 34;
            labelExportPath.Text = "Export Path";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(184, 221);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(113, 32);
            buttonCancel.TabIndex = 33;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonExport
            // 
            buttonExport.BackColor = Color.FromArgb(58, 154, 193);
            buttonExport.FlatAppearance.BorderColor = Color.FromArgb(58, 154, 193);
            buttonExport.FlatStyle = FlatStyle.Flat;
            buttonExport.ForeColor = SystemColors.ButtonHighlight;
            buttonExport.Location = new Point(37, 221);
            buttonExport.Margin = new Padding(2);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(113, 32);
            buttonExport.TabIndex = 32;
            buttonExport.Text = "Export";
            buttonExport.UseVisualStyleBackColor = false;
            buttonExport.Click += buttonExport_Click;
            // 
            // textBoxFileName
            // 
            textBoxFileName.Location = new Point(37, 156);
            textBoxFileName.Margin = new Padding(2);
            textBoxFileName.Name = "textBoxFileName";
            textBoxFileName.Size = new Size(260, 23);
            textBoxFileName.TabIndex = 30;
            // 
            // textBoxExportPath
            // 
            textBoxExportPath.Location = new Point(37, 106);
            textBoxExportPath.Margin = new Padding(2);
            textBoxExportPath.Name = "textBoxExportPath";
            textBoxExportPath.Size = new Size(260, 23);
            textBoxExportPath.TabIndex = 37;
            // 
            // buttonBrowse
            // 
            buttonBrowse.BackColor = Color.FromArgb(58, 154, 193);
            buttonBrowse.FlatAppearance.BorderColor = Color.FromArgb(58, 154, 193);
            buttonBrowse.FlatStyle = FlatStyle.Flat;
            buttonBrowse.ForeColor = SystemColors.ButtonHighlight;
            buttonBrowse.Location = new Point(301, 106);
            buttonBrowse.Margin = new Padding(2);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(63, 23);
            buttonBrowse.TabIndex = 38;
            buttonBrowse.Text = "Browse";
            buttonBrowse.UseVisualStyleBackColor = false;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // ExportImage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 300);
            Controls.Add(buttonBrowse);
            Controls.Add(textBoxExportPath);
            Controls.Add(labelTitle);
            Controls.Add(labelFileName);
            Controls.Add(labelExportPath);
            Controls.Add(buttonCancel);
            Controls.Add(buttonExport);
            Controls.Add(textBoxFileName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExportImage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelFileName;
        private Label labelExportPath;
        private Button buttonCancel;
        private Button buttonExport;
        private TextBox textBoxFileName;
        private TextBox textBoxExportPath;
        private Button buttonBrowse;
    }
}