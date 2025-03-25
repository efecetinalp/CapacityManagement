using Business.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        IDataResult<List<Project>> _projectDatas;
        IDataResult<List<Management>> _managementDatas;
        IDataResult<List<Department>> _departmentDatas;
        IDataResult<List<DepartmentCapacityDetailDto>> _departmentCapacityDetailDatas;
        IDataResult<List<ProjectCapacityDetailDto>> _projectCapacityDetailDatas;
        IDataResult<List<DepartmentCapacity>> _departmentCapacityDates;

        List<Project> _completedProjects = new();
        List<Project> _ongiongProjects = new();
        private bool _isProgressing = false;
        int _selectedYear = DateTime.Now.Year;

        public DashboardForm(ManagementManager managementManager, DepartmentManager departmentManager, ProjectManager projectManager, CategoryManager categoryManager,
            UserManager userManager, DepartmentCapacityManager departmentCapacityManager, ProjectCapacityManager projectCapacityManager)
        {
            _managementManager = managementManager;
            _departmentManager = departmentManager;
            _projectManager = projectManager;
            _categoryManager = categoryManager;
            _userManager = userManager;
            _projectCapacityManager = projectCapacityManager;
            _departmentCapacityManager = departmentCapacityManager;
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            _projectDatas = _projectManager.GetAll();
            _managementDatas = _managementManager.GetAll();
            _departmentDatas = _departmentManager.GetAll();
            _departmentCapacityDetailDatas = _departmentCapacityManager.GetDepartmentCapacityDetails();
            _projectCapacityDetailDatas = _projectCapacityManager.GetProjectCapacityDetails();
            _departmentCapacityDates = _departmentCapacityManager.GetAllUniqueDate();

            UpdateCharts();
        }

        private void UpdateCharts()
        {
            GenerateProjectsChart();
            GenerateCapacitiesChart(new DateTime(_selectedYear, dateTimeChart2.Value.Month, 1));
            GeneratePercentageCapacityChart(new DateTime(_selectedYear, dateTimeChart3.Value.Month, 1));
            GenerateCapacityAgainstWorkloadChart();
            GenerateOngoingCompletedProjectsChart();
            GenerateDataGridData(_isProgressing);
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
        private void GenerateOngoingCompletedProjectsChart()
        {
            double result = _completedProjects.Count * 100 / Math.Abs(_completedProjects.Count + _ongiongProjects.Count);

            var newSerie = chartOngoingCompletedProjects.Series["Series1"];
            newSerie.Points.Clear();
            newSerie.IsValueShownAsLabel = true;
            newSerie.Points.AddXY("Completed Projects", _completedProjects.Count);
            newSerie.Label = "Completed project %" + result;

            newSerie = chartOngoingCompletedProjects.Series["Series2"];
            newSerie.Points.Clear();
            newSerie.IsValueShownAsLabel = true;
            newSerie.Points.AddXY("Ongoing Projects", _ongiongProjects.Count);
            newSerie.Label = "Ongoing project %" + (100 - result);
        }

        //CHART 4 - NOT WORKED YET
        private void GenerateCapacityAgainstWorkloadChart()
        {
            double totalDepartmentCapacity = 0;
            double totalProjectCapacity = 0;
            chartCapacityAgainstWork.Series.Clear();
            var serieSplineArea = chartCapacityAgainstWork.Series.Add("Total Capacity");
            serieSplineArea.ChartType = SeriesChartType.SplineArea;

            foreach (var date in _departmentCapacityDates.Data)
            {
                totalDepartmentCapacity = 0;
                totalProjectCapacity = 0;

                foreach (var departmentDetail in _departmentCapacityDetailDatas.Data)
                {
                    if (departmentDetail.Date == date.Date)
                    {
                        totalDepartmentCapacity += departmentDetail.DTotalCapacity;
                    }
                }

                var newDataPoint = serieSplineArea.Points.AddXY(date.Date, totalDepartmentCapacity);
            }

            foreach (var management in _managementDatas.Data)
            {
                var newSerie = chartCapacityAgainstWork.Series.Add(management.ManagementName);
                newSerie.ChartType = SeriesChartType.StackedColumn;

                foreach (var date in _departmentCapacityDates.Data)
                {
                    totalProjectCapacity = 0;

                    foreach (var projectDetail in _projectCapacityDetailDatas.Data)
                    {
                        if (projectDetail.Date == date.Date && projectDetail.ManagementId == management.ManagementId)
                        {
                            totalProjectCapacity += projectDetail.PTotalCapacity;
                        }
                    }

                    var newDataPoint = newSerie.Points.AddXY(date.Date, totalProjectCapacity);
                }
            }
        }

        //delete later
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
            foreach (var department in _departmentDatas.Data)
            {
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
            }

            if (totalProjectCapacity >= totalDepartmentCapacity)
                totalProjectCapacity = totalDepartmentCapacity;

            newSerie.Points[0].SetValueXY("", totalDepartmentCapacity);
            newSerie.Points[1].SetValueXY("", totalProjectCapacity);
            newSerie.Points[2].SetValueXY("", totalDepartmentCapacity - totalProjectCapacity);
            labelPercentage.Text = ((totalDepartmentCapacity - totalProjectCapacity) / totalDepartmentCapacity * 100).ToString("0.0") + "%";

            newSerie.Points[0].Color = Color.White;
            newSerie.Points[0].BackGradientStyle = GradientStyle.None;
        }

        //DATAGRID - DONE
        private void GenerateDataGridData(bool isProgressing)
        {
            dataGridViewOngoingProjects.DataSource = null;
            dataGridViewOngoingProjects.Rows.Clear();
            dataGridViewOngoingProjects.Columns.Clear();

            if (!isProgressing)
            {
                dataGridViewOngoingProjects.DataSource = _completedProjects;
                dataGridViewOngoingProjects.Columns[5].HeaderText = "Completed Projects";
            }
            else
            {
                dataGridViewOngoingProjects.DataSource = _ongiongProjects;
                dataGridViewOngoingProjects.Columns[5].HeaderText = "Ongoing Projects";
            }

            for (int i = 0; i < dataGridViewOngoingProjects.Columns.Count; i++)
            {
                if (i != 5)
                    dataGridViewOngoingProjects.Columns[i].Visible = false;
            }

        }

        private void buttonOverall_Click(object sender, EventArgs e)
        {
            _selectedYear = DateTime.Now.Year;
            _managementDatas = _managementManager.GetAll();
            _departmentDatas = _departmentManager.GetAll();
            _projectDatas = _projectManager.GetAll();
            _departmentCapacityDetailDatas = _departmentCapacityManager.GetDepartmentCapacityDetails();
            _projectCapacityDetailDatas = _projectCapacityManager.GetProjectCapacityDetails();
            UpdateCharts();
        }

        private void buttonThisYear_Click(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime endDate = new DateTime(DateTime.Now.Year, 12, 1);
            _selectedYear = DateTime.Now.Year;

            _managementDatas = _managementManager.GetAll();
            _departmentDatas = _departmentManager.GetAll();
            _projectDatas = _projectManager.GetAllByDateBetween(startDate, endDate);
            _departmentCapacityDetailDatas = _departmentCapacityManager.GetAllByDateBetween(startDate, endDate);
            _projectCapacityDetailDatas = _projectCapacityManager.GetProjectCapacityDetailsByDateBetween(startDate, endDate);

            UpdateCharts();
        }

        private void buttonLastYear_Click(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime(DateTime.Now.Year - 1, 1, 1);
            DateTime endDate = new DateTime(DateTime.Now.Year - 1, 12, 1);
            _selectedYear = DateTime.Now.Year - 1;

            _managementDatas = _managementManager.GetAll();
            _departmentDatas = _departmentManager.GetAll();
            _projectDatas = _projectManager.GetAllByDateBetween(startDate, endDate);
            _departmentCapacityDetailDatas = _departmentCapacityManager.GetAllByDateBetween(startDate, endDate);
            _projectCapacityDetailDatas = _projectCapacityManager.GetProjectCapacityDetailsByDateBetween(startDate, endDate);

            UpdateCharts();
        }

        private void buttonCustom_Click(object sender, EventArgs e)
        {
            //FOR BACKUP - DELETE LATER
            //_projectDetailDatas = _projectManager.GetProjectDetails();
            //_projectDetailDatas = _projectManager.GetProjectDetailsByDateBetween();
            //_managementDatas = _managementManager.GetAll();
            //_departmentDatas = _departmentManager.GetAll();
            //_departmentCapacityDetailDatas = _departmentCapacityManager.GetAllByDepartmentId();
            //_departmentCapacityDetailDatas = _departmentCapacityManager.GetAllByDateBetween(new DateTime(2024, 6, 1));
            //_projectCapacityDetailDatas = _projectCapacityManager.GetAllByDepartmentId(new DateTime(2024, 6, 1), new DateTime(2024, 6, 1), department.DepartmentId);
            //_projectCapacityDetailDatas = _projectCapacityManager.GetProjectCapacityDetailsByDateBetweenAndDepartmentId(new DateTime(2024, 6, 1), new DateTime(2024, 6, 1), department.DepartmentId);

            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;
            _selectedYear = dateTimePickerEnd.Value.Year;

            _managementDatas = _managementManager.GetAll();
            _departmentDatas = _departmentManager.GetAll();
            _projectDatas = _projectManager.GetAllByDateBetween(startDate, endDate);
            _departmentCapacityDetailDatas = _departmentCapacityManager.GetAllByDateBetween(startDate, endDate);
            _projectCapacityDetailDatas = _projectCapacityManager.GetProjectCapacityDetailsByDateBetween(startDate, endDate);

            UpdateCharts();

        }

        private void dateTimeChart2_ValueChanged(object sender, EventArgs e)
        {
            GenerateCapacitiesChart(new DateTime(_selectedYear, dateTimeChart2.Value.Month, 1));
        }

        private void dateTimeChart3_ValueChanged(object sender, EventArgs e)
        {
            GeneratePercentageCapacityChart(new DateTime(_selectedYear, dateTimeChart3.Value.Month, 1));
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (!_isProgressing)
            {
                buttonShow.Text = "Show Ongoing";
                _isProgressing = true;
            }
            else
            {
                buttonShow.Text = "Show Completed";
                _isProgressing = false;
            }

            GenerateDataGridData(_isProgressing);
        }
    }
}
