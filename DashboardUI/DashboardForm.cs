using Business.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DashboardUI
{
    public partial class DashboardForm : Form
    {
        ProjectManager _projectManager;
        DepartmentManager _departmentManager;
        ManagementManager _managementManager;
        CategoryManager _categoryManager;
        UserManager _userManager;
        DepartmentCapacityManager _departmentCapacityManager;
        ProjectCapacityManager _projectCapacityManager;
        ColorPaletteManager _colorPaletteManager;
        ColorCodeManager _colorCodeManager;

        //Database cache data
        IDataResult<List<Entities.Concrete.ColorPalette>> _colorPalettes;
        IDataResult<List<ColorCodeDetailDto>> _colorDetails;
        IDataResult<List<Project>> _projectDatas;
        IDataResult<List<Management>> _managementDatas;
        IDataResult<List<Department>> _departmentDatas;
        IDataResult<List<DepartmentCapacityDetailDto>> _departmentCapacityDetailDatas;
        IDataResult<List<ProjectCapacityDetailDto>> _projectCapacityDetailDatas;
        IDataResult<List<DepartmentCapacity>> _departmentCapacityDates;

        List<Color> _colorList = new();
        List<Project> _completedProjects = new();
        List<Project> _ongiongProjects = new();

        private bool _isRotated = true;
        private bool _isProgressing = true;
        private bool _isHiddenWorkAgainstChart = true;
        private bool _isHiddenProjectChart = true;
        private bool _isHiddenCapacityChart = true;
        int _selectedYear = DateTime.Now.Year;
        private double _totalCapacityStart;
        private double _totalCapacityEnd;
        private double _assignedCapacityStart;
        private double _assignedCapacityEnd;
        private DateTime _startDate;
        private DateTime _endDate;

        public DashboardForm(ManagementManager managementManager, DepartmentManager departmentManager, ProjectManager projectManager, CategoryManager categoryManager,
            UserManager userManager, DepartmentCapacityManager departmentCapacityManager, ProjectCapacityManager projectCapacityManager, ColorCodeManager colorCodeManager, ColorPaletteManager colorPaletteManager)
        {
            _managementManager = managementManager;
            _departmentManager = departmentManager;
            _projectManager = projectManager;
            _categoryManager = categoryManager;
            _userManager = userManager;
            _projectCapacityManager = projectCapacityManager;
            _departmentCapacityManager = departmentCapacityManager;
            _colorCodeManager = colorCodeManager;
            _colorPaletteManager = colorPaletteManager;
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            //fetch color palettes from database
            _colorPalettes = _colorPaletteManager.GetAll();

            //palette type combobox
            List<string> paletteTypes = new List<string>();
            foreach (var colorPalette in _colorPalettes.Data)
                paletteTypes.Add(colorPalette.PaletteType);

            comboBoxPaletteType.Items.AddRange(paletteTypes.Distinct().ToArray());
            comboBoxPaletteType.SelectedIndex = 1;

            comboBoxInterval.Items.AddRange(new string[] { "Auto", "1", "2", "3", "4", "5", "6" });

            _projectDatas = _projectManager.GetAll();
            _managementDatas = _managementManager.GetAll();
            _departmentDatas = _departmentManager.GetAll();
            _departmentCapacityDetailDatas = _departmentCapacityManager.GetDepartmentCapacityDetails();
            _projectCapacityDetailDatas = _projectCapacityManager.GetProjectCapacityDetails();
            _departmentCapacityDates = _departmentCapacityManager.GetAllUniqueDate();

            UpdateCharts();
        }

        private async void UpdateCharts()
        {
            GenerateProjectsChart();
            GenerateCapacitiesChart(new DateTime(_selectedYear, dateTimeChart2.Value.Month, 1));
            GeneratePercentageCapacityChart(new DateTime(_selectedYear, dateTimeChart3.Value.Month, 1));
            GenerateCapacityAgainstWorkloadChart();
            GenerateInfoCards();
        }

        //CHART 1 - DONE
        private void GenerateProjectsChart()
        {
            var newSerie = chartProjects.Series["Series1"];
            newSerie.Points.Clear();
            newSerie.IsValueShownAsLabel = true;

            _completedProjects.Clear();
            _ongiongProjects.Clear();

            foreach (var management in _managementDatas.Data)
            {
                int i = 0;
                foreach (var project in _projectDatas.Data)
                {
                    if (project.IsCompleted)
                        _completedProjects.Add(project);
                    else
                        _ongiongProjects.Add(project);

                    if (project.ManagementId == management.ManagementId)
                    {
                        i++;
                    }
                }
                newSerie.Points.AddXY(management.ManagementName, i);
            }
        }

        //CHART 2 - DONE
        private void GenerateCapacitiesChart(DateTime time)
        {
            var newSerie = chartCapacity.Series["Series1"];
            newSerie.Points.Clear();
            foreach (var departmentDetail in _departmentCapacityDetailDatas.Data)
            {
                if (departmentDetail.Date == time)
                {
                    newSerie.Points.AddXY(departmentDetail.DepartmentName, departmentDetail.DTotalCapacity);
                }
            }



        }

        //CHART 3 - DONE - CORRECTED
        private void GenerateInfoCards()
        {
            //_assignedCapacityStart = 10;
            //_assignedCapacityEnd = 40;

            //_totalCapacityStart = 30;
            //_totalCapacityEnd = 10;

            //_startDate = DateTime.Now;
            //_endDate = DateTime.Now.AddMonths(5);

            double result = _completedProjects.Count * 100 / Math.Abs(_completedProjects.Count + _ongiongProjects.Count);

            //Completed Projects
            labelCompletedProjectsValue.Text = _completedProjects.Count.ToString();
            labelCompletedProjectsSubValue.Text = result.ToString() + "% of all projects";

            //Ongoing Projects
            labelOngoingProjectsValue.Text = _ongiongProjects.Count.ToString();
            labelOngoingProjectsSubValue.Text = (100 - result) + "% of all projects";

            //Total Capacity
            double resultPercentage = (_totalCapacityEnd - _totalCapacityStart) / _totalCapacityStart * 100;
            if (resultPercentage > 0) { pictureBoxUp.Visible = true; pictureBoxDown.Visible = false; }
            else { pictureBoxUp.Visible = false; pictureBoxDown.Visible = true; }
            labelTotalCapacityValue.Text = resultPercentage.ToString("0.0") + "%";
            labelTotalCapacitySubValue.Text = "from " + _startDate.ToString("MMM-yy") + " to " + _endDate.ToString("MMM-yy");

            //Assigned Capacity
            resultPercentage = (_assignedCapacityEnd - _assignedCapacityStart) / _assignedCapacityStart * 100;
            if (resultPercentage > 0) { pictureBoxUp2.Visible = true; pictureBoxDown2.Visible = false; }
            else { pictureBoxUp2.Visible = false; pictureBoxDown2.Visible = true; }
            labelAssignedCapacityValue.Text = resultPercentage.ToString("0.0") + "%";
            labelAssignedCapacitySubValue.Text = "from " + _startDate.ToString("MMM-yy") + " to " + _endDate.ToString("MMM-yy");

        }

        //CHART 4 - NOT WORKED YET
        private void GenerateCapacityAgainstWorkloadChart()
        {
            double totalDepartmentCapacity = 0;
            double totalProjectCapacity = 0;

            var serieSplineArea = chartCapacityAgainstWork.Series["Total Capacity"];

            chartCapacityAgainstWork.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
            chartCapacityAgainstWork.ChartAreas[0].AxisX.LabelStyle.Format = "MMM-yy";
            chartCapacityAgainstWork.ChartAreas[0].AxisX.Minimum = _departmentCapacityDates.Data[0].Date.ToOADate();
            chartCapacityAgainstWork.ChartAreas[0].AxisX.Maximum = _departmentCapacityDates.Data[_departmentCapacityDates.Data.Count - 1].Date.ToOADate();

            chartCapacityAgainstWork.Series.Clear();
            serieSplineArea.Points.Clear();
            //for (int i = 0; i < chartCapacityAgainstWork.Series.Count; i++)
            //{
            //    if (chartCapacityAgainstWork.Series[i] != serieSplineArea)
            //    {
            //        var serieToDelete = chartCapacityAgainstWork.Series[i];
            //        chartCapacityAgainstWork.Series.Remove(serieToDelete);
            //    }
            //}

            foreach (var date in _departmentCapacityDates.Data)
            {
                totalDepartmentCapacity = 0;
                totalProjectCapacity = 0;
                _totalCapacityStart = 0;
                _totalCapacityEnd = 0;
                _startDate = _departmentCapacityDates.Data[0].Date;
                _endDate = _departmentCapacityDates.Data[_departmentCapacityDates.Data.Count - 1].Date;

                foreach (var departmentDetail in _departmentCapacityDetailDatas.Data)
                {
                    if (departmentDetail.Date == date.Date)
                    {
                        totalDepartmentCapacity += departmentDetail.DTotalCapacity;
                    }

                    if (departmentDetail.Date == _startDate)
                    {
                        _totalCapacityStart += departmentDetail.DTotalCapacity;
                    }
                    else if (departmentDetail.Date == _endDate)
                    {
                        _totalCapacityEnd += departmentDetail.DTotalCapacity;
                    }
                }

                var newDataPoint = serieSplineArea.Points.AddXY(date.Date, totalDepartmentCapacity);
            }

            foreach (var management in _managementDatas.Data)
            {
                var newSerie = chartCapacityAgainstWork.Series.Add(management.ManagementName);
                newSerie.ChartType = SeriesChartType.StackedColumn;
                //newSerie.CustomProperties = "MaxPixelPointWidth = 5";

                foreach (var date in _departmentCapacityDates.Data)
                {
                    totalProjectCapacity = 0;
                    _assignedCapacityStart = 0;
                    _assignedCapacityEnd = 0;

                    foreach (var projectDetail in _projectCapacityDetailDatas.Data)
                    {
                        if (projectDetail.Date == date.Date && projectDetail.ManagementId == management.ManagementId)
                        {
                            totalProjectCapacity += projectDetail.PTotalCapacity;
                        }

                        if (projectDetail.Date == _startDate)
                        {
                            _assignedCapacityStart += projectDetail.PTotalCapacity;
                        }
                        else if (projectDetail.Date == _endDate)
                        {
                            _assignedCapacityEnd += projectDetail.PTotalCapacity;
                        }
                    }

                    var newDataPoint = newSerie.Points.AddXY(date.Date, totalProjectCapacity);
                }
            }

            //take spline serie in front (z - order)
            chartCapacityAgainstWork.Series.Remove(serieSplineArea);
            chartCapacityAgainstWork.Series.Insert(chartCapacityAgainstWork.Series.Count, serieSplineArea);
        }

        //DELETE LATER
        private void GenerateCapacityAgainstWorkloadChartBACKUP()
        {
            var serieSplineArea = chartCapacityAgainstWork.Series["Series1"];

            double totalDepartmentCapacity = 0;
            double totalProjectCapacity = 0;
            int index = 0;

            foreach (var management in _managementDatas.Data)
            {
                var newSerie = chartCapacityAgainstWork.Series.Add(management.ManagementName);
                newSerie.ChartType = SeriesChartType.StackedColumn;

                foreach (var date in _departmentCapacityDates.Data)
                {
                    totalDepartmentCapacity = 0;

                    foreach (var department in _departmentDatas.Data)
                    {
                        foreach (var departmentDetail in _departmentCapacityDetailDatas.Data)
                        {
                            if (department.ManagementId == management.ManagementId && departmentDetail.Date == date.Date)
                            {
                                totalDepartmentCapacity += departmentDetail.DTotalCapacity;
                            }

                        }

                        //foreach (var projectDetail in _projectCapacityDetailDatas.Data)
                        //{
                        //    totalProjectCapacity += projectDetail.PTotalCapacity;
                        //}

                    }

                    var newDataPoint = serieSplineArea.Points.AddXY(date.Date, totalDepartmentCapacity);
                }
            }
        }

        //CHART 5 - DONE
        private void GeneratePercentageCapacityChart(DateTime time)
        {
            var newSerie = chartCapacityPercentage.Series["Series1"];
            newSerie.IsValueShownAsLabel = false;

            double totalDepartmentCapacity = 0;
            double totalProjectCapacity = 0;

            foreach (var departmentDetail in _departmentCapacityDetailDatas.Data)
            {
                if (departmentDetail.Date == time)
                {
                    totalDepartmentCapacity += departmentDetail.DTotalCapacity;

                }
            }
            foreach (var projectDetail in _projectCapacityDetailDatas.Data)
            {
                if (projectDetail.Date == time)
                {
                    totalProjectCapacity += projectDetail.PTotalCapacity;
                }
            }

            double tempCapacity = totalDepartmentCapacity;

            if (totalProjectCapacity >= totalDepartmentCapacity)
                totalDepartmentCapacity = totalProjectCapacity;

            double percentage = (totalDepartmentCapacity - totalProjectCapacity) / totalDepartmentCapacity * 100;
            newSerie.Points[0].SetValueXY("", totalDepartmentCapacity);
            newSerie.Points[1].SetValueXY("", totalProjectCapacity);
            newSerie.Points[2].SetValueXY("", totalDepartmentCapacity - totalProjectCapacity);

            labelPercentage.Text = percentage.ToString("0.0") + "%";

            if (percentage == 0)
                labelStatus.Text = "OVER CAPACITY";
            else
                labelStatus.Text = "CAPACITY AVAILABLE";

            labelSubStatus.Text = "Total Department Capacity: " + tempCapacity
                   + System.Environment.NewLine + "Total Assigned Capacity: " + totalProjectCapacity;

            newSerie.Points[0].Color = Color.White;
            newSerie.Points[0].BackGradientStyle = GradientStyle.None;
        }

        private void buttonOverall_Click(object sender, EventArgs e)
        {
            labelDashboard.Text = "DATA RANGE : OVERALL";
            _selectedYear = DateTime.Now.Year;
            dateTimeChart2.Value = new DateTime(_selectedYear, 1, 1);
            dateTimeChart3.Value = new DateTime(_selectedYear, 1, 1);
            _managementDatas = _managementManager.GetAll();
            _departmentDatas = _departmentManager.GetAll();
            _projectDatas = _projectManager.GetAll();
            _departmentCapacityDetailDatas = _departmentCapacityManager.GetDepartmentCapacityDetails();
            _projectCapacityDetailDatas = _projectCapacityManager.GetProjectCapacityDetails();
            _departmentCapacityDates = _departmentCapacityManager.GetAllUniqueDate();
            UpdateCharts();
        }

        private void buttonThisYear_Click(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime endDate = new DateTime(DateTime.Now.Year, 12, 1);
            _selectedYear = DateTime.Now.Year;
            dateTimeChart2.Value = startDate;
            dateTimeChart3.Value = startDate;

            labelDashboard.Text = "DATA RANGE : " + _selectedYear;

            _managementDatas = _managementManager.GetAll();
            _departmentDatas = _departmentManager.GetAll();
            _projectDatas = _projectManager.GetAllByDateBetween(startDate, endDate);
            _departmentCapacityDetailDatas = _departmentCapacityManager.GetAllByDateBetween(startDate, endDate);
            _projectCapacityDetailDatas = _projectCapacityManager.GetProjectCapacityDetailsByDateBetween(startDate, endDate);
            _departmentCapacityDates = _departmentCapacityManager.GetAllUniqueDateBetween(startDate, endDate);
            UpdateCharts();
        }

        private void buttonLastYear_Click(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime(DateTime.Now.Year - 1, 1, 1);
            DateTime endDate = new DateTime(DateTime.Now.Year - 1, 12, 1);
            _selectedYear = DateTime.Now.Year - 1;
            dateTimeChart2.Value = startDate;
            dateTimeChart3.Value = startDate;

            labelDashboard.Text = "DATA RANGE : " + _selectedYear;

            _managementDatas = _managementManager.GetAll();
            _departmentDatas = _departmentManager.GetAll();
            _projectDatas = _projectManager.GetAllByDateBetween(startDate, endDate);
            _departmentCapacityDetailDatas = _departmentCapacityManager.GetAllByDateBetween(startDate, endDate);
            _projectCapacityDetailDatas = _projectCapacityManager.GetProjectCapacityDetailsByDateBetween(startDate, endDate);
            _departmentCapacityDates = _departmentCapacityManager.GetAllUniqueDateBetween(startDate, endDate);

            UpdateCharts();
        }

        private void buttonCustom_Click(object sender, EventArgs e)
        {

            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;
            _selectedYear = dateTimePickerEnd.Value.Year;
            dateTimeChart2.Value = startDate;
            dateTimeChart3.Value = startDate;

            labelDashboard.Text = "DATA RANGE : " + dateTimePickerStart.Value.Year + " - " + dateTimePickerEnd.Value.Year;

            _managementDatas = _managementManager.GetAll();
            _departmentDatas = _departmentManager.GetAll();
            _projectDatas = _projectManager.GetAllByDateBetween(startDate, endDate);
            _departmentCapacityDetailDatas = _departmentCapacityManager.GetAllByDateBetween(startDate, endDate);
            _projectCapacityDetailDatas = _projectCapacityManager.GetProjectCapacityDetailsByDateBetween(startDate, endDate);
            _departmentCapacityDates = _departmentCapacityManager.GetAllUniqueDateBetween(startDate, endDate);

            UpdateCharts();

        }

        private void dateTimeChart2_ValueChanged(object sender, EventArgs e)
        {
            GenerateCapacitiesChart(new DateTime(dateTimeChart3.Value.Year, dateTimeChart2.Value.Month, 1));
        }

        private void dateTimeChart3_ValueChanged(object sender, EventArgs e)
        {
            GeneratePercentageCapacityChart(new DateTime(dateTimeChart3.Value.Year, dateTimeChart3.Value.Month, 1));
        }

        private void buttonShowHideProjectChart_Click(object sender, EventArgs e)
        {
            if (_isHiddenProjectChart)
            {
                chartProjects.Legends[0].Enabled = true;
                _isHiddenProjectChart = false;
            }
            else
            {
                chartProjects.Legends[0].Enabled = false;
                _isHiddenProjectChart = true;
            }
        }

        private void buttonShowHideChartCapacity_Click(object sender, EventArgs e)
        {
            if (_isHiddenCapacityChart)
            {
                chartCapacity.Legends[0].Enabled = true;
                _isHiddenCapacityChart = false;
            }
            else
            {
                chartCapacity.Legends[0].Enabled = false;
                _isHiddenCapacityChart = true;
            }
        }

        private void comboBoxInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartCapacityAgainstWork.ChartAreas[0].AxisX.Interval = comboBoxInterval.SelectedIndex;
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            if (_isRotated)
            {
                chartCapacityAgainstWork.ChartAreas[0].AxisX.LabelStyle.Angle = 90;
                _isRotated = false;
            }
            else
            {
                chartCapacityAgainstWork.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
                _isRotated = true;
            }
        }

        private void buttonShowHideWorkAgainst_Click(object sender, EventArgs e)
        {
            if (_isHiddenProjectChart)
            {
                chartCapacityAgainstWork.Legends[0].Enabled = true;
                _isHiddenProjectChart = false;
            }
            else
            {
                chartCapacityAgainstWork.Legends[0].Enabled = false;
                _isHiddenProjectChart = true;
            }
        }

        #region Color Palette Selection

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

        private void GenerateColorList(int legendsCount)
        {
            _colorList.Clear();

            //project capacity data
            int colorCount = legendsCount;
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
                    if (i >= _colorDetails.Data.Count)
                        colorIndex = 0;

                    _colorList.Add(_colorDetails.Data[colorIndex].GetColorCode);
                    colorIndex++;
                }
            }
        }

        #endregion

    }
}
