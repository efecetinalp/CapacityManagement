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
            comboBoxColorPalette = new ComboBox();
            labelColorPalette = new Label();
            labelPaletteType = new Label();
            comboBoxPaletteType = new ComboBox();
            labelAxisValueSize = new Label();
            comboBoxAxisValueSize = new ComboBox();
            labelXAxisInterval = new Label();
            comboBoxXAxisInterval = new ComboBox();
            labelGridColor = new Label();
            comboBoxGridColor = new ComboBox();
            labelGridWidth = new Label();
            comboBoxGridWidth = new ComboBox();
            labelLineColor = new Label();
            comboBoxLineColor = new ComboBox();
            labelLineWidth = new Label();
            comboBoxLineWidth = new ComboBox();
            labelAreaBorderColor = new Label();
            comboBoxAreaBorderColor = new ComboBox();
            labelAreaBorder = new Label();
            comboBoxAreaBorder = new ComboBox();
            labelGridStyle = new Label();
            comboBoxGridStyle = new ComboBox();
            buttonRotate = new Button();
            buttonShowHide = new Button();
            ((System.ComponentModel.ISupportInitialize)areaChart).BeginInit();
            SuspendLayout();
            // 
            // areaChart
            // 
            areaChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            areaChart.BackgroundImageLayout = ImageLayout.None;
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
            areaChart.Location = new Point(21, 122);
            areaChart.Margin = new Padding(2);
            areaChart.Name = "areaChart";
            areaChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Italic, GraphicsUnit.Point);
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            areaChart.Series.Add(series1);
            areaChart.Size = new Size(1236, 514);
            areaChart.TabIndex = 0;
            areaChart.Text = "Capacity";
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonSave.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(1203, 53);
            buttonSave.Margin = new Padding(2);
            buttonSave.Name = "buttonSave";
            buttonSave.Padding = new Padding(0, 0, 1, 1);
            buttonSave.Size = new Size(20, 20);
            buttonSave.TabIndex = 3;
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonUpdate.Cursor = Cursors.Hand;
            buttonUpdate.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonUpdate.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Image = (Image)resources.GetObject("buttonUpdate.Image");
            buttonUpdate.Location = new Point(1179, 53);
            buttonUpdate.Margin = new Padding(2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Padding = new Padding(0, 0, 1, 1);
            buttonUpdate.Size = new Size(20, 20);
            buttonUpdate.TabIndex = 2;
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // comboBoxColorPalette
            // 
            comboBoxColorPalette.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxColorPalette.FormattingEnabled = true;
            comboBoxColorPalette.Location = new Point(21, 65);
            comboBoxColorPalette.Margin = new Padding(4, 3, 4, 3);
            comboBoxColorPalette.Name = "comboBoxColorPalette";
            comboBoxColorPalette.Size = new Size(124, 20);
            comboBoxColorPalette.TabIndex = 4;
            comboBoxColorPalette.SelectedIndexChanged += comboBoxColorPalette_SelectedIndexChanged;
            // 
            // labelColorPalette
            // 
            labelColorPalette.AutoSize = true;
            labelColorPalette.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelColorPalette.ForeColor = Color.Black;
            labelColorPalette.Location = new Point(21, 50);
            labelColorPalette.Margin = new Padding(2, 0, 2, 0);
            labelColorPalette.Name = "labelColorPalette";
            labelColorPalette.Size = new Size(64, 12);
            labelColorPalette.TabIndex = 28;
            labelColorPalette.Text = "Color Palette";
            // 
            // labelPaletteType
            // 
            labelPaletteType.AutoSize = true;
            labelPaletteType.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelPaletteType.ForeColor = Color.Black;
            labelPaletteType.Location = new Point(21, 11);
            labelPaletteType.Margin = new Padding(2, 0, 2, 0);
            labelPaletteType.Name = "labelPaletteType";
            labelPaletteType.Size = new Size(61, 12);
            labelPaletteType.TabIndex = 30;
            labelPaletteType.Text = "Palette Type";
            // 
            // comboBoxPaletteType
            // 
            comboBoxPaletteType.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPaletteType.FormattingEnabled = true;
            comboBoxPaletteType.Location = new Point(21, 25);
            comboBoxPaletteType.Margin = new Padding(4, 3, 4, 3);
            comboBoxPaletteType.Name = "comboBoxPaletteType";
            comboBoxPaletteType.Size = new Size(120, 20);
            comboBoxPaletteType.TabIndex = 29;
            comboBoxPaletteType.SelectedIndexChanged += comboBoxPaletteType_SelectedIndexChanged;
            // 
            // labelAxisValueSize
            // 
            labelAxisValueSize.AutoSize = true;
            labelAxisValueSize.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelAxisValueSize.ForeColor = Color.Black;
            labelAxisValueSize.Location = new Point(149, 10);
            labelAxisValueSize.Margin = new Padding(2, 0, 2, 0);
            labelAxisValueSize.Name = "labelAxisValueSize";
            labelAxisValueSize.Size = new Size(74, 12);
            labelAxisValueSize.TabIndex = 32;
            labelAxisValueSize.Text = "Axis Value Size";
            // 
            // comboBoxAxisValueSize
            // 
            comboBoxAxisValueSize.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxAxisValueSize.FormattingEnabled = true;
            comboBoxAxisValueSize.Location = new Point(149, 25);
            comboBoxAxisValueSize.Margin = new Padding(4, 3, 4, 3);
            comboBoxAxisValueSize.Name = "comboBoxAxisValueSize";
            comboBoxAxisValueSize.Size = new Size(93, 20);
            comboBoxAxisValueSize.TabIndex = 31;
            comboBoxAxisValueSize.SelectedIndexChanged += comboBoxAxisValueSize_SelectedIndexChanged;
            // 
            // labelXAxisInterval
            // 
            labelXAxisInterval.AutoSize = true;
            labelXAxisInterval.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelXAxisInterval.ForeColor = Color.Black;
            labelXAxisInterval.Location = new Point(281, 10);
            labelXAxisInterval.Margin = new Padding(2, 0, 2, 0);
            labelXAxisInterval.Name = "labelXAxisInterval";
            labelXAxisInterval.Size = new Size(71, 12);
            labelXAxisInterval.TabIndex = 34;
            labelXAxisInterval.Text = "X Axis Interval";
            // 
            // comboBoxXAxisInterval
            // 
            comboBoxXAxisInterval.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxXAxisInterval.FormattingEnabled = true;
            comboBoxXAxisInterval.Location = new Point(281, 25);
            comboBoxXAxisInterval.Margin = new Padding(4, 3, 4, 3);
            comboBoxXAxisInterval.Name = "comboBoxXAxisInterval";
            comboBoxXAxisInterval.Size = new Size(96, 20);
            comboBoxXAxisInterval.TabIndex = 33;
            comboBoxXAxisInterval.SelectedIndexChanged += comboBoxXAxisInterval_SelectedIndexChanged;
            // 
            // labelGridColor
            // 
            labelGridColor.AutoSize = true;
            labelGridColor.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelGridColor.ForeColor = Color.Black;
            labelGridColor.Location = new Point(385, 50);
            labelGridColor.Margin = new Padding(2, 0, 2, 0);
            labelGridColor.Name = "labelGridColor";
            labelGridColor.Size = new Size(53, 12);
            labelGridColor.TabIndex = 40;
            labelGridColor.Text = "Grid Color";
            // 
            // comboBoxGridColor
            // 
            comboBoxGridColor.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxGridColor.FormattingEnabled = true;
            comboBoxGridColor.Location = new Point(385, 65);
            comboBoxGridColor.Margin = new Padding(4, 3, 4, 3);
            comboBoxGridColor.Name = "comboBoxGridColor";
            comboBoxGridColor.Size = new Size(96, 20);
            comboBoxGridColor.TabIndex = 39;
            comboBoxGridColor.SelectedIndexChanged += comboBoxGridColor_SelectedIndexChanged;
            // 
            // labelGridWidth
            // 
            labelGridWidth.AutoSize = true;
            labelGridWidth.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelGridWidth.ForeColor = Color.Black;
            labelGridWidth.Location = new Point(385, 10);
            labelGridWidth.Margin = new Padding(2, 0, 2, 0);
            labelGridWidth.Name = "labelGridWidth";
            labelGridWidth.Size = new Size(56, 12);
            labelGridWidth.TabIndex = 38;
            labelGridWidth.Text = "Grid Width";
            // 
            // comboBoxGridWidth
            // 
            comboBoxGridWidth.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxGridWidth.FormattingEnabled = true;
            comboBoxGridWidth.Location = new Point(385, 25);
            comboBoxGridWidth.Margin = new Padding(4, 3, 4, 3);
            comboBoxGridWidth.Name = "comboBoxGridWidth";
            comboBoxGridWidth.Size = new Size(96, 20);
            comboBoxGridWidth.TabIndex = 37;
            comboBoxGridWidth.SelectedIndexChanged += comboBoxGridWidth_SelectedIndexChanged;
            // 
            // labelLineColor
            // 
            labelLineColor.AutoSize = true;
            labelLineColor.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelLineColor.ForeColor = Color.Black;
            labelLineColor.Location = new Point(602, 50);
            labelLineColor.Margin = new Padding(2, 0, 2, 0);
            labelLineColor.Name = "labelLineColor";
            labelLineColor.Size = new Size(52, 12);
            labelLineColor.TabIndex = 45;
            labelLineColor.Text = "Line Color";
            // 
            // comboBoxLineColor
            // 
            comboBoxLineColor.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxLineColor.FormattingEnabled = true;
            comboBoxLineColor.Location = new Point(602, 65);
            comboBoxLineColor.Margin = new Padding(4, 3, 4, 3);
            comboBoxLineColor.Name = "comboBoxLineColor";
            comboBoxLineColor.Size = new Size(96, 20);
            comboBoxLineColor.TabIndex = 44;
            comboBoxLineColor.SelectedIndexChanged += comboBoxLineColor_SelectedIndexChanged;
            // 
            // labelLineWidth
            // 
            labelLineWidth.AutoSize = true;
            labelLineWidth.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelLineWidth.ForeColor = Color.Black;
            labelLineWidth.Location = new Point(602, 10);
            labelLineWidth.Margin = new Padding(2, 0, 2, 0);
            labelLineWidth.Name = "labelLineWidth";
            labelLineWidth.Size = new Size(55, 12);
            labelLineWidth.TabIndex = 43;
            labelLineWidth.Text = "Line Width";
            // 
            // comboBoxLineWidth
            // 
            comboBoxLineWidth.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxLineWidth.FormattingEnabled = true;
            comboBoxLineWidth.Location = new Point(602, 25);
            comboBoxLineWidth.Margin = new Padding(4, 3, 4, 3);
            comboBoxLineWidth.Name = "comboBoxLineWidth";
            comboBoxLineWidth.Size = new Size(96, 20);
            comboBoxLineWidth.TabIndex = 42;
            comboBoxLineWidth.SelectedIndexChanged += comboBoxLineWidth_SelectedIndexChanged;
            // 
            // labelAreaBorderColor
            // 
            labelAreaBorderColor.AutoSize = true;
            labelAreaBorderColor.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelAreaBorderColor.ForeColor = Color.Black;
            labelAreaBorderColor.Location = new Point(706, 50);
            labelAreaBorderColor.Margin = new Padding(2, 0, 2, 0);
            labelAreaBorderColor.Name = "labelAreaBorderColor";
            labelAreaBorderColor.Size = new Size(89, 12);
            labelAreaBorderColor.TabIndex = 49;
            labelAreaBorderColor.Text = "Area Border Color";
            // 
            // comboBoxAreaBorderColor
            // 
            comboBoxAreaBorderColor.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxAreaBorderColor.FormattingEnabled = true;
            comboBoxAreaBorderColor.Location = new Point(706, 65);
            comboBoxAreaBorderColor.Margin = new Padding(4, 3, 4, 3);
            comboBoxAreaBorderColor.Name = "comboBoxAreaBorderColor";
            comboBoxAreaBorderColor.Size = new Size(96, 20);
            comboBoxAreaBorderColor.TabIndex = 48;
            comboBoxAreaBorderColor.SelectedIndexChanged += comboBoxAreaBorderColor_SelectedIndexChanged;
            // 
            // labelAreaBorder
            // 
            labelAreaBorder.AutoSize = true;
            labelAreaBorder.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelAreaBorder.ForeColor = Color.Black;
            labelAreaBorder.Location = new Point(706, 10);
            labelAreaBorder.Margin = new Padding(2, 0, 2, 0);
            labelAreaBorder.Name = "labelAreaBorder";
            labelAreaBorder.Size = new Size(61, 12);
            labelAreaBorder.TabIndex = 47;
            labelAreaBorder.Text = "Area Border";
            // 
            // comboBoxAreaBorder
            // 
            comboBoxAreaBorder.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxAreaBorder.FormattingEnabled = true;
            comboBoxAreaBorder.Location = new Point(706, 25);
            comboBoxAreaBorder.Margin = new Padding(4, 3, 4, 3);
            comboBoxAreaBorder.Name = "comboBoxAreaBorder";
            comboBoxAreaBorder.Size = new Size(96, 20);
            comboBoxAreaBorder.TabIndex = 46;
            comboBoxAreaBorder.SelectedIndexChanged += comboBoxAreaBorder_SelectedIndexChanged;
            // 
            // labelGridStyle
            // 
            labelGridStyle.AutoSize = true;
            labelGridStyle.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelGridStyle.ForeColor = Color.Black;
            labelGridStyle.Location = new Point(489, 10);
            labelGridStyle.Margin = new Padding(2, 0, 2, 0);
            labelGridStyle.Name = "labelGridStyle";
            labelGridStyle.Size = new Size(49, 12);
            labelGridStyle.TabIndex = 53;
            labelGridStyle.Text = "Grid Style";
            // 
            // comboBoxGridStyle
            // 
            comboBoxGridStyle.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxGridStyle.FormattingEnabled = true;
            comboBoxGridStyle.Location = new Point(489, 25);
            comboBoxGridStyle.Margin = new Padding(4, 3, 4, 3);
            comboBoxGridStyle.Name = "comboBoxGridStyle";
            comboBoxGridStyle.Size = new Size(96, 20);
            comboBoxGridStyle.TabIndex = 52;
            comboBoxGridStyle.SelectedIndexChanged += comboBoxGridStyle_SelectedIndexChanged;
            // 
            // buttonRotate
            // 
            buttonRotate.Cursor = Cursors.Hand;
            buttonRotate.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonRotate.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonRotate.FlatStyle = FlatStyle.Flat;
            buttonRotate.Image = (Image)resources.GetObject("buttonRotate.Image");
            buttonRotate.Location = new Point(248, 25);
            buttonRotate.Margin = new Padding(2);
            buttonRotate.Name = "buttonRotate";
            buttonRotate.Padding = new Padding(0, 0, 1, 1);
            buttonRotate.Size = new Size(20, 20);
            buttonRotate.TabIndex = 54;
            buttonRotate.UseVisualStyleBackColor = true;
            buttonRotate.Click += buttonRotate_Click;
            // 
            // buttonShowHide
            // 
            buttonShowHide.Cursor = Cursors.Hand;
            buttonShowHide.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            buttonShowHide.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            buttonShowHide.FlatStyle = FlatStyle.Flat;
            buttonShowHide.Image = (Image)resources.GetObject("buttonShowHide.Image");
            buttonShowHide.Location = new Point(489, 65);
            buttonShowHide.Margin = new Padding(2);
            buttonShowHide.Name = "buttonShowHide";
            buttonShowHide.Padding = new Padding(0, 0, 1, 1);
            buttonShowHide.Size = new Size(20, 20);
            buttonShowHide.TabIndex = 55;
            buttonShowHide.UseVisualStyleBackColor = true;
            buttonShowHide.Click += buttonShowHide_Click;
            // 
            // ChartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1280, 660);
            Controls.Add(buttonShowHide);
            Controls.Add(buttonRotate);
            Controls.Add(labelGridStyle);
            Controls.Add(comboBoxGridStyle);
            Controls.Add(labelAreaBorderColor);
            Controls.Add(comboBoxAreaBorderColor);
            Controls.Add(labelAreaBorder);
            Controls.Add(comboBoxAreaBorder);
            Controls.Add(labelLineColor);
            Controls.Add(comboBoxLineColor);
            Controls.Add(labelLineWidth);
            Controls.Add(comboBoxLineWidth);
            Controls.Add(labelGridColor);
            Controls.Add(comboBoxGridColor);
            Controls.Add(labelGridWidth);
            Controls.Add(comboBoxGridWidth);
            Controls.Add(labelXAxisInterval);
            Controls.Add(comboBoxXAxisInterval);
            Controls.Add(labelAxisValueSize);
            Controls.Add(comboBoxAxisValueSize);
            Controls.Add(labelPaletteType);
            Controls.Add(comboBoxPaletteType);
            Controls.Add(labelColorPalette);
            Controls.Add(comboBoxColorPalette);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonSave);
            Controls.Add(areaChart);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ChartForm";
            Text = "ChartForm";
            Load += ChartForm_Load;
            ((System.ComponentModel.ISupportInitialize)areaChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart areaChart;
        private Button buttonSave;
        private Button buttonUpdate;
        private ComboBox comboBoxColorPalette;
        private Label labelColorPalette;
        private Label labelPaletteType;
        private ComboBox comboBoxPaletteType;
        private Label labelAxisValueSize;
        private ComboBox comboBoxAxisValueSize;
        private Label labelXAxisInterval;
        private ComboBox comboBoxXAxisInterval;
        private Label labelGridColor;
        private ComboBox comboBoxGridColor;
        private Label labelGridWidth;
        private ComboBox comboBoxGridWidth;
        private Label labelLineColor;
        private ComboBox comboBoxLineColor;
        private Label labelLineWidth;
        private ComboBox comboBoxLineWidth;
        private Label labelAreaBorderColor;
        private ComboBox comboBoxAreaBorderColor;
        private Label labelAreaBorder;
        private ComboBox comboBoxAreaBorder;
        private Label labelGridStyle;
        private ComboBox comboBoxGridStyle;
        private Button buttonRotate;
        private Button buttonShowHide;
    }
}