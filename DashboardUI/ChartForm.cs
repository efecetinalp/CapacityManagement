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

namespace DashboardUI
{
    public partial class ChartForm : Form
    {
        DataGridForm _dataGridForm;
        ToolTip _tooltip;

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
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            ChartRequest chartRequest = new();
            chartRequest = _dataGridForm.GenerateChartData();

            areaChart.Series.Clear();

            var chartArea = areaChart.ChartAreas[0];
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.MajorGrid.LineWidth = 0;
            chartArea.AxisX.IntervalType = DateTimeIntervalType.Months;
            chartArea.AxisX.LabelStyle.Format = "MMM-yy";
            chartArea.AxisX.LabelStyle.Angle = 90;
            chartArea.AxisX.LabelStyle.ForeColor = Color.DarkGray;

            chartArea.AxisX.Minimum = chartRequest.Months[0];
            chartArea.AxisX.Maximum = chartRequest.Months[chartRequest.Months.Count - 1];

            chartArea.AxisY.MinorGrid.Enabled = true;
            chartArea.AxisY.MajorGrid.LineColor = Color.DarkGray;
            chartArea.AxisY.MinorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MinorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisY.LabelStyle.ForeColor = Color.DarkGray;

            areaChart.Titles.Add("CABIN STRUCTURE");

            for (int i = 1; i < chartRequest.Legends.Count; i++)
            {
                AddSeriaToChart(chartRequest.Legends[i], chartRequest.Series[i], chartRequest.Months, SeriesChartType.StackedArea);
            }

            //for department capacity line
            AddSeriaToChart(chartRequest.Legends[0], chartRequest.Series[0], chartRequest.Months, SeriesChartType.Line, 5);
        }

        private void AddSeriaToChart(string serieName, List<double> data, List<double> months, SeriesChartType type, int borderWidth = 1)
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(areaChart.Width);
            int height = Convert.ToInt32(areaChart.Height);
            using (Bitmap bmp = new Bitmap(width, height))
            {
                areaChart.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(areaChart.Name + ".jpg", ImageFormat.Jpeg);
                FileInfo image = new FileInfo(areaChart.Name + ".jpg");
                string userName = Environment.UserName;
                image.MoveTo(@"C:\Users\" + userName + @"\Desktop\" + areaChart.Name + ".jpg");
            }
        }
    }
}
