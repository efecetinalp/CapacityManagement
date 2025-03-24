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
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, "10,10");
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, "10,10");
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panel1 = new Panel();
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
            panel1.BackColor = Color.LightSlateGray;
            panel1.Controls.Add(dateTimePickerStart);
            panel1.Controls.Add(dateTimePickerEnd);
            panel1.Controls.Add(buttonCustom);
            panel1.Controls.Add(buttonLastYear);
            panel1.Controls.Add(buttonThisYear);
            panel1.Controls.Add(buttonOverall);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 48);
            panel1.TabIndex = 0;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePickerStart.CalendarFont = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerStart.CustomFormat = "MMM-yy";
            dateTimePickerStart.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.ImeMode = ImeMode.NoControl;
            dateTimePickerStart.Location = new Point(849, 21);
            dateTimePickerStart.Margin = new Padding(2);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(74, 20);
            dateTimePickerStart.TabIndex = 24;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePickerEnd.CalendarFont = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEnd.CustomFormat = "MMM-yy";
            dateTimePickerEnd.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.ImeMode = ImeMode.NoControl;
            dateTimePickerEnd.Location = new Point(927, 21);
            dateTimePickerEnd.Margin = new Padding(2);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(76, 20);
            dateTimePickerEnd.TabIndex = 25;
            // 
            // buttonCustom
            // 
            buttonCustom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCustom.BackColor = Color.LightSteelBlue;
            buttonCustom.FlatStyle = FlatStyle.Flat;
            buttonCustom.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCustom.Location = new Point(769, 11);
            buttonCustom.Name = "buttonCustom";
            buttonCustom.Size = new Size(75, 30);
            buttonCustom.TabIndex = 2;
            buttonCustom.Text = "Custom";
            buttonCustom.UseVisualStyleBackColor = false;
            buttonCustom.Click += buttonCustom_Click;
            // 
            // buttonLastYear
            // 
            buttonLastYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLastYear.BackColor = Color.LightSteelBlue;
            buttonLastYear.FlatStyle = FlatStyle.Flat;
            buttonLastYear.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLastYear.Location = new Point(688, 11);
            buttonLastYear.Name = "buttonLastYear";
            buttonLastYear.Size = new Size(75, 30);
            buttonLastYear.TabIndex = 3;
            buttonLastYear.Text = "Last Year";
            buttonLastYear.UseVisualStyleBackColor = false;
            buttonLastYear.Click += buttonLastYear_Click;
            // 
            // buttonThisYear
            // 
            buttonThisYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonThisYear.BackColor = Color.LightSteelBlue;
            buttonThisYear.FlatStyle = FlatStyle.Flat;
            buttonThisYear.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonThisYear.Location = new Point(607, 11);
            buttonThisYear.Name = "buttonThisYear";
            buttonThisYear.Size = new Size(75, 30);
            buttonThisYear.TabIndex = 2;
            buttonThisYear.Text = "This Year";
            buttonThisYear.UseVisualStyleBackColor = false;
            buttonThisYear.Click += buttonThisYear_Click;
            // 
            // buttonOverall
            // 
            buttonOverall.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOverall.BackColor = Color.LightSteelBlue;
            buttonOverall.FlatStyle = FlatStyle.Flat;
            buttonOverall.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOverall.Location = new Point(526, 11);
            buttonOverall.Name = "buttonOverall";
            buttonOverall.Size = new Size(75, 30);
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
            chartProjects.Location = new Point(27, 71);
            chartProjects.Name = "chartProjects";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackSecondaryColor = Color.RosyBrown;
            series1.BorderColor = Color.White;
            series1.BorderWidth = 7;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.CustomProperties = "LabelsRadialLineSize=0.2, LabelsHorizontalLineSize=0.2, PieLabelStyle=Outside, MinimumRelativePieSize=70, DoughnutRadius=50, PieDrawingStyle=Concave";
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
            chartArea2.Name = "ChartArea1";
            chartCapacityPercentage.ChartAreas.Add(chartArea2);
            legend2.Alignment = StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            chartCapacityPercentage.Legends.Add(legend2);
            chartCapacityPercentage.Location = new Point(755, 357);
            chartCapacityPercentage.Name = "chartCapacityPercentage";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series2.BackSecondaryColor = Color.RosyBrown;
            series2.BorderColor = Color.White;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.CustomProperties = "CollectedSliceExploded=True, LabelsRadialLineSize=0.2, LabelsHorizontalLineSize=0.2, PieLabelStyle=Outside, DoughnutRadius=30, PieDrawingStyle=Concave";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
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
            title3.Alignment = ContentAlignment.TopLeft;
            title3.Name = "Title2";
            title3.Text = "This will be half donut chart";
            chartCapacityPercentage.Titles.Add(title2);
            chartCapacityPercentage.Titles.Add(title3);
            // 
            // chartCapacityAgainstWork
            // 
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorGrid.LineColor = Color.Silver;
            chartArea3.Name = "ChartArea1";
            chartCapacityAgainstWork.ChartAreas.Add(chartArea3);
            legend3.Alignment = StringAlignment.Center;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Name = "Legend1";
            chartCapacityAgainstWork.Legends.Add(legend3);
            chartCapacityAgainstWork.Location = new Point(27, 357);
            chartCapacityAgainstWork.Name = "chartCapacityAgainstWork";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series3.BackSecondaryColor = Color.RosyBrown;
            series3.BorderColor = Color.White;
            series3.BorderWidth = 10;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series3.CustomProperties = "CollectedSliceExploded=True, LabelsRadialLineSize=0.2, LabelsHorizontalLineSize=0.2, PieLabelStyle=Outside, DoughnutRadius=30, PieDrawingStyle=Concave";
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series3.SmartLabelStyle.CalloutBackColor = Color.Black;
            series3.SmartLabelStyle.CalloutLineWidth = 2;
            series3.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.Box;
            series3.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series3.SmartLabelStyle.MaxMovingDistance = 100D;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series5.Legend = "Legend1";
            series5.Name = "Series3";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series6.Legend = "Legend1";
            series6.Name = "Series4";
            chartCapacityAgainstWork.Series.Add(series3);
            chartCapacityAgainstWork.Series.Add(series4);
            chartCapacityAgainstWork.Series.Add(series5);
            chartCapacityAgainstWork.Series.Add(series6);
            chartCapacityAgainstWork.Size = new Size(713, 270);
            chartCapacityAgainstWork.TabIndex = 2;
            chartCapacityAgainstWork.Text = "chart2";
            title4.Alignment = ContentAlignment.TopLeft;
            title4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            title4.Name = "Title1";
            title4.Text = "Capacity against workload";
            chartCapacityAgainstWork.Titles.Add(title4);
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
            chartOngoingCompletedProjects.Location = new Point(583, 272);
            chartOngoingCompletedProjects.Name = "chartOngoingCompletedProjects";
            series7.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series7.BackSecondaryColor = Color.RosyBrown;
            series7.BorderColor = Color.White;
            series7.BorderWidth = 0;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series7.CustomProperties = "MinPixelPointWidth=30";
            series7.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            series7.IsValueShownAsLabel = true;
            series7.Label = "Completed projects";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series7.Points.Add(dataPoint1);
            series7.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series7.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Square;
            series7.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series7.SmartLabelStyle.MaxMovingDistance = 10D;
            series7.SmartLabelStyle.MinMovingDistance = 100D;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series8.CustomProperties = "MinPixelPointWidth=30";
            series8.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            series8.IsValueShownAsLabel = true;
            series8.Label = "Ongoing projects";
            series8.LabelAngle = 90;
            series8.Legend = "Legend1";
            series8.Name = "Series2";
            series8.Points.Add(dataPoint2);
            series8.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series8.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Square;
            series8.SmartLabelStyle.MinMovingDistance = 10D;
            series8.SmartLabelStyle.MovingDirection = System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Right | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Left | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.TopRight | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomLeft | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomRight;
            chartOngoingCompletedProjects.Series.Add(series7);
            chartOngoingCompletedProjects.Series.Add(series8);
            chartOngoingCompletedProjects.Size = new Size(442, 69);
            chartOngoingCompletedProjects.TabIndex = 3;
            chartOngoingCompletedProjects.Text = "chart2";
            title5.Alignment = ContentAlignment.TopLeft;
            title5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            title5.Name = "Title1";
            title5.Text = "Ongoing and completed projects";
            chartOngoingCompletedProjects.Titles.Add(title5);
            // 
            // dataGridViewOngoingProjects
            // 
            dataGridViewOngoingProjects.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewOngoingProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOngoingProjects.Location = new Point(583, 71);
            dataGridViewOngoingProjects.Name = "dataGridViewOngoingProjects";
            dataGridViewOngoingProjects.RowTemplate.Height = 25;
            dataGridViewOngoingProjects.Size = new Size(442, 195);
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
            chartCapacity.Location = new Point(307, 71);
            chartCapacity.Name = "chartCapacity";
            series9.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series9.BackSecondaryColor = Color.RosyBrown;
            series9.BorderColor = Color.White;
            series9.BorderWidth = 7;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series9.CustomProperties = "LabelsRadialLineSize=0.2, LabelsHorizontalLineSize=0.2, PieLabelStyle=Outside, MinimumRelativePieSize=70, DoughnutRadius=50, PieDrawingStyle=Concave";
            series9.IsValueShownAsLabel = true;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            series9.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series9.SmartLabelStyle.CalloutBackColor = Color.Black;
            series9.SmartLabelStyle.CalloutLineWidth = 2;
            series9.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.Box;
            series9.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series9.SmartLabelStyle.MaxMovingDistance = 100D;
            chartCapacity.Series.Add(series9);
            chartCapacity.Size = new Size(270, 270);
            chartCapacity.TabIndex = 5;
            chartCapacity.Text = "ProjectChart";
            title6.Alignment = ContentAlignment.MiddleLeft;
            title6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            title6.Name = "Title1";
            title6.Position.Auto = false;
            title6.Position.Height = 6.487398F;
            title6.Position.Width = 94F;
            title6.Position.X = 3F;
            title6.Position.Y = 3F;
            title6.Text = "Assigned capacity per department";
            chartCapacity.Titles.Add(title6);
            // 
            // dateTimeChart2
            // 
            dateTimeChart2.CalendarFont = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeChart2.CustomFormat = "MMMM";
            dateTimeChart2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeChart2.Format = DateTimePickerFormat.Custom;
            dateTimeChart2.ImeMode = ImeMode.NoControl;
            dateTimeChart2.Location = new Point(494, 97);
            dateTimeChart2.Margin = new Padding(2);
            dateTimeChart2.Name = "dateTimeChart2";
            dateTimeChart2.Size = new Size(74, 20);
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
            dateTimeChart3.Location = new Point(942, 382);
            dateTimeChart3.Margin = new Padding(2);
            dateTimeChart3.Name = "dateTimeChart3";
            dateTimeChart3.Size = new Size(74, 20);
            dateTimeChart3.TabIndex = 27;
            dateTimeChart3.ValueChanged += dateTimeChart3_ValueChanged;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 644);
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
            ((System.ComponentModel.ISupportInitialize)chartProjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartCapacityPercentage).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartCapacityAgainstWork).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartOngoingCompletedProjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOngoingProjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartCapacity).EndInit();
            ResumeLayout(false);
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
    }
}