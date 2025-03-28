namespace DashboardUI
{
    partial class ProjectListUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectListUI));
            dataGridViewProjectList = new DataGridView();
            buttonQuit = new Button();
            lblProjectList = new Label();
            imgProjectPicture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgProjectPicture).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProjectList
            // 
            dataGridViewProjectList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProjectList.BackgroundColor = Color.White;
            dataGridViewProjectList.BorderStyle = BorderStyle.None;
            dataGridViewProjectList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(169, 204, 227);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewProjectList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProjectList.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(169, 204, 227);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewProjectList.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProjectList.Dock = DockStyle.Fill;
            dataGridViewProjectList.EnableHeadersVisualStyles = false;
            dataGridViewProjectList.GridColor = Color.FromArgb(52, 73, 94);
            dataGridViewProjectList.Location = new Point(5, 40);
            dataGridViewProjectList.Name = "dataGridViewProjectList";
            dataGridViewProjectList.RowHeadersVisible = false;
            dataGridViewProjectList.RowTemplate.Height = 25;
            dataGridViewProjectList.Size = new Size(360, 205);
            dataGridViewProjectList.TabIndex = 0;
            // 
            // buttonQuit
            // 
            buttonQuit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonQuit.FlatAppearance.BorderSize = 0;
            buttonQuit.FlatAppearance.MouseDownBackColor = Color.FromArgb(169, 204, 227);
            buttonQuit.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 204, 227);
            buttonQuit.FlatStyle = FlatStyle.Flat;
            buttonQuit.Image = (Image)resources.GetObject("buttonQuit.Image");
            buttonQuit.Location = new Point(354, 4);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Padding = new Padding(0, 0, 1, 1);
            buttonQuit.Size = new Size(12, 12);
            buttonQuit.TabIndex = 40;
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // lblProjectList
            // 
            lblProjectList.AutoSize = true;
            lblProjectList.BackColor = Color.Transparent;
            lblProjectList.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblProjectList.Location = new Point(38, 12);
            lblProjectList.Name = "lblProjectList";
            lblProjectList.Size = new Size(86, 19);
            lblProjectList.TabIndex = 42;
            lblProjectList.Text = "Project List";
            lblProjectList.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imgProjectPicture
            // 
            imgProjectPicture.BackColor = Color.Transparent;
            imgProjectPicture.Image = (Image)resources.GetObject("imgProjectPicture.Image");
            imgProjectPicture.Location = new Point(8, 9);
            imgProjectPicture.Name = "imgProjectPicture";
            imgProjectPicture.Size = new Size(24, 24);
            imgProjectPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            imgProjectPicture.TabIndex = 41;
            imgProjectPicture.TabStop = false;
            // 
            // ProjectListUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 250);
            Controls.Add(lblProjectList);
            Controls.Add(imgProjectPicture);
            Controls.Add(buttonQuit);
            Controls.Add(dataGridViewProjectList);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProjectListUI";
            Padding = new Padding(5, 40, 5, 5);
            Text = "ProjectListUI";
            Load += ProjectListUI_Load;
            MouseDown += ProjectListUI_MouseDown;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectList).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgProjectPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProjectList;
        private Button buttonQuit;
        private Label lblProjectList;
        private PictureBox imgProjectPicture;
    }
}