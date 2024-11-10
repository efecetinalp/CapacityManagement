namespace DashboardUI
{
    partial class ChartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            areaChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonSave = new Button();
            buttonUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)areaChart).BeginInit();
            SuspendLayout();
            // 
            // areaChart
            // 
            areaChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 9;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 8;
            chartArea1.AxisX.LabelStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            chartArea1.AxisX.TitleFont = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            chartArea1.AxisY.TitleFont = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            chartArea1.Name = "ChartArea1";
            areaChart.ChartAreas.Add(chartArea1);
            legend1.Alignment = StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            areaChart.Legends.Add(legend1);
            areaChart.Location = new Point(21, 79);
            areaChart.Margin = new Padding(2);
            areaChart.Name = "areaChart";
            areaChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Italic, GraphicsUnit.Point);
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            areaChart.Series.Add(series1);
            areaChart.Size = new Size(1236, 558);
            areaChart.TabIndex = 0;
            areaChart.Text = "Capacity";
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(1226, 25);
            buttonSave.Margin = new Padding(2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(32, 32);
            buttonSave.TabIndex = 3;
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonUpdate.Cursor = Cursors.Hand;
            buttonUpdate.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Image = (Image)resources.GetObject("buttonUpdate.Image");
            buttonUpdate.Location = new Point(1181, 25);
            buttonUpdate.Margin = new Padding(2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(32, 32);
            buttonUpdate.TabIndex = 2;
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // ChartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 660);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonSave);
            Controls.Add(areaChart);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ChartForm";
            Text = "ChartForm";
            Load += ChartForm_Load;
            ((System.ComponentModel.ISupportInitialize)areaChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart areaChart;
        private Button buttonSave;
        private Button buttonUpdate;
    }
}