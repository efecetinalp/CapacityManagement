using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public ChartForm(DataGridForm dataGridForm) : base()
        {
            InitializeComponent();
            _dataGridForm = dataGridForm;
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            ChartRequest chartRequest = new();
            chartRequest = _dataGridForm.GenerateChartData();

            areaChart.Series.Clear();

            var chartArea = areaChart.ChartAreas[0];
            chartArea.AxisX.IntervalType = DateTimeIntervalType.Months;
            chartArea.AxisX.LabelStyle.Format = "MMM-yy";
            chartArea.AxisX.Minimum = chartRequest.Months[0];
            chartArea.AxisX.Maximum = chartRequest.Months[chartRequest.Months.Count - 1];

            for (int i = 1; i < chartRequest.Legends.Count; i++)
            {
                AddSeriaToChart(chartRequest.Legends[i], chartRequest.Series[i], chartRequest.Months, SeriesChartType.StackedArea);
            }

            //for department capacity line
            AddSeriaToChart(chartRequest.Legends[0], chartRequest.Series[0], chartRequest.Months, SeriesChartType.Line, 5);
        }

        private void AddSeriaToChart(string serieName, List<int> data, List<double> months, SeriesChartType type, int borderWidth = 1)
        {
            areaChart.Series.Add(serieName);
            areaChart.Series[serieName].XValueType = ChartValueType.DateTime;
            areaChart.Series[serieName].Legend = "Legend1";
            areaChart.Series[serieName].ChartArea = "ChartArea1";
            areaChart.Series[serieName].ChartType = type;
            areaChart.Series[serieName].BorderWidth = borderWidth;

            for (int i = 0; i < data.Count; i++)
            {
                areaChart.Series[serieName].Points.AddXY(months[i], data[i]);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

        }


    }
}
