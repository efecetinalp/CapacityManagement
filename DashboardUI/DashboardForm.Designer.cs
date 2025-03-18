namespace DashboardUI
{
    partial class DashboardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel4 = new Panel();
            chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel5 = new Panel();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel6 = new Panel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 48);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 394);
            panel2.Name = "panel2";
            panel2.Size = new Size(1048, 250);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.AutoSize = true;
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(chart4);
            panel3.Location = new Point(798, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 346);
            panel3.TabIndex = 2;
            // 
            // chart4
            // 
            chartArea1.Name = "ChartArea1";
            chart4.ChartAreas.Add(chartArea1);
            chart4.Dock = DockStyle.Top;
            legend1.Name = "Legend1";
            chart4.Legends.Add(legend1);
            chart4.Location = new Point(0, 0);
            chart4.Name = "chart4";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart4.Series.Add(series1);
            chart4.Size = new Size(250, 300);
            chart4.TabIndex = 0;
            chart4.Text = "chart4";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel4.AutoSize = true;
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(chart3);
            panel4.Location = new Point(534, 48);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 346);
            panel4.TabIndex = 2;
            // 
            // chart3
            // 
            chartArea2.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea2);
            chart3.Dock = DockStyle.Top;
            legend2.Name = "Legend1";
            chart3.Legends.Add(legend2);
            chart3.Location = new Point(0, 0);
            chart3.Name = "chart3";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart3.Series.Add(series2);
            chart3.Size = new Size(250, 300);
            chart3.TabIndex = 0;
            chart3.Text = "chart3";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel5.AutoSize = true;
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(chart2);
            panel5.Location = new Point(270, 48);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 346);
            panel5.TabIndex = 3;
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea3);
            chart2.Dock = DockStyle.Top;
            legend3.Name = "Legend1";
            chart2.Legends.Add(legend3);
            chart2.Location = new Point(0, 0);
            chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart2.Series.Add(series3);
            chart2.Size = new Size(250, 300);
            chart2.TabIndex = 0;
            chart2.Text = "chart2";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel6.AutoSize = true;
            panel6.BackColor = SystemColors.Control;
            panel6.Controls.Add(chart1);
            panel6.Location = new Point(6, 48);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 346);
            panel6.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea4);
            chart1.Dock = DockStyle.Top;
            legend4.Name = "Legend1";
            chart1.Legends.Add(legend4);
            chart1.Location = new Point(0, 0);
            chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.YValuesPerPoint = 4;
            chart1.Series.Add(series4);
            chart1.Size = new Size(250, 300);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 644);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart4).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart3).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}