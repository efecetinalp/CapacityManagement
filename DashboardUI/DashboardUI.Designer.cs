namespace DashboardUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            buttonDashboard = new Button();
            pictureBox1 = new PictureBox();
            panelMenu = new Panel();
            panelSideBar = new Panel();
            panelDataGrid = new Panel();
            buttonDataGrid = new Button();
            panelChart = new Panel();
            buttonChart = new Button();
            panelDashboard = new Panel();
            panelAdmin = new Panel();
            buttonUser = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            panelDataGrid.SuspendLayout();
            panelChart.SuspendLayout();
            panelDashboard.SuspendLayout();
            panelAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackColor = Color.FromArgb(46, 52, 63);
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonDashboard.ForeColor = Color.White;
            buttonDashboard.Image = (Image)resources.GetObject("buttonDashboard.Image");
            buttonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.Location = new Point(-12, -8);
            buttonDashboard.Margin = new Padding(2);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Padding = new Padding(28, 0, 0, 0);
            buttonDashboard.Size = new Size(241, 65);
            buttonDashboard.TabIndex = 18;
            buttonDashboard.Text = "             Dashboard";
            buttonDashboard.TextAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.UseVisualStyleBackColor = false;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 33);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(46, 52, 63);
            panelMenu.Controls.Add(panelSideBar);
            panelMenu.Controls.Add(panelDataGrid);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(panelChart);
            panelMenu.Controls.Add(panelDashboard);
            panelMenu.Controls.Add(panelAdmin);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(230, 666);
            panelMenu.TabIndex = 19;
            // 
            // panelSideBar
            // 
            panelSideBar.BackColor = Color.FromArgb(58, 154, 193);
            panelSideBar.Location = new Point(0, 187);
            panelSideBar.Margin = new Padding(2);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(6, 50);
            panelSideBar.TabIndex = 20;
            // 
            // panelDataGrid
            // 
            panelDataGrid.Controls.Add(buttonDataGrid);
            panelDataGrid.Location = new Point(0, 261);
            panelDataGrid.Margin = new Padding(2);
            panelDataGrid.Name = "panelDataGrid";
            panelDataGrid.Size = new Size(231, 50);
            panelDataGrid.TabIndex = 21;
            // 
            // buttonDataGrid
            // 
            buttonDataGrid.BackColor = Color.FromArgb(46, 52, 63);
            buttonDataGrid.FlatStyle = FlatStyle.Flat;
            buttonDataGrid.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonDataGrid.ForeColor = Color.White;
            buttonDataGrid.Image = (Image)resources.GetObject("buttonDataGrid.Image");
            buttonDataGrid.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDataGrid.Location = new Point(-10, -8);
            buttonDataGrid.Margin = new Padding(2);
            buttonDataGrid.Name = "buttonDataGrid";
            buttonDataGrid.Padding = new Padding(28, 0, 0, 0);
            buttonDataGrid.Size = new Size(251, 65);
            buttonDataGrid.TabIndex = 18;
            buttonDataGrid.Text = "             Data Grid";
            buttonDataGrid.TextAlign = ContentAlignment.MiddleLeft;
            buttonDataGrid.UseVisualStyleBackColor = false;
            buttonDataGrid.Click += buttonDataGrid_Click;
            // 
            // panelChart
            // 
            panelChart.Controls.Add(buttonChart);
            panelChart.Location = new Point(2, 337);
            panelChart.Margin = new Padding(2);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(228, 50);
            panelChart.TabIndex = 22;
            // 
            // buttonChart
            // 
            buttonChart.BackColor = Color.FromArgb(46, 52, 63);
            buttonChart.FlatStyle = FlatStyle.Flat;
            buttonChart.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonChart.ForeColor = Color.White;
            buttonChart.Image = (Image)resources.GetObject("buttonChart.Image");
            buttonChart.ImageAlign = ContentAlignment.MiddleLeft;
            buttonChart.Location = new Point(-12, -9);
            buttonChart.Margin = new Padding(2);
            buttonChart.Name = "buttonChart";
            buttonChart.Padding = new Padding(28, 0, 0, 0);
            buttonChart.Size = new Size(242, 65);
            buttonChart.TabIndex = 18;
            buttonChart.Text = "              Chart";
            buttonChart.TextAlign = ContentAlignment.MiddleLeft;
            buttonChart.UseVisualStyleBackColor = false;
            buttonChart.Click += buttonChart_Click;
            // 
            // panelDashboard
            // 
            panelDashboard.Controls.Add(buttonDashboard);
            panelDashboard.Location = new Point(2, 188);
            panelDashboard.Margin = new Padding(2);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(228, 50);
            panelDashboard.TabIndex = 20;
            // 
            // panelAdmin
            // 
            panelAdmin.Controls.Add(buttonUser);
            panelAdmin.Location = new Point(0, 413);
            panelAdmin.Margin = new Padding(2);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(232, 50);
            panelAdmin.TabIndex = 23;
            // 
            // buttonUser
            // 
            buttonUser.BackColor = Color.FromArgb(46, 52, 63);
            buttonUser.FlatStyle = FlatStyle.Flat;
            buttonUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonUser.ForeColor = Color.White;
            buttonUser.Image = (Image)resources.GetObject("buttonUser.Image");
            buttonUser.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUser.Location = new Point(-10, -8);
            buttonUser.Margin = new Padding(2);
            buttonUser.Name = "buttonUser";
            buttonUser.Padding = new Padding(28, 0, 0, 0);
            buttonUser.Size = new Size(251, 65);
            buttonUser.TabIndex = 18;
            buttonUser.Text = "              Login";
            buttonUser.TextAlign = ContentAlignment.MiddleLeft;
            buttonUser.UseVisualStyleBackColor = false;
            buttonUser.Click += buttonUser_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1264, 666);
            Controls.Add(panelMenu);
            IsMdiContainer = true;
            Margin = new Padding(2);
            MinimumSize = new Size(1278, 644);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Capacity Management Dashboard";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panelDataGrid.ResumeLayout(false);
            panelChart.ResumeLayout(false);
            panelDashboard.ResumeLayout(false);
            panelAdmin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button buttonDashboard;
        private PictureBox pictureBox1;
        private Panel panelMenu;
        private Panel panelDashboard;
        private Panel panelDataGrid;
        private Button buttonDataGrid;
        private Panel panelChart;
        private Button buttonChart;
        private Panel panelAdmin;
        private Button buttonUser;
        private Panel panelSideBar;
    }
}