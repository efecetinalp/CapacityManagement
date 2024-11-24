namespace DashboardUI
{
    partial class AdminForm
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
            userDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)userDataGrid).BeginInit();
            SuspendLayout();
            // 
            // userDataGrid
            // 
            userDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGrid.Location = new Point(22, 80);
            userDataGrid.Name = "userDataGrid";
            userDataGrid.RowTemplate.Height = 25;
            userDataGrid.Size = new Size(1236, 558);
            userDataGrid.TabIndex = 0;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 660);
            Controls.Add(userDataGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)userDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView userDataGrid;
    }
}