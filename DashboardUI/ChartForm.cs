using Business.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;
using System.Data;
using Font = System.Drawing.Font;
using System.Windows.Forms.DataVisualization.Charting;
using ToolTip = System.Windows.Forms.ToolTip;

namespace DashboardUI
{
    public partial class ChartForm : Form
    {
        //Database Referances
        ColorPaletteManager _colorPaletteManager;
        ColorCodeManager _colorCodeManager;

        //Database cache data
        IDataResult<List<Entities.Concrete.ColorPalette>> _colorPalettes;
        IDataResult<List<ColorCodeDetailDto>> _colorDetails;
        List<Color> _colorList = new();

        //UI Referances
        DataGridForm _dataGridForm;
        FilterSeriesForm filterSeriesForm;
        ChartRequest _chartRequest = new();

        //Class instaces
        Random _random = new();
        ToolTip _tooltip;
        private Color myColor;

        private bool isRotated;
        private bool isHiden;
        private bool isInitial = true;

        public ChartForm(DataGridForm dataGridForm, ColorCodeManager colorCodeManager, ColorPaletteManager colorPaletteManager) : base()
        {
            InitializeComponent();
            _dataGridForm = dataGridForm;
            _colorCodeManager = colorCodeManager;
            _colorPaletteManager = colorPaletteManager;
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            areaChart.Series.Clear();
            areaChart.AntiAliasing = AntiAliasingStyles.All;

            _tooltip = new ToolTip();
            _tooltip.SetToolTip(this.buttonSave, "Save");
            _tooltip.SetToolTip(this.buttonUpdate, "Update Chart");

            //fetch color palettes from database
            _colorPalettes = _colorPaletteManager.GetAll();

            //palette type combobox
            List<string> paletteTypes = new List<string>();
            foreach (var colorPalette in _colorPalettes.Data)
                paletteTypes.Add(colorPalette.PaletteType);

            comboBoxPaletteType.Items.AddRange(paletteTypes.Distinct().ToArray());
            comboBoxPaletteType.SelectedIndex = 2;

            //axis value size combobox
            comboBoxAxisValueSize.Items.AddRange(new string[] { "6", "7", "8", "9", "10" });
            comboBoxAxisValueSize.SelectedIndex = 1;

            //X axis interval combobox
            comboBoxXAxisInterval.Items.AddRange(new string[] { "1", "2", "3", "4", "5" });
            comboBoxXAxisInterval.SelectedIndex = 0;

            //grid width combobox
            comboBoxGridWidth.Items.AddRange(new string[] { "0", "1", "2", "3" });
            comboBoxGridWidth.SelectedIndex = 1;

            //line width combobox
            comboBoxLineWidth.Items.AddRange(new string[] { "1", "2", "3", "4", "5" });
            comboBoxLineWidth.SelectedIndex = 1;

            //area border combobox
            comboBoxAreaBorder.Items.AddRange(new string[] { "0", "1", "2", "3", });
            comboBoxAreaBorder.SelectedIndex = 1;

            //grid color combobox
            ColorComboboxHandler(comboBoxGridColor);
            comboBoxGridColor.SelectedIndex = 25;

            //line color combobox
            ColorComboboxHandler(comboBoxLineColor);
            comboBoxLineColor.SelectedIndex = 8;

            //area border color combobox
            ColorComboboxHandler(comboBoxAreaBorderColor);
            comboBoxAreaBorderColor.SelectedIndex = 138;

            //grid style combobox
            comboBoxGridStyle.Items.AddRange(new string[] { "Not", "Dash", "Dash Dot", "Dash Dot Dot", "Dot", "Solid" });
            comboBoxGridStyle.SelectedIndex = 5;

            isInitial = false;
        }

        #region UI Handler

        private void ColorComboboxHandler(System.Windows.Forms.ComboBox comboBox)
        {
            comboBox.DataSource = typeof(Color).GetProperties()
                                                        .Where(x => x.PropertyType == typeof(Color))
                                                        .Select(x => x.GetValue(null)).ToList();
            comboBox.MaxDropDownItems = 10;
            comboBox.IntegralHeight = false;
            comboBox.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.DrawItem += (sender, e) => comboBox_DrawItem(sender, e, comboBox);
        }

        private void comboBox_DrawItem(object sender, DrawItemEventArgs e, System.Windows.Forms.ComboBox me)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                var txt = me.GetItemText(me.Items[e.Index]);
                var color = (Color)me.Items[e.Index];
                var r1 = new System.Drawing.Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1,
                    2 * (e.Bounds.Height - 2), e.Bounds.Height - 2);
                var r2 = System.Drawing.Rectangle.FromLTRB(r1.Right + 2, e.Bounds.Top,
                    e.Bounds.Right, e.Bounds.Bottom);
                using (var b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, r1);
                e.Graphics.DrawRectangle(Pens.Black, r1);
                TextRenderer.DrawText(e.Graphics, txt, me.Font, r2,
                    me.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }

        #endregion

        public async void buttonUpdate_Click(object sender, EventArgs e, ChartRequest filteredRequest = null)
        {
            if (!_dataGridForm.isDataListed)
            {
                MessageBox.Show("no data available");
                return;
            }

            if (filteredRequest == null)
            {
                _chartRequest = _dataGridForm.GenerateChartData();
            }
            else
            {
                _chartRequest = filteredRequest;
            }

            //generates color list according to palette type
            ColorPresentationAlgorithm();

            areaChart.Series.Clear();
            var chartArea = areaChart.ChartAreas[0];

            if (areaChart.Titles.Count == 0)
                areaChart.Titles.Add("");
            areaChart.Titles[0].Text = _chartRequest.ChartDesignation + " Capacity";

            //Chart Area Formating
            chartArea.AlignmentOrientation = AreaAlignmentOrientations.All;
            chartArea.AlignmentStyle = AreaAlignmentStyles.All;

            //Axis X Formating
            chartArea.AxisX.Interval = short.Parse(comboBoxXAxisInterval.Text);
            chartArea.AxisX.MajorGrid.LineWidth = short.Parse(comboBoxGridWidth.Text);
            chartArea.AxisX.MajorGrid.LineColor = (Color)comboBoxGridColor.SelectedValue;
            chartArea.AxisX.LineColor = (Color)comboBoxGridColor.SelectedValue;
            chartArea.AxisX.MajorGrid.LineDashStyle = (ChartDashStyle)comboBoxGridStyle.SelectedIndex;

            if (isHiden)
            {
                chartArea.AxisX.MinorGrid.Enabled = true;
                chartArea.AxisX.MinorGrid.LineWidth = 1;
                chartArea.AxisX.MinorGrid.LineColor = Color.LightGray;
                chartArea.AxisX.MinorGrid.LineDashStyle = ChartDashStyle.Dot;
            }
            else
                chartArea.AxisX.MinorGrid.Enabled = false;

            chartArea.AxisX.IntervalType = DateTimeIntervalType.Months;
            chartArea.AxisX.LabelStyle.Format = "MMM-yy";

            if (isRotated)
                chartArea.AxisX.LabelStyle.Angle = 90;
            else
                chartArea.AxisX.LabelStyle.Angle = 0;

            //chartArea.AxisX.LabelStyle.ForeColor = Color.DarkGray;
            chartArea.AxisX.LabelStyle.Font = new Font("Calibri", short.Parse(comboBoxAxisValueSize.Text));
            chartArea.AxisX.Minimum = _chartRequest.Months[0];
            chartArea.AxisX.Maximum = _chartRequest.Months[_chartRequest.Months.Count - 1];

            //Axis Y Formating
            chartArea.AxisY.MajorGrid.LineWidth = short.Parse(comboBoxGridWidth.Text);
            chartArea.AxisY.MajorGrid.LineColor = (Color)comboBoxGridColor.SelectedValue;
            chartArea.AxisY.LineColor = (Color)comboBoxGridColor.SelectedValue;
            chartArea.AxisY.MajorGrid.LineDashStyle = (ChartDashStyle)comboBoxGridStyle.SelectedIndex;

            if (isHiden)
            {
                chartArea.AxisY.MinorGrid.Enabled = true;
                chartArea.AxisY.MinorGrid.LineWidth = 1;
                chartArea.AxisY.MinorGrid.LineColor = Color.LightGray;
                chartArea.AxisY.MinorGrid.LineDashStyle = ChartDashStyle.Dot;
            }
            else
                chartArea.AxisY.MinorGrid.Enabled = false;

            //chartArea.AxisY.LabelStyle.ForeColor = Color.DarkGray;
            chartArea.AxisY.LabelStyle.Font = new Font("Calibri", short.Parse(comboBoxAxisValueSize.Text));

            //capacity areas
            for (int i = 1; i < _chartRequest.Legends.Count; i++)
            {
                if (_chartRequest.isActive[i])
                {
                    //myColor = Color.FromArgb(238 - (i * (238 - 204) / divider), 217 + (i * (247 - 217) / divider), 145 + (i * (244 - 145) / divider));
                    AddSeriaToChart(_chartRequest.Legends[i], _chartRequest.Series[i], _chartRequest.Months, SeriesChartType.StackedArea, _colorList[i - 1], short.Parse(comboBoxAreaBorder.Text));
                }
            }

            //for department capacity line
            if (_chartRequest.isActive[0])
            {
                AddSeriaToChartLine(_chartRequest.Legends[0], _chartRequest.Series[0], _chartRequest.Months, SeriesChartType.Line, short.Parse(comboBoxLineWidth.Text));
            }

            for (int i = 0; i < areaChart.Legends.Count; i++)
            {
                if (_chartRequest.isActive[i])
                {
                    areaChart.Legends[i].Alignment = StringAlignment.Center;
                    areaChart.Legends[i].Font = new Font("Calibri", 8);
                    areaChart.Legends[i].AutoFitMinFontSize = 7;
                    areaChart.Legends[i].IsTextAutoFit = true;
                    areaChart.Legends[i].LegendStyle = LegendStyle.Table;
                }
            }
        }

        public async void buttonUpdate_Click(object sender, EventArgs e)
        {
            buttonUpdate.Click += (sender, e) => buttonUpdate_Click(sender, e, null);
        }

        private void AddSeriaToChartLine(string serieName, List<double> data, List<double> months, SeriesChartType type, int borderWidth = 1)
        {
            System.Windows.Forms.DataVisualization.Charting.Series newSerie = areaChart.Series.Add(serieName);
            newSerie.Color = (Color)comboBoxLineColor.SelectedValue;
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

        private void AddSeriaToChart(string serieName, List<double> data, List<double> months, SeriesChartType type, Color areaColor, int borderWidth = 1)
        {
            System.Windows.Forms.DataVisualization.Charting.Series newSerie = areaChart.Series.Add(serieName);
            newSerie.Color = areaColor;
            newSerie.BorderColor = (Color)comboBoxAreaBorderColor.SelectedValue;
            newSerie.XValueType = ChartValueType.DateTime;
            newSerie.Legend = "Legend1";
            newSerie.ChartArea = "ChartArea1";
            newSerie.ChartType = type;
            newSerie.BorderWidth = borderWidth;
            newSerie.ToolTip = serieName;
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

        private void comboBoxPaletteType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxColorPalette.Items.Clear();

            //color palette combobox changes
            foreach (var colorPalette in _colorPalettes.Data)
            {
                if (colorPalette.PaletteType == comboBoxPaletteType.Text)
                {
                    comboBoxColorPalette.Items.Add(colorPalette.PaletteDesignation);
                    comboBoxColorPalette.SelectedIndex = 0;
                }
            }
        }

        private void ColorPresentationAlgorithm()
        {
            _colorList.Clear();

            //project capacity data
            int colorCount = _chartRequest.Legends.Count;
            int colorIndex = 0;
            //int colorIndex = _random.Next(colorList.Count);

            //get color list according to combobox palette selection
            foreach (var colorPalette in _colorPalettes.Data)
            {
                if (colorPalette.PaletteDesignation == comboBoxColorPalette.Text)
                {
                    _colorDetails = _colorCodeManager.GetColorCodeDetailsByPaletteId(colorPalette.ColorPaletteId);
                    break;
                }
            }

            if (comboBoxPaletteType.Text == "Monochromatic")
            {
                //generates monochromatic type color list
                Color mono1 = _colorDetails.Data[0].GetColorCode;
                Color mono2 = _colorDetails.Data[1].GetColorCode;
                int R1, G1, B1;
                for (int i = 0; i < colorCount; i++)
                {
                    R1 = mono1.R + (i * ((mono2.R - mono1.R) / colorCount));
                    G1 = mono1.G + (i * ((mono2.G - mono1.G) / colorCount));
                    B1 = mono1.B + (i * ((mono2.B - mono1.B) / colorCount));

                    _colorList.Add(Color.FromArgb(R1, G1, B1));
                }
            }
            else if (comboBoxPaletteType.Text == "Gradient")
            {
                //generates gradient type color list
                //3 colors gredient
                if (_colorDetails.Data.Count > 2)
                {
                    Color grad1 = _colorDetails.Data[0].GetColorCode;
                    Color grad2 = _colorDetails.Data[1].GetColorCode;
                    Color grad3 = _colorDetails.Data[2].GetColorCode;
                    colorIndex = 0;

                    int R1, G1, B1, divider;
                    divider = colorCount / 2;
                    for (int i = 0; i < colorCount; i++)
                    {
                        if (i < colorCount / 2)
                        {
                            R1 = grad1.R + (i * ((grad2.R - grad1.R) / divider));
                            G1 = grad1.G + (i * ((grad2.G - grad1.G) / divider));
                            B1 = grad1.B + (i * ((grad2.B - grad1.B) / divider));
                        }
                        else
                        {
                            R1 = grad2.R + (colorIndex * ((grad3.R - grad2.R) / divider));
                            G1 = grad2.G + (colorIndex * ((grad3.G - grad2.G) / divider));
                            B1 = grad2.B + (colorIndex * ((grad3.B - grad2.B) / divider));
                            colorIndex++;
                        }
                        _colorList.Add(Color.FromArgb(R1, G1, B1));
                    }
                }
                //2 colors gradient
                else
                {
                    Color grad1 = _colorDetails.Data[0].GetColorCode;
                    Color grad2 = _colorDetails.Data[1].GetColorCode;
                    int R1, G1, B1;
                    for (int i = 0; i < colorCount; i++)
                    {
                        R1 = grad1.R + (i * ((grad2.R - grad1.R) / colorCount));
                        G1 = grad1.G + (i * ((grad2.G - grad1.G) / colorCount));
                        B1 = grad1.B + (i * ((grad2.B - grad1.B) / colorCount));

                        _colorList.Add(Color.FromArgb(R1, G1, B1));
                    }
                }

            }
            else
            {
                //generates area type color list
                for (int i = 0; i < colorCount; i++)
                {
                    if (colorIndex >= _colorDetails.Data.Count - 1)
                        colorIndex = 0;

                    _colorList.Add(_colorDetails.Data[colorIndex].GetColorCode);
                    colorIndex++;
                }
            }
        }

        #region UI events

        private void buttonShowHide_Click(object sender, EventArgs e)
        {
            if (!isInitial)
            {
                if (isHiden)
                    isHiden = false;
                else
                    isHiden = true;

                buttonUpdate_Click(sender, e, _chartRequest);
            }
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            if (!isInitial)
            {
                if (isRotated)
                    isRotated = false;
                else
                    isRotated = true;

                buttonUpdate_Click(sender, e, _chartRequest);
            }
        }

        private void comboBoxColorPalette_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInitial)
            {
                buttonUpdate_Click(sender, e, _chartRequest);
            }
        }

        private void comboBoxAxisValueSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInitial)
            {
                buttonUpdate_Click(sender, e, _chartRequest);
            }
        }

        private void comboBoxXAxisInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInitial)
            {
                buttonUpdate_Click(sender, e, _chartRequest);
            }
        }

        private void comboBoxGridColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInitial)
            {
                buttonUpdate_Click(sender, e, _chartRequest);
            }
        }

        private void comboBoxGridWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInitial)
            {
                buttonUpdate_Click(sender, e, _chartRequest);
            }
        }

        private void comboBoxGridStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInitial)
            {
                buttonUpdate_Click(sender, e, _chartRequest);
            }
        }

        private void comboBoxLineWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInitial)
            {
                buttonUpdate_Click(sender, e, _chartRequest);
            }
        }

        private void comboBoxLineColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInitial)
            {
                buttonUpdate_Click(sender, e, _chartRequest);
            }
        }

        private void comboBoxAreaBorder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInitial)
            {
                buttonUpdate_Click(sender, e, _chartRequest);
            }
        }

        private void comboBoxAreaBorderColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInitial)
            {
                buttonUpdate_Click(sender, e, _chartRequest);
            }
        }

        #endregion

        #region Filter Series Function

        private void buttonFilterSeries_Click(object sender, EventArgs e)
        {
            if (filterSeriesForm == null)
            {
                filterSeriesForm = new FilterSeriesForm(_chartRequest);
                filterSeriesForm.FormClosed += FilterSeriesForm_FormClosed;
                Point buttonLocation = new Point(buttonFilterSeries.Location.X - 210, buttonFilterSeries.Location.Y + 25);
                filterSeriesForm.Location = this.PointToScreen(buttonLocation);
                filterSeriesForm.ShowDialog();
            }
            else
                filterSeriesForm.Activate();
        }

        private void FilterSeriesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _chartRequest = filterSeriesForm._filteredRequest;
            buttonUpdate_Click(sender, e, _chartRequest);
            filterSeriesForm = null;
        }

        #endregion
    }
}
