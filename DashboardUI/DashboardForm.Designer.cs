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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, "10,10");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, "7,7");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, "3,3");
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, "10,10");
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, "10,10");
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panel1 = new Panel();
            labelDashboard = new Label();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            buttonCustom = new Button();
            buttonLastYear = new Button();
            buttonThisYear = new Button();
            buttonOverall = new Button();
            chartProjects = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartCapacityPercentage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartCapacityAgainstWork = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartOngoingCompletedProjects = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewOngoingProjects = new DataGridView();
            chartCapacity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dateTimeChart2 = new DateTimePicker();
            dateTimeChart3 = new DateTimePicker();
            labelPercentage = new Label();
            buttonShow = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartProjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartCapacityPercentage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartCapacityAgainstWork).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartOngoingCompletedProjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOngoingProjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartCapacity).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 52, 63);
            panel1.Controls.Add(labelDashboard);
            panel1.Controls.Add(dateTimePickerStart);
            panel1.Controls.Add(dateTimePickerEnd);
            panel1.Controls.Add(buttonCustom);
            panel1.Controls.Add(buttonLastYear);
            panel1.Controls.Add(buttonThisYear);
            panel1.Controls.Add(buttonOverall);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 65);
            panel1.TabIndex = 0;
            // 
            // labelDashboard
            // 
            labelDashboard.AutoSize = true;
            labelDashboard.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelDashboard.ForeColor = Color.White;
            labelDashboard.Location = new Point(27, 31);
            labelDashboard.Name = "labelDashboard";
            labelDashboard.Size = new Size(174, 23);
            labelDashboard.TabIndex = 26;
            labelDashboard.Text = "DATA RANGE : ALL";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePickerStart.CalendarFont = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerStart.CalendarMonthBackground = Color.White;
            dateTimePickerStart.CustomFormat = "MMM-yy";
            dateTimePickerStart.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.ImeMode = ImeMode.NoControl;
            dateTimePickerStart.Location = new Point(947, 9);
            dateTimePickerStart.Margin = new Padding(2);
            dateTimePickerStart.MinDate = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.ShowUpDown = true;
            dateTimePickerStart.Size = new Size(77, 20);
            dateTimePickerStart.TabIndex = 24;
            dateTimePickerStart.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePickerEnd.CalendarFont = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEnd.CalendarMonthBackground = Color.White;
            dateTimePickerEnd.CustomFormat = "MMM-yy";
            dateTimePickerEnd.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.ImeMode = ImeMode.NoControl;
            dateTimePickerEnd.Location = new Point(947, 36);
            dateTimePickerEnd.Margin = new Padding(2);
            dateTimePickerEnd.MinDate = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.ShowUpDown = true;
            dateTimePickerEnd.Size = new Size(77, 20);
            dateTimePickerEnd.TabIndex = 25;
            dateTimePickerEnd.Value = new DateTime(2025, 3, 25, 0, 0, 0, 0);
            // 
            // buttonCustom
            // 
            buttonCustom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCustom.BackColor = Color.Transparent;
            buttonCustom.FlatAppearance.BorderColor = Color.AliceBlue;
            buttonCustom.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            buttonCustom.FlatStyle = FlatStyle.Flat;
            buttonCustom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCustom.ForeColor = Color.White;
            buttonCustom.Location = new Point(867, 24);
            buttonCustom.Name = "buttonCustom";
            buttonCustom.Size = new Size(75, 32);
            buttonCustom.TabIndex = 2;
            buttonCustom.Text = "Custom";
            buttonCustom.UseVisualStyleBackColor = false;
            buttonCustom.Click += buttonCustom_Click;
            // 
            // buttonLastYear
            // 
            buttonLastYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLastYear.BackColor = Color.Transparent;
            buttonLastYear.FlatAppearance.BorderColor = Color.AliceBlue;
            buttonLastYear.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            buttonLastYear.FlatStyle = FlatStyle.Flat;
            buttonLastYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLastYear.ForeColor = Color.White;
            buttonLastYear.Location = new Point(786, 24);
            buttonLastYear.Name = "buttonLastYear";
            buttonLastYear.Size = new Size(75, 32);
            buttonLastYear.TabIndex = 3;
            buttonLastYear.Text = "Last Year";
            buttonLastYear.UseVisualStyleBackColor = false;
            buttonLastYear.Click += buttonLastYear_Click;
            // 
            // buttonThisYear
            // 
            buttonThisYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonThisYear.BackColor = Color.Transparent;
            buttonThisYear.FlatAppearance.BorderColor = Color.AliceBlue;
            buttonThisYear.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            buttonThisYear.FlatStyle = FlatStyle.Flat;
            buttonThisYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonThisYear.ForeColor = Color.White;
            buttonThisYear.Location = new Point(705, 24);
            buttonThisYear.Name = "buttonThisYear";
            buttonThisYear.Size = new Size(75, 32);
            buttonThisYear.TabIndex = 2;
            buttonThisYear.Text = "This Year";
            buttonThisYear.UseVisualStyleBackColor = false;
            buttonThisYear.Click += buttonThisYear_Click;
            // 
            // buttonOverall
            // 
            buttonOverall.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOverall.BackColor = Color.Transparent;
            buttonOverall.FlatAppearance.BorderColor = Color.AliceBlue;
            buttonOverall.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            buttonOverall.FlatStyle = FlatStyle.Flat;
            buttonOverall.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOverall.ForeColor = Color.White;
            buttonOverall.Location = new Point(624, 24);
            buttonOverall.Name = "buttonOverall";
            buttonOverall.Size = new Size(75, 32);
            buttonOverall.TabIndex = 1;
            buttonOverall.Text = "Overall";
            buttonOverall.UseVisualStyleBackColor = false;
            buttonOverall.Click += buttonOverall_Click;
            // 
            // chartProjects
            // 
            chartArea1.Name = "ChartArea1";
            chartProjects.ChartAreas.Add(chartArea1);
            legend1.Alignment = StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartProjects.Legends.Add(legend1);
            chartProjects.Location = new Point(27, 77);
            chartProjects.Name = "chartProjects";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackSecondaryColor = Color.RosyBrown;
            series1.BorderColor = Color.White;
            series1.BorderWidth = 7;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.CustomProperties = "PieLabelStyle=Outside, LabelsHorizontalLineSize=0.2, PieDrawingStyle=Concave, MinimumRelativePieSize=70, LabelsRadialLineSize=0.2, DoughnutRadius=50";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series1.SmartLabelStyle.CalloutBackColor = Color.Black;
            series1.SmartLabelStyle.CalloutLineWidth = 2;
            series1.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.Box;
            series1.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series1.SmartLabelStyle.MaxMovingDistance = 100D;
            chartProjects.Series.Add(series1);
            chartProjects.Size = new Size(270, 270);
            chartProjects.TabIndex = 0;
            chartProjects.Text = "ProjectChart";
            title1.Alignment = ContentAlignment.MiddleLeft;
            title1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            title1.Name = "Title1";
            title1.Position.Auto = false;
            title1.Position.Height = 6.487398F;
            title1.Position.Width = 94F;
            title1.Position.X = 3F;
            title1.Position.Y = 3F;
            title1.Text = "Assigned projects per management";
            chartProjects.Titles.Add(title1);
            // 
            // chartCapacityPercentage
            // 
            chartArea2.BorderWidth = 0;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 80F;
            chartArea2.Position.Width = 94F;
            chartArea2.Position.X = 3F;
            chartArea2.Position.Y = 20F;
            chartCapacityPercentage.ChartAreas.Add(chartArea2);
            legend2.Alignment = StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            chartCapacityPercentage.Legends.Add(legend2);
            chartCapacityPercentage.Location = new Point(755, 360);
            chartCapacityPercentage.Name = "chartCapacityPercentage";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series2.BackSecondaryColor = Color.MidnightBlue;
            series2.BorderColor = Color.White;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.CustomProperties = "CollectedSliceExploded=True, LabelsHorizontalLineSize=0.2, PieDrawingStyle=Concave, MinimumRelativePieSize=70, LabelsRadialLineSize=0.2, DoughnutRadius=50";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            dataPoint1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            dataPoint1.BackSecondaryColor = Color.Empty;
            dataPoint1.Color = Color.White;
            dataPoint1.IsValueShownAsLabel = false;
            dataPoint1.IsVisibleInLegend = false;
            dataPoint2.Color = Color.Linen;
            dataPoint2.IsValueShownAsLabel = false;
            dataPoint2.IsVisibleInLegend = false;
            dataPoint3.Color = Color.RoyalBlue;
            dataPoint3.IsValueShownAsLabel = false;
            dataPoint3.IsVisibleInLegend = false;
            series2.Points.Add(dataPoint1);
            series2.Points.Add(dataPoint2);
            series2.Points.Add(dataPoint3);
            series2.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series2.SmartLabelStyle.CalloutBackColor = Color.Black;
            series2.SmartLabelStyle.CalloutLineWidth = 2;
            series2.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.Box;
            series2.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series2.SmartLabelStyle.MaxMovingDistance = 100D;
            chartCapacityPercentage.Series.Add(series2);
            chartCapacityPercentage.Size = new Size(270, 270);
            chartCapacityPercentage.TabIndex = 1;
            chartCapacityPercentage.Text = "chart2";
            title2.Alignment = ContentAlignment.TopLeft;
            title2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            title2.Name = "Title1";
            title2.Text = "Percentage of capacity available";
            chartCapacityPercentage.Titles.Add(title2);
            // 
            // chartCapacityAgainstWork
            // 
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorGrid.Interval = 1D;
            chartArea3.AxisX.TitleFont = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            chartArea3.AxisY.MajorGrid.LineColor = Color.Silver;
            chartArea3.CursorX.IntervalOffset = 1D;
            chartArea3.Name = "ChartArea1";
            chartCapacityAgainstWork.ChartAreas.Add(chartArea3);
            legend3.Alignment = StringAlignment.Center;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            chartCapacityAgainstWork.Legends.Add(legend3);
            chartCapacityAgainstWork.Location = new Point(27, 360);
            chartCapacityAgainstWork.Name = "chartCapacityAgainstWork";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series3.BackSecondaryColor = Color.RosyBrown;
            series3.BorderColor = Color.White;
            series3.BorderWidth = 0;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series3.CustomProperties = "EmptyPointValue=Zero";
            series3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.SmartLabelStyle.CalloutBackColor = Color.Empty;
            series3.SmartLabelStyle.CalloutLineColor = Color.Empty;
            series3.SmartLabelStyle.CalloutLineWidth = 0;
            series3.SmartLabelStyle.MaxMovingDistance = 50D;
            series3.SmartLabelStyle.MinMovingDistance = 10D;
            chartCapacityAgainstWork.Series.Add(series3);
            chartCapacityAgainstWork.Size = new Size(713, 270);
            chartCapacityAgainstWork.TabIndex = 2;
            chartCapacityAgainstWork.Text = "chart2";
            title3.Alignment = ContentAlignment.TopLeft;
            title3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            title3.Name = "Title1";
            title3.Text = "Capacity against workload";
            chartCapacityAgainstWork.Titles.Add(title3);
            // 
            // chartOngoingCompletedProjects
            // 
            chartArea4.AxisX.LabelStyle.Enabled = false;
            chartArea4.AxisX.LineColor = Color.Transparent;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.MajorTickMark.Enabled = false;
            chartArea4.AxisX.ToolTip = "Ongoing and completed project percentage ";
            chartArea4.AxisY.LabelStyle.Enabled = false;
            chartArea4.AxisY.LineColor = Color.Transparent;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.AxisY.MajorTickMark.Enabled = false;
            chartArea4.Name = "ChartArea1";
            chartOngoingCompletedProjects.ChartAreas.Add(chartArea4);
            legend4.Alignment = StringAlignment.Center;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            chartOngoingCompletedProjects.Legends.Add(legend4);
            chartOngoingCompletedProjects.Location = new Point(591, 278);
            chartOngoingCompletedProjects.Name = "chartOngoingCompletedProjects";
            series4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series4.BackSecondaryColor = Color.RosyBrown;
            series4.BorderColor = Color.White;
            series4.BorderWidth = 0;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series4.CustomProperties = "MinPixelPointWidth=30";
            series4.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            series4.IsValueShownAsLabel = true;
            series4.Label = "Completed projects %55";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            dataPoint4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            dataPoint4.BackSecondaryColor = Color.DarkGray;
            dataPoint4.Color = Color.AliceBlue;
            dataPoint4.LabelForeColor = Color.Black;
            series4.Points.Add(dataPoint4);
            series4.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series4.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Square;
            series4.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series4.SmartLabelStyle.MaxMovingDistance = 10D;
            series4.SmartLabelStyle.MinMovingDistance = 100D;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series5.CustomProperties = "MinPixelPointWidth=30";
            series5.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            series5.IsValueShownAsLabel = true;
            series5.Label = "Ongoing projects %45";
            series5.LabelAngle = 90;
            series5.Legend = "Legend1";
            series5.Name = "Series2";
            dataPoint5.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            dataPoint5.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.None;
            dataPoint5.BackSecondaryColor = Color.MidnightBlue;
            dataPoint5.Color = Color.RoyalBlue;
            dataPoint5.LabelForeColor = Color.White;
            series5.Points.Add(dataPoint5);
            series5.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series5.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Square;
            series5.SmartLabelStyle.MinMovingDistance = 10D;
            series5.SmartLabelStyle.MovingDirection = System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Right | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Left | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.TopRight | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomLeft | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomRight;
            chartOngoingCompletedProjects.Series.Add(series4);
            chartOngoingCompletedProjects.Series.Add(series5);
            chartOngoingCompletedProjects.Size = new Size(434, 69);
            chartOngoingCompletedProjects.TabIndex = 3;
            chartOngoingCompletedProjects.Text = "chart2";
            title4.Alignment = ContentAlignment.TopLeft;
            title4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            title4.Name = "Title1";
            title4.Text = "Ongoing and completed projects";
            chartOngoingCompletedProjects.Titles.Add(title4);
            // 
            // dataGridViewOngoingProjects
            // 
            dataGridViewOngoingProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOngoingProjects.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewOngoingProjects.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewOngoingProjects.BorderStyle = BorderStyle.None;
            dataGridViewOngoingProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOngoingProjects.Location = new Point(592, 77);
            dataGridViewOngoingProjects.Name = "dataGridViewOngoingProjects";
            dataGridViewOngoingProjects.ReadOnly = true;
            dataGridViewOngoingProjects.RowHeadersVisible = false;
            dataGridViewOngoingProjects.RowTemplate.Height = 25;
            dataGridViewOngoingProjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOngoingProjects.Size = new Size(433, 195);
            dataGridViewOngoingProjects.TabIndex = 4;
            // 
            // chartCapacity
            // 
            chartArea5.Name = "ChartArea1";
            chartCapacity.ChartAreas.Add(chartArea5);
            legend5.Alignment = StringAlignment.Center;
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            chartCapacity.Legends.Add(legend5);
            chartCapacity.Location = new Point(309, 77);
            chartCapacity.Name = "chartCapacity";
            series6.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series6.BackSecondaryColor = Color.RosyBrown;
            series6.BorderColor = Color.White;
            series6.BorderWidth = 7;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.CustomProperties = "PieLabelStyle=Outside, LabelsHorizontalLineSize=0.2, PieDrawingStyle=Concave, MinimumRelativePieSize=70, LabelsRadialLineSize=0.2, DoughnutRadius=50";
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            series6.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series6.SmartLabelStyle.CalloutBackColor = Color.Black;
            series6.SmartLabelStyle.CalloutLineWidth = 2;
            series6.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.Box;
            series6.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series6.SmartLabelStyle.MaxMovingDistance = 100D;
            chartCapacity.Series.Add(series6);
            chartCapacity.Size = new Size(270, 270);
            chartCapacity.TabIndex = 5;
            chartCapacity.Text = "ProjectChart";
            title5.Alignment = ContentAlignment.MiddleLeft;
            title5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            title5.Name = "Title1";
            title5.Position.Auto = false;
            title5.Position.Height = 6.487398F;
            title5.Position.Width = 94F;
            title5.Position.X = 3F;
            title5.Position.Y = 3F;
            title5.Text = "Assigned capacity per department";
            chartCapacity.Titles.Add(title5);
            // 
            // dateTimeChart2
            // 
            dateTimeChart2.CalendarFont = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeChart2.CustomFormat = "MMMM";
            dateTimeChart2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeChart2.Format = DateTimePickerFormat.Custom;
            dateTimeChart2.ImeMode = ImeMode.NoControl;
            dateTimeChart2.Location = new Point(494, 103);
            dateTimeChart2.Margin = new Padding(2);
            dateTimeChart2.Name = "dateTimeChart2";
            dateTimeChart2.ShowUpDown = true;
            dateTimeChart2.Size = new Size(85, 20);
            dateTimeChart2.TabIndex = 26;
            dateTimeChart2.ValueChanged += dateTimeChart2_ValueChanged;
            // 
            // dateTimeChart3
            // 
            dateTimeChart3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimeChart3.CalendarFont = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeChart3.CustomFormat = "MMMM";
            dateTimeChart3.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeChart3.Format = DateTimePickerFormat.Custom;
            dateTimeChart3.ImeMode = ImeMode.NoControl;
            dateTimeChart3.Location = new Point(765, 394);
            dateTimeChart3.Margin = new Padding(2);
            dateTimeChart3.Name = "dateTimeChart3";
            dateTimeChart3.ShowUpDown = true;
            dateTimeChart3.Size = new Size(81, 20);
            dateTimeChart3.TabIndex = 27;
            dateTimeChart3.ValueChanged += dateTimeChart3_ValueChanged;
            // 
            // labelPercentage
            // 
            labelPercentage.AutoSize = true;
            labelPercentage.BackColor = Color.White;
            labelPercentage.FlatStyle = FlatStyle.Flat;
            labelPercentage.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelPercentage.Location = new Point(847, 495);
            labelPercentage.Name = "labelPercentage";
            labelPercentage.Size = new Size(86, 32);
            labelPercentage.TabIndex = 28;
            labelPercentage.Text = "30.7%";
            labelPercentage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonShow
            // 
            buttonShow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonShow.BackColor = Color.White;
            buttonShow.FlatStyle = FlatStyle.Flat;
            buttonShow.Font = new Font("Segoe UI Semibold", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonShow.Location = new Point(905, 77);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(120, 23);
            buttonShow.TabIndex = 26;
            buttonShow.Text = "Show Ongoing";
            buttonShow.UseVisualStyleBackColor = false;
            buttonShow.Click += buttonShow_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(765, 537);
            label1.Name = "label1";
            label1.Size = new Size(250, 81);
            label1.TabIndex = 29;
            label1.Text = "STATUS";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1048, 644);
            Controls.Add(label1);
            Controls.Add(buttonShow);
            Controls.Add(labelPercentage);
            Controls.Add(dateTimeChart3);
            Controls.Add(dateTimeChart2);
            Controls.Add(chartCapacity);
            Controls.Add(chartProjects);
            Controls.Add(dataGridViewOngoingProjects);
            Controls.Add(chartOngoingCompletedProjects);
            Controls.Add(chartCapacityAgainstWork);
            Controls.Add(chartCapacityPercentage);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartProjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartCapacityPercentage).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartCapacityAgainstWork).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartOngoingCompletedProjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOngoingProjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartCapacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProjects;
        private Button buttonCustom;
        private Button buttonLastYear;
        private Button buttonThisYear;
        private Button buttonOverall;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCapacityPercentage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCapacityAgainstWork;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOngoingCompletedProjects;
        private DataGridView dataGridViewOngoingProjects;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCapacity;
        private DateTimePicker dateTimeChart2;
        private DateTimePicker dateTimeChart3;
        private Label labelPercentage;
        private Button buttonShow;
        private Label labelDashboard;
        private Label label1;
    }
}