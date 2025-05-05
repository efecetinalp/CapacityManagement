namespace DashboardUI
{
    partial class FilterSeriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterSeriesForm));
            buttonQuit = new Button();
            buttonApply = new Button();
            checkedSeries = new CheckedListBox();
            SuspendLayout();
            // 
            // buttonQuit
            // 
            buttonQuit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonQuit.FlatAppearance.BorderSize = 0;
            buttonQuit.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonQuit.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonQuit.FlatStyle = FlatStyle.Flat;
            buttonQuit.Image = (Image)resources.GetObject("buttonQuit.Image");
            buttonQuit.Location = new Point(207, 4);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Padding = new Padding(0, 0, 1, 1);
            buttonQuit.Size = new Size(12, 12);
            buttonQuit.TabIndex = 47;
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // buttonApply
            // 
            buttonApply.BackColor = Color.FromArgb(52, 73, 94);
            buttonApply.FlatAppearance.BorderSize = 0;
            buttonApply.FlatStyle = FlatStyle.Flat;
            buttonApply.Font = new Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonApply.ForeColor = SystemColors.ButtonHighlight;
            buttonApply.Location = new Point(6, 255);
            buttonApply.Margin = new Padding(2);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(69, 25);
            buttonApply.TabIndex = 48;
            buttonApply.Text = "Apply";
            buttonApply.UseVisualStyleBackColor = false;
            buttonApply.Click += buttonApply_Click;
            // 
            // checkedSeries
            // 
            checkedSeries.BorderStyle = BorderStyle.None;
            checkedSeries.CheckOnClick = true;
            checkedSeries.FormattingEnabled = true;
            checkedSeries.Location = new Point(23, 25);
            checkedSeries.Name = "checkedSeries";
            checkedSeries.Size = new Size(176, 216);
            checkedSeries.TabIndex = 49;
            checkedSeries.MouseLeave += checkedSeries_MouseLeave;
            checkedSeries.MouseMove += checkedSeries_MouseMove;
            // 
            // FilterSeriesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(223, 286);
            Controls.Add(checkedSeries);
            Controls.Add(buttonApply);
            Controls.Add(buttonQuit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FilterSeriesForm";
            StartPosition = FormStartPosition.Manual;
            Text = "FilterSeries";
            Load += FilterSeriesForm_Load;
            MouseDown += FilterSeriesForm_MouseDown;
            ResumeLayout(false);
        }

        #endregion
        private Button buttonQuit;
        private Button buttonApply;
        private CheckedListBox checkedSeries;
    }
}