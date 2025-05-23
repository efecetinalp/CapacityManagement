﻿namespace DashboardUI
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
            panelAdmin2 = new Panel();
            pictureBox2 = new PictureBox();
            labelCredential = new Label();
            labelActiveUser = new Label();
            panelAdmin = new Panel();
            buttonAdmin = new Button();
            panelDataGrid = new Panel();
            buttonDataGrid = new Button();
            panelChart = new Panel();
            buttonChart = new Button();
            panelDashboard = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            panelAdmin2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelAdmin.SuspendLayout();
            panelDataGrid.SuspendLayout();
            panelChart.SuspendLayout();
            panelDashboard.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackColor = Color.FromArgb(46, 52, 63);
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDashboard.ForeColor = Color.White;
            buttonDashboard.Image = (Image)resources.GetObject("buttonDashboard.Image");
            buttonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.Location = new Point(-12, -3);
            buttonDashboard.Margin = new Padding(2);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Padding = new Padding(28, 0, 0, 0);
            buttonDashboard.Size = new Size(241, 40);
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
            pictureBox1.Location = new Point(0, 41);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(46, 52, 63);
            panelMenu.Controls.Add(panelSideBar);
            panelMenu.Controls.Add(panelAdmin2);
            panelMenu.Controls.Add(panelAdmin);
            panelMenu.Controls.Add(panelDataGrid);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(panelChart);
            panelMenu.Controls.Add(panelDashboard);
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
            panelSideBar.Location = new Point(0, 261);
            panelSideBar.Margin = new Padding(2);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(6, 32);
            panelSideBar.TabIndex = 20;
            // 
            // panelAdmin2
            // 
            panelAdmin2.Controls.Add(pictureBox2);
            panelAdmin2.Controls.Add(labelCredential);
            panelAdmin2.Controls.Add(labelActiveUser);
            panelAdmin2.Location = new Point(0, 168);
            panelAdmin2.Margin = new Padding(2);
            panelAdmin2.Name = "panelAdmin2";
            panelAdmin2.Size = new Size(227, 57);
            panelAdmin2.TabIndex = 23;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // labelCredential
            // 
            labelCredential.AutoSize = true;
            labelCredential.BackColor = Color.Transparent;
            labelCredential.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelCredential.ForeColor = SystemColors.ButtonHighlight;
            labelCredential.ImageAlign = ContentAlignment.MiddleLeft;
            labelCredential.Location = new Point(75, 30);
            labelCredential.Name = "labelCredential";
            labelCredential.Size = new Size(42, 15);
            labelCredential.TabIndex = 22;
            labelCredential.Text = "GUEST";
            labelCredential.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelActiveUser
            // 
            labelActiveUser.AutoSize = true;
            labelActiveUser.BackColor = Color.Transparent;
            labelActiveUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelActiveUser.ForeColor = SystemColors.ButtonHighlight;
            labelActiveUser.ImageAlign = ContentAlignment.MiddleLeft;
            labelActiveUser.Location = new Point(75, 15);
            labelActiveUser.Name = "labelActiveUser";
            labelActiveUser.Size = new Size(56, 15);
            labelActiveUser.TabIndex = 21;
            labelActiveUser.Text = "Signing...";
            labelActiveUser.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelAdmin
            // 
            panelAdmin.Controls.Add(buttonAdmin);
            panelAdmin.Location = new Point(2, 414);
            panelAdmin.Margin = new Padding(2);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(225, 32);
            panelAdmin.TabIndex = 24;
            // 
            // buttonAdmin
            // 
            buttonAdmin.BackColor = Color.FromArgb(46, 52, 63);
            buttonAdmin.FlatStyle = FlatStyle.Flat;
            buttonAdmin.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdmin.ForeColor = Color.White;
            buttonAdmin.Image = (Image)resources.GetObject("buttonAdmin.Image");
            buttonAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdmin.Location = new Point(-10, -4);
            buttonAdmin.Margin = new Padding(2);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Padding = new Padding(28, 0, 0, 0);
            buttonAdmin.Size = new Size(251, 40);
            buttonAdmin.TabIndex = 18;
            buttonAdmin.Text = "              Admin";
            buttonAdmin.TextAlign = ContentAlignment.MiddleLeft;
            buttonAdmin.UseVisualStyleBackColor = false;
            buttonAdmin.Visible = false;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // panelDataGrid
            // 
            panelDataGrid.Controls.Add(buttonDataGrid);
            panelDataGrid.Location = new Point(0, 314);
            panelDataGrid.Margin = new Padding(2);
            panelDataGrid.Name = "panelDataGrid";
            panelDataGrid.Size = new Size(231, 32);
            panelDataGrid.TabIndex = 21;
            // 
            // buttonDataGrid
            // 
            buttonDataGrid.BackColor = Color.FromArgb(46, 52, 63);
            buttonDataGrid.FlatStyle = FlatStyle.Flat;
            buttonDataGrid.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDataGrid.ForeColor = Color.White;
            buttonDataGrid.Image = (Image)resources.GetObject("buttonDataGrid.Image");
            buttonDataGrid.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDataGrid.Location = new Point(-10, -4);
            buttonDataGrid.Margin = new Padding(2);
            buttonDataGrid.Name = "buttonDataGrid";
            buttonDataGrid.Padding = new Padding(28, 0, 0, 0);
            buttonDataGrid.Size = new Size(251, 40);
            buttonDataGrid.TabIndex = 18;
            buttonDataGrid.Text = "             Capacity";
            buttonDataGrid.TextAlign = ContentAlignment.MiddleLeft;
            buttonDataGrid.UseVisualStyleBackColor = false;
            buttonDataGrid.Click += buttonDataGrid_Click;
            // 
            // panelChart
            // 
            panelChart.Controls.Add(buttonChart);
            panelChart.Location = new Point(2, 363);
            panelChart.Margin = new Padding(2);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(228, 32);
            panelChart.TabIndex = 22;
            // 
            // buttonChart
            // 
            buttonChart.BackColor = Color.FromArgb(46, 52, 63);
            buttonChart.FlatStyle = FlatStyle.Flat;
            buttonChart.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonChart.ForeColor = Color.White;
            buttonChart.Image = (Image)resources.GetObject("buttonChart.Image");
            buttonChart.ImageAlign = ContentAlignment.MiddleLeft;
            buttonChart.Location = new Point(-12, -4);
            buttonChart.Margin = new Padding(2);
            buttonChart.Name = "buttonChart";
            buttonChart.Padding = new Padding(28, 0, 0, 0);
            buttonChart.Size = new Size(242, 40);
            buttonChart.TabIndex = 18;
            buttonChart.Text = "              Chart";
            buttonChart.TextAlign = ContentAlignment.MiddleLeft;
            buttonChart.UseVisualStyleBackColor = false;
            buttonChart.Click += buttonChart_Click;
            // 
            // panelDashboard
            // 
            panelDashboard.Controls.Add(buttonDashboard);
            panelDashboard.Location = new Point(2, 259);
            panelDashboard.Margin = new Padding(2);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(228, 32);
            panelDashboard.TabIndex = 20;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1264, 666);
            Controls.Add(panelMenu);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(2);
            MinimumSize = new Size(1278, 644);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Capacity Management";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panelAdmin2.ResumeLayout(false);
            panelAdmin2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelAdmin.ResumeLayout(false);
            panelDataGrid.ResumeLayout(false);
            panelChart.ResumeLayout(false);
            panelDashboard.ResumeLayout(false);
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
        private Panel panelAdmin2;
        private Panel panelSideBar;
        private Panel panelAdmin;
        private Button buttonAdmin;
        private Label labelActiveUser;
        private Label labelCredential;
        private PictureBox pictureBox2;
    }
}