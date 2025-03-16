using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DashboardUI
{
    public partial class ChartForm : Form
    {
        DataGridForm _dataGridForm;
        ToolTip _tooltip;

        private Color myColor;

        public ChartForm(DataGridForm dataGridForm) : base()
        {
            InitializeComponent();
            _dataGridForm = dataGridForm;
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            _tooltip = new ToolTip();
            _tooltip.SetToolTip(this.buttonSave, "Save");
            _tooltip.SetToolTip(this.buttonUpdate, "Update Chart");

            areaChart.Series.Clear();
            areaChart.AntiAliasing = AntiAliasingStyles.All;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (areaChart.Titles.Count == 0)
                areaChart.Titles.Add("");

            areaChart.Titles[0].Text = "Cabin Structure Capacity";
            //areaChart.Titles[0].Font = new Font("Calibri", 10, FontStyle.Bold);

            ChartRequest chartRequest = new();
            chartRequest = _dataGridForm.GenerateChartData();

            areaChart.Series.Clear();

            var chartArea = areaChart.ChartAreas[0];

            //Chart Area Formating
            chartArea.AlignmentOrientation = AreaAlignmentOrientations.All;
            chartArea.AlignmentStyle = AreaAlignmentStyles.All;

            //Axis X Formating
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.MajorGrid.LineWidth = 0;
            chartArea.AxisX.IntervalType = DateTimeIntervalType.Months;
            chartArea.AxisX.LabelStyle.Format = "MMM-yy";
            //chartArea.AxisX.LabelStyle.Angle = 90;
            chartArea.AxisX.LabelStyle.ForeColor = Color.Gray;
            chartArea.AxisX.LabelStyle.Font = new Font("Calibri", 7);
            chartArea.AxisX.Minimum = chartRequest.Months[0];
            chartArea.AxisX.Maximum = chartRequest.Months[chartRequest.Months.Count - 1];

            //Axis Y Formating
            chartArea.AxisY.MajorGrid.LineWidth = 1;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.LabelStyle.ForeColor = Color.Gray;
            chartArea.AxisY.LabelStyle.Font = new Font("Calibri", 7);

            //project capacity data
            int divider = chartRequest.Legends.Count;
            for (int i = 1; i < chartRequest.Legends.Count; i++)
            {
                myColor = Color.FromArgb(238 - (i * (238 - 204) / divider), 217 + (i * (247 - 217) / divider), 145 + (i * (244 - 145) / divider));
                AddSeriaToChart(chartRequest.Legends[i], chartRequest.Series[i], chartRequest.Months, SeriesChartType.StackedArea);
            }

            //for department capacity line
            AddSeriaToChartLine(chartRequest.Legends[0], chartRequest.Series[0], chartRequest.Months, SeriesChartType.Line, 2);

            for (int i = 0; i < areaChart.Legends.Count; i++)
            {
                areaChart.Legends[i].Alignment = StringAlignment.Center;
                areaChart.Legends[i].Font = new Font("Calibri", 8);
                areaChart.Legends[i].AutoFitMinFontSize = 7;
                areaChart.Legends[i].IsTextAutoFit = true;
                areaChart.Legends[i].LegendStyle = LegendStyle.Table;
            }
        }
        private void AddSeriaToChartLine(string serieName, List<double> data, List<double> months, SeriesChartType type, int borderWidth = 1)
        {
            Series newSerie = areaChart.Series.Add(serieName);
            newSerie.Color = Color.Purple;
            newSerie.XValueType = ChartValueType.DateTime;
            newSerie.Legend = "Legend1";
            newSerie.ChartArea = "ChartArea1";
            newSerie.ChartType = type;
            newSerie.BorderWidth = borderWidth;

            for (int i = 0; i < data.Count; i++)
            {
                newSerie.Points.AddXY(months[i], data[i]);
            }
        }

        private void AddSeriaToChart(string serieName, List<double> data, List<double> months, SeriesChartType type, int borderWidth = 1)
        {
            Series newSerie = areaChart.Series.Add(serieName);
            newSerie.Color = myColor;
            newSerie.BorderColor = Color.White;
            newSerie.BorderWidth = 5;
            newSerie.XValueType = ChartValueType.DateTime;
            newSerie.Legend = "Legend1";
            newSerie.ChartArea = "ChartArea1";
            newSerie.ChartType = type;
            newSerie.BorderWidth = borderWidth;

            for (int i = 0; i < data.Count; i++)
            {
                newSerie.Points.AddXY(months[i], data[i]);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ExportImage exportImage = new ExportImage(areaChart);
            exportImage.Show();
        }
    }
}
