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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            userDataGrid = new DataGridView();
            buttonCreate = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)userDataGrid).BeginInit();
            SuspendLayout();
            // 
            // userDataGrid
            // 
            userDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userDataGrid.BackgroundColor = SystemColors.ButtonHighlight;
            userDataGrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            userDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            userDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            userDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            userDataGrid.Location = new Point(22, 80);
            userDataGrid.Name = "userDataGrid";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            userDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            userDataGrid.RowTemplate.Height = 25;
            userDataGrid.Size = new Size(1236, 558);
            userDataGrid.TabIndex = 0;
            userDataGrid.CellBeginEdit += userDataGrid_CellBeginEdit;
            userDataGrid.CellContentClick += userDataGrid_CellContentClick;
            userDataGrid.CellEndEdit += userDataGrid_CellEndEdit;
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
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Transparent;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.Location = new Point(70, 34);
            buttonDelete.Margin = new Padding(2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(32, 32);
            buttonDelete.TabIndex = 34;
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1280, 660);
            Controls.Add(buttonDelete);
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
        private Button buttonDelete;
    }
}