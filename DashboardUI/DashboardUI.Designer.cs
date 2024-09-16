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
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.panelAdminUpdate = new System.Windows.Forms.Panel();
            this.buttonAdminUpdate = new System.Windows.Forms.Button();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.buttonDataGrid = new System.Windows.Forms.Button();
            this.panelAdminCreate = new System.Windows.Forms.Panel();
            this.buttonAdminCreate = new System.Windows.Forms.Button();
            this.panelAdminDelete = new System.Windows.Forms.Panel();
            this.buttonAdminDelete = new System.Windows.Forms.Button();
            this.panelChart = new System.Windows.Forms.Panel();
            this.buttonChart = new System.Windows.Forms.Button();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.buttonAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelAdminUpdate.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            this.panelAdminCreate.SuspendLayout();
            this.panelAdminDelete.SuspendLayout();
            this.panelChart.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboard.Image")));
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(-12, -8);
            this.buttonDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.buttonDashboard.Size = new System.Drawing.Size(241, 65);
            this.buttonDashboard.TabIndex = 18;
            this.buttonDashboard.Text = "             Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panelMenu.Controls.Add(this.panelSideBar);
            this.panelMenu.Controls.Add(this.panelAdminUpdate);
            this.panelMenu.Controls.Add(this.panelDataGrid);
            this.panelMenu.Controls.Add(this.panelAdminCreate);
            this.panelMenu.Controls.Add(this.panelAdminDelete);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.panelChart);
            this.panelMenu.Controls.Add(this.panelDashboard);
            this.panelMenu.Controls.Add(this.panelAdmin);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 681);
            this.panelMenu.TabIndex = 19;
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.panelSideBar.Location = new System.Drawing.Point(0, 187);
            this.panelSideBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(6, 50);
            this.panelSideBar.TabIndex = 20;
            // 
            // panelAdminUpdate
            // 
            this.panelAdminUpdate.Controls.Add(this.buttonAdminUpdate);
            this.panelAdminUpdate.Location = new System.Drawing.Point(2, 519);
            this.panelAdminUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.panelAdminUpdate.Name = "panelAdminUpdate";
            this.panelAdminUpdate.Size = new System.Drawing.Size(230, 35);
            this.panelAdminUpdate.TabIndex = 24;
            // 
            // buttonAdminUpdate
            // 
            this.buttonAdminUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.buttonAdminUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonAdminUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonAdminUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdminUpdate.Image")));
            this.buttonAdminUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdminUpdate.Location = new System.Drawing.Point(-24, -7);
            this.buttonAdminUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdminUpdate.Name = "buttonAdminUpdate";
            this.buttonAdminUpdate.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.buttonAdminUpdate.Size = new System.Drawing.Size(263, 49);
            this.buttonAdminUpdate.TabIndex = 18;
            this.buttonAdminUpdate.Text = "      Update";
            this.buttonAdminUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdminUpdate.UseVisualStyleBackColor = false;
            this.buttonAdminUpdate.Click += new System.EventHandler(this.buttonAdminUpdate_Click);
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.Controls.Add(this.buttonDataGrid);
            this.panelDataGrid.Location = new System.Drawing.Point(0, 261);
            this.panelDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(231, 50);
            this.panelDataGrid.TabIndex = 21;
            // 
            // buttonDataGrid
            // 
            this.buttonDataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.buttonDataGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDataGrid.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonDataGrid.ForeColor = System.Drawing.Color.White;
            this.buttonDataGrid.Image = ((System.Drawing.Image)(resources.GetObject("buttonDataGrid.Image")));
            this.buttonDataGrid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDataGrid.Location = new System.Drawing.Point(-10, -8);
            this.buttonDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDataGrid.Name = "buttonDataGrid";
            this.buttonDataGrid.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.buttonDataGrid.Size = new System.Drawing.Size(251, 65);
            this.buttonDataGrid.TabIndex = 18;
            this.buttonDataGrid.Text = "             Data Grid";
            this.buttonDataGrid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDataGrid.UseVisualStyleBackColor = false;
            this.buttonDataGrid.Click += new System.EventHandler(this.buttonDataGrid_Click);
            // 
            // panelAdminCreate
            // 
            this.panelAdminCreate.Controls.Add(this.buttonAdminCreate);
            this.panelAdminCreate.Location = new System.Drawing.Point(2, 474);
            this.panelAdminCreate.Margin = new System.Windows.Forms.Padding(2);
            this.panelAdminCreate.Name = "panelAdminCreate";
            this.panelAdminCreate.Size = new System.Drawing.Size(230, 35);
            this.panelAdminCreate.TabIndex = 23;
            // 
            // buttonAdminCreate
            // 
            this.buttonAdminCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.buttonAdminCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonAdminCreate.ForeColor = System.Drawing.Color.White;
            this.buttonAdminCreate.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdminCreate.Image")));
            this.buttonAdminCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdminCreate.Location = new System.Drawing.Point(-24, -8);
            this.buttonAdminCreate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdminCreate.Name = "buttonAdminCreate";
            this.buttonAdminCreate.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.buttonAdminCreate.Size = new System.Drawing.Size(254, 49);
            this.buttonAdminCreate.TabIndex = 18;
            this.buttonAdminCreate.Text = "      Create";
            this.buttonAdminCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdminCreate.UseVisualStyleBackColor = false;
            this.buttonAdminCreate.Click += new System.EventHandler(this.buttonAdminCreate_Click);
            // 
            // panelAdminDelete
            // 
            this.panelAdminDelete.Controls.Add(this.buttonAdminDelete);
            this.panelAdminDelete.Location = new System.Drawing.Point(2, 565);
            this.panelAdminDelete.Margin = new System.Windows.Forms.Padding(2);
            this.panelAdminDelete.Name = "panelAdminDelete";
            this.panelAdminDelete.Size = new System.Drawing.Size(230, 35);
            this.panelAdminDelete.TabIndex = 24;
            // 
            // buttonAdminDelete
            // 
            this.buttonAdminDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.buttonAdminDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonAdminDelete.ForeColor = System.Drawing.Color.White;
            this.buttonAdminDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdminDelete.Image")));
            this.buttonAdminDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdminDelete.Location = new System.Drawing.Point(-24, -7);
            this.buttonAdminDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdminDelete.Name = "buttonAdminDelete";
            this.buttonAdminDelete.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.buttonAdminDelete.Size = new System.Drawing.Size(263, 50);
            this.buttonAdminDelete.TabIndex = 18;
            this.buttonAdminDelete.Text = "      Delete";
            this.buttonAdminDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdminDelete.UseVisualStyleBackColor = false;
            this.buttonAdminDelete.Click += new System.EventHandler(this.buttonAdminDelete_Click);
            // 
            // panelChart
            // 
            this.panelChart.Controls.Add(this.buttonChart);
            this.panelChart.Location = new System.Drawing.Point(2, 337);
            this.panelChart.Margin = new System.Windows.Forms.Padding(2);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(228, 50);
            this.panelChart.TabIndex = 22;
            // 
            // buttonChart
            // 
            this.buttonChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.buttonChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonChart.ForeColor = System.Drawing.Color.White;
            this.buttonChart.Image = ((System.Drawing.Image)(resources.GetObject("buttonChart.Image")));
            this.buttonChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChart.Location = new System.Drawing.Point(-12, -9);
            this.buttonChart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChart.Name = "buttonChart";
            this.buttonChart.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.buttonChart.Size = new System.Drawing.Size(242, 65);
            this.buttonChart.TabIndex = 18;
            this.buttonChart.Text = "              Chart";
            this.buttonChart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChart.UseVisualStyleBackColor = false;
            this.buttonChart.Click += new System.EventHandler(this.buttonChart_Click);
            // 
            // panelDashboard
            // 
            this.panelDashboard.Controls.Add(this.buttonDashboard);
            this.panelDashboard.Location = new System.Drawing.Point(2, 188);
            this.panelDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(228, 50);
            this.panelDashboard.TabIndex = 20;
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.buttonAdmin);
            this.panelAdmin.Location = new System.Drawing.Point(0, 413);
            this.panelAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(232, 50);
            this.panelAdmin.TabIndex = 23;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonAdmin.ForeColor = System.Drawing.Color.White;
            this.buttonAdmin.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdmin.Image")));
            this.buttonAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdmin.Location = new System.Drawing.Point(-10, -8);
            this.buttonAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.buttonAdmin.Size = new System.Drawing.Size(251, 65);
            this.buttonAdmin.TabIndex = 18;
            this.buttonAdmin.Text = "              Data Edit";
            this.buttonAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelMenu);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capacity Management Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelAdminUpdate.ResumeLayout(false);
            this.panelDataGrid.ResumeLayout(false);
            this.panelAdminCreate.ResumeLayout(false);
            this.panelAdminDelete.ResumeLayout(false);
            this.panelChart.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.panelAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Panel panelAdminDelete;
        private Button buttonAdminDelete;
        private Panel panelAdminUpdate;
        private Button buttonAdminUpdate;
        private Panel panelAdminCreate;
        private Button buttonAdminCreate;
        private Panel panelAdmin;
        private Button buttonAdmin;
        private Panel panelSideBar;
    }
}