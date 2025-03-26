namespace DashboardUI
{
    partial class backup
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, "10,10");
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, "10,10");
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, "10,10");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, "7,7");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, "3,3");
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            label1 = new Label();
            buttonShow = new Button();
            labelPercentage = new Label();
            dateTimeChart3 = new DateTimePicker();
            dateTimeChart2 = new DateTimePicker();
            chartCapacity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartProjects = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewOngoingProjects = new DataGridView();
            chartOngoingCompletedProjects = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartCapacityAgainstWork = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartCapacityPercentage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartProjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOngoingProjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartOngoingCompletedProjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartCapacityAgainstWork).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartCapacityPercentage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(987, 570);
            label1.Name = "label1";
            label1.Size = new Size(250, 81);
            label1.TabIndex = 40;
            label1.Text = "STATUS";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonShow
            // 
            buttonShow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonShow.BackColor = Color.White;
            buttonShow.FlatStyle = FlatStyle.Flat;
            buttonShow.Font = new Font("Segoe UI Semibold", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonShow.Location = new Point(1127, 110);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(120, 30);
            buttonShow.TabIndex = 36;
            buttonShow.Text = "Show Ongoing";
            buttonShow.UseVisualStyleBackColor = false;
            // 
            // labelPercentage
            // 
            labelPercentage.AutoSize = true;
            labelPercentage.BackColor = Color.White;
            labelPercentage.FlatStyle = FlatStyle.Flat;
            labelPercentage.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelPercentage.Location = new Point(1069, 528);
            labelPercentage.Name = "labelPercentage";
            labelPercentage.Size = new Size(86, 32);
            labelPercentage.TabIndex = 39;
            labelPercentage.Text = "30.7%";
            labelPercentage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimeChart3
            // 
            dateTimeChart3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimeChart3.CalendarFont = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeChart3.CustomFormat = "MMMM";
            dateTimeChart3.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeChart3.Format = DateTimePickerFormat.Custom;
            dateTimeChart3.ImeMode = ImeMode.NoControl;
            dateTimeChart3.Location = new Point(987, 427);
            dateTimeChart3.Margin = new Padding(2);
            dateTimeChart3.Name = "dateTimeChart3";
            dateTimeChart3.ShowUpDown = true;
            dateTimeChart3.Size = new Size(81, 20);
            dateTimeChart3.TabIndex = 38;
            // 
            // dateTimeChart2
            // 
            dateTimeChart2.CalendarFont = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeChart2.CustomFormat = "MMMM";
            dateTimeChart2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeChart2.Format = DateTimePickerFormat.Custom;
            dateTimeChart2.ImeMode = ImeMode.NoControl;
            dateTimeChart2.Location = new Point(716, 136);
            dateTimeChart2.Margin = new Padding(2);
            dateTimeChart2.Name = "dateTimeChart2";
            dateTimeChart2.ShowUpDown = true;
            dateTimeChart2.Size = new Size(85, 20);
            dateTimeChart2.TabIndex = 37;
            // 
            // chartCapacity
            // 
            chartArea1.Name = "ChartArea1";
            chartCapacity.ChartAreas.Add(chartArea1);
            legend1.Alignment = StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartCapacity.Legends.Add(legend1);
            chartCapacity.Location = new Point(531, 110);
            chartCapacity.Name = "chartCapacity";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackSecondaryColor = Color.RosyBrown;
            series1.BorderColor = Color.White;
            series1.BorderWidth = 7;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.CustomProperties = "PieLabelStyle=Outside, PieDrawingStyle=Concave, MinimumRelativePieSize=70, LabelsHorizontalLineSize=0.2, DoughnutRadius=50, LabelsRadialLineSize=0.2";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series1.SmartLabelStyle.CalloutBackColor = Color.Black;
            series1.SmartLabelStyle.CalloutLineWidth = 2;
            series1.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.Box;
            series1.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series1.SmartLabelStyle.MaxMovingDistance = 100D;
            chartCapacity.Series.Add(series1);
            chartCapacity.Size = new Size(270, 270);
            chartCapacity.TabIndex = 35;
            chartCapacity.Text = "ProjectChart";
            title1.Alignment = ContentAlignment.MiddleLeft;
            title1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            title1.Name = "Title1";
            title1.Position.Auto = false;
            title1.Position.Height = 6.487398F;
            title1.Position.Width = 94F;
            title1.Position.X = 3F;
            title1.Position.Y = 3F;
            title1.Text = "Assigned capacity per department";
            chartCapacity.Titles.Add(title1);
            // 
            // chartProjects
            // 
            chartArea2.Name = "ChartArea1";
            chartProjects.ChartAreas.Add(chartArea2);
            legend2.Alignment = StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            chartProjects.Legends.Add(legend2);
            chartProjects.Location = new Point(249, 110);
            chartProjects.Name = "chartProjects";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series2.BackSecondaryColor = Color.RosyBrown;
            series2.BorderColor = Color.White;
            series2.BorderWidth = 7;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.CustomProperties = "PieLabelStyle=Outside, PieDrawingStyle=Concave, MinimumRelativePieSize=70, LabelsHorizontalLineSize=0.2, DoughnutRadius=50, LabelsRadialLineSize=0.2";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series2.SmartLabelStyle.CalloutBackColor = Color.Black;
            series2.SmartLabelStyle.CalloutLineWidth = 2;
            series2.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.Box;
            series2.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series2.SmartLabelStyle.MaxMovingDistance = 100D;
            chartProjects.Series.Add(series2);
            chartProjects.Size = new Size(270, 270);
            chartProjects.TabIndex = 30;
            chartProjects.Text = "ProjectChart";
            title2.Alignment = ContentAlignment.MiddleLeft;
            title2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            title2.Name = "Title1";
            title2.Position.Auto = false;
            title2.Position.Height = 6.487398F;
            title2.Position.Width = 94F;
            title2.Position.X = 3F;
            title2.Position.Y = 3F;
            title2.Text = "Assigned projects per management";
            chartProjects.Titles.Add(title2);
            // 
            // dataGridViewOngoingProjects
            // 
            dataGridViewOngoingProjects.AllowUserToAddRows = false;
            dataGridViewOngoingProjects.AllowUserToDeleteRows = false;
            dataGridViewOngoingProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOngoingProjects.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewOngoingProjects.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewOngoingProjects.BorderStyle = BorderStyle.None;
            dataGridViewOngoingProjects.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewOngoingProjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewOngoingProjects.ColumnHeadersHeight = 30;
            dataGridViewOngoingProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewOngoingProjects.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewOngoingProjects.EnableHeadersVisualStyles = false;
            dataGridViewOngoingProjects.GridColor = SystemColors.Window;
            dataGridViewOngoingProjects.Location = new Point(813, 110);
            dataGridViewOngoingProjects.Name = "dataGridViewOngoingProjects";
            dataGridViewOngoingProjects.ReadOnly = true;
            dataGridViewOngoingProjects.RowHeadersVisible = false;
            dataGridViewOngoingProjects.RowTemplate.Height = 25;
            dataGridViewOngoingProjects.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewOngoingProjects.Size = new Size(434, 195);
            dataGridViewOngoingProjects.TabIndex = 34;
            // 
            // chartOngoingCompletedProjects
            // 
            chartArea3.AxisX.LabelStyle.Enabled = false;
            chartArea3.AxisX.LineColor = Color.Transparent;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisX.ToolTip = "Ongoing and completed project percentage ";
            chartArea3.AxisY.LabelStyle.Enabled = false;
            chartArea3.AxisY.LineColor = Color.Transparent;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorTickMark.Enabled = false;
            chartArea3.Name = "ChartArea1";
            chartOngoingCompletedProjects.ChartAreas.Add(chartArea3);
            legend3.Alignment = StringAlignment.Center;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            chartOngoingCompletedProjects.Legends.Add(legend3);
            chartOngoingCompletedProjects.Location = new Point(813, 311);
            chartOngoingCompletedProjects.Name = "chartOngoingCompletedProjects";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series3.BackSecondaryColor = Color.RosyBrown;
            series3.BorderColor = Color.White;
            series3.BorderWidth = 0;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series3.CustomProperties = "MinPixelPointWidth=30";
            series3.Font = new Font("Century Gothic", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            series3.IsValueShownAsLabel = true;
            series3.Label = "Completed projects %55";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            dataPoint1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            dataPoint1.BackSecondaryColor = Color.DarkGray;
            dataPoint1.Color = Color.AliceBlue;
            dataPoint1.LabelForeColor = Color.Black;
            series3.Points.Add(dataPoint1);
            series3.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series3.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Square;
            series3.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series3.SmartLabelStyle.MaxMovingDistance = 10D;
            series3.SmartLabelStyle.MinMovingDistance = 100D;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series4.CustomProperties = "MinPixelPointWidth=30";
            series4.Font = new Font("Century Gothic", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            series4.IsValueShownAsLabel = true;
            series4.Label = "Ongoing projects %45";
            series4.LabelAngle = 90;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            dataPoint2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            dataPoint2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.None;
            dataPoint2.BackSecondaryColor = Color.MidnightBlue;
            dataPoint2.Color = Color.RoyalBlue;
            dataPoint2.LabelForeColor = Color.White;
            series4.Points.Add(dataPoint2);
            series4.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series4.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Square;
            series4.SmartLabelStyle.MinMovingDistance = 10D;
            series4.SmartLabelStyle.MovingDirection = System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Right | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Left | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.TopRight | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomLeft | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomRight;
            chartOngoingCompletedProjects.Series.Add(series3);
            chartOngoingCompletedProjects.Series.Add(series4);
            chartOngoingCompletedProjects.Size = new Size(434, 69);
            chartOngoingCompletedProjects.TabIndex = 33;
            chartOngoingCompletedProjects.Text = "chart2";
            title3.Alignment = ContentAlignment.TopLeft;
            title3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            title3.Name = "Title1";
            title3.Text = "Ongoing and completed projects";
            chartOngoingCompletedProjects.Titles.Add(title3);
            // 
            // chartCapacityAgainstWork
            // 
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.LabelStyle.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.MajorGrid.Interval = 1D;
            chartArea4.AxisX.TitleFont = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.LabelStyle.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            chartArea4.AxisY.MajorGrid.LineColor = Color.Silver;
            chartArea4.CursorX.IntervalOffset = 1D;
            chartArea4.Name = "ChartArea1";
            chartCapacityAgainstWork.ChartAreas.Add(chartArea4);
            legend4.Alignment = StringAlignment.Center;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            chartCapacityAgainstWork.Legends.Add(legend4);
            chartCapacityAgainstWork.Location = new Point(249, 393);
            chartCapacityAgainstWork.Name = "chartCapacityAgainstWork";
            series5.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series5.BackSecondaryColor = Color.RosyBrown;
            series5.BorderColor = Color.White;
            series5.BorderWidth = 0;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series5.CustomProperties = "EmptyPointValue=Zero";
            series5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.SmartLabelStyle.CalloutBackColor = Color.Empty;
            series5.SmartLabelStyle.CalloutLineColor = Color.Empty;
            series5.SmartLabelStyle.CalloutLineWidth = 0;
            series5.SmartLabelStyle.MaxMovingDistance = 50D;
            series5.SmartLabelStyle.MinMovingDistance = 10D;
            chartCapacityAgainstWork.Series.Add(series5);
            chartCapacityAgainstWork.Size = new Size(713, 270);
            chartCapacityAgainstWork.TabIndex = 32;
            chartCapacityAgainstWork.Text = "chart2";
            title4.Alignment = ContentAlignment.TopLeft;
            title4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            title4.Name = "Title1";
            title4.Text = "Capacity against workload";
            chartCapacityAgainstWork.Titles.Add(title4);
            // 
            // chartCapacityPercentage
            // 
            chartCapacityPercentage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea5.BorderWidth = 0;
            chartArea5.Name = "ChartArea1";
            chartArea5.Position.Auto = false;
            chartArea5.Position.Height = 80F;
            chartArea5.Position.Width = 94F;
            chartArea5.Position.X = 3F;
            chartArea5.Position.Y = 20F;
            chartCapacityPercentage.ChartAreas.Add(chartArea5);
            legend5.Alignment = StringAlignment.Center;
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            chartCapacityPercentage.Legends.Add(legend5);
            chartCapacityPercentage.Location = new Point(977, 393);
            chartCapacityPercentage.Name = "chartCapacityPercentage";
            series6.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series6.BackSecondaryColor = Color.MidnightBlue;
            series6.BorderColor = Color.White;
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.CustomProperties = "PieDrawingStyle=Concave, CollectedSliceExploded=True, LabelsHorizontalLineSize=0.2, DoughnutRadius=50, MinimumRelativePieSize=70, LabelsRadialLineSize=0.2";
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            dataPoint3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            dataPoint3.BackSecondaryColor = Color.Empty;
            dataPoint3.Color = Color.White;
            dataPoint3.IsValueShownAsLabel = false;
            dataPoint3.IsVisibleInLegend = false;
            dataPoint4.Color = Color.Linen;
            dataPoint4.IsValueShownAsLabel = false;
            dataPoint4.IsVisibleInLegend = false;
            dataPoint5.Color = Color.RoyalBlue;
            dataPoint5.IsValueShownAsLabel = false;
            dataPoint5.IsVisibleInLegend = false;
            series6.Points.Add(dataPoint3);
            series6.Points.Add(dataPoint4);
            series6.Points.Add(dataPoint5);
            series6.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series6.SmartLabelStyle.CalloutBackColor = Color.Black;
            series6.SmartLabelStyle.CalloutLineWidth = 2;
            series6.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.Box;
            series6.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series6.SmartLabelStyle.MaxMovingDistance = 100D;
            chartCapacityPercentage.Series.Add(series6);
            chartCapacityPercentage.Size = new Size(270, 270);
            chartCapacityPercentage.TabIndex = 31;
            chartCapacityPercentage.Text = "chart2";
            title5.Alignment = ContentAlignment.TopLeft;
            title5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            title5.Name = "Title1";
            title5.Text = "Percentage of capacity available";
            chartCapacityPercentage.Titles.Add(title5);
            // 
            // backup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1496, 773);
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
            Name = "backup";
            Text = "backup";
            Load += backup_Load;
            ((System.ComponentModel.ISupportInitialize)chartCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartProjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOngoingProjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartOngoingCompletedProjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartCapacityAgainstWork).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartCapacityPercentage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonShow;
        private Label labelPercentage;
        private DateTimePicker dateTimeChart3;
        private DateTimePicker dateTimeChart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCapacity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProjects;
        private DataGridView dataGridViewOngoingProjects;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOngoingCompletedProjects;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCapacityAgainstWork;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCapacityPercentage;
    }
}