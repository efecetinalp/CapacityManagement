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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            userDataGrid = new DataGridView();
            buttonCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)userDataGrid).BeginInit();
            SuspendLayout();
            // 
            // userDataGrid
            // 
            userDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userDataGrid.BackgroundColor = SystemColors.ButtonHighlight;
            userDataGrid.BorderStyle = BorderStyle.None;
            userDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGrid.Location = new Point(22, 80);
            userDataGrid.Name = "userDataGrid";
            userDataGrid.RowTemplate.Height = 25;
            userDataGrid.Size = new Size(1236, 558);
            userDataGrid.TabIndex = 0;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.Transparent;
            buttonCreate.Cursor = Cursors.Hand;
            buttonCreate.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreate.ForeColor = Color.White;
            buttonCreate.Image = (Image)resources.GetObject("buttonCreate.Image");
            buttonCreate.Location = new Point(22, 34);
            buttonCreate.Margin = new Padding(2);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(32, 32);
            buttonCreate.TabIndex = 33;
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1280, 660);
            Controls.Add(buttonCreate);
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
        private Button buttonCreate;
    }
}