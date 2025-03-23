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

        IDataResult<List<ProjectDetailDto>> _projectDetailDatas;
        IDataResult<List<Management>> _managementDatas;
        IDataResult<List<Department>> _departmentDatas;
        IDataResult<List<DepartmentCapacityDetailDto>> _departmentCapacityDetailDatas;
        IDataResult<List<ProjectCapacityDetailDto>> _projectCapacityDetailDatas;



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
            _projectDetailDatas = _projectManager.GetProjectDetails();
            _managementDatas = _managementManager.GetAll();
            _departmentDatas = _departmentManager.GetAll();

            GenerateProjectsChart();
            GenerateCapacitiesChart();
            GenerateCapacityAgainstWorkloadChart();
            GenerateOngoingCompletedProjectsChart();
            GeneratePercentageCapacityChart();
            GenerateDataGridData(false);
        }

        //DELETE LATER
        private void buttonRefresh_Click(object sender, EventArgs e)
        {


        }

        //CHART 1
        private void GenerateProjectsChart()
        {
            var newSerie = chartProjects.Series["Series1"];
            newSerie.Points.Clear();
            newSerie.IsValueShownAsLabel = true;
            foreach (var management in _managementDatas.Data)
            {
                int i = 0;
                foreach (var project in _projectDetailDatas.Data)
                {
                    if (project.ManagementId == management.ManagementId)
                    {
                        i++;
                    }
                }
                newSerie.Points.AddXY(management.ManagementName, i);
            }
        }

        //CHART 2
        //NOT CORRECTLY WORKING - FIX DEPARTMENTCAPACITY GET METHOD
        private void GenerateCapacitiesChart()
        {
            var newSerie = chartCapacity.Series["Series1"];
            newSerie.Points.Clear();
            newSerie.IsValueShownAsLabel = true;
            foreach (var department in _departmentDatas.Data)
            {
                _departmentCapacityDetailDatas = _departmentCapacityManager.GetAllByDateAndDepartmentName(new DateTime(2024, 6, 1), department.DepartmentName);

                foreach (var departmentDetail in _departmentCapacityDetailDatas.Data)
                {
                    newSerie.Points.AddXY(department.DepartmentName, departmentDetail.DTotalCapacity);
                }
            }
        }

        //CHART 3
        //NOT CORRECTLY WORKING - FIX DEPARTMENTCAPACITY GET METHOD
        private void GeneratePercentageCapacityChart()
        {
            var newSerie = chartCapacityPercentage.Series["Series1"];
            newSerie.Points.Clear();
            newSerie.IsValueShownAsLabel = true;

            double totalDepartmentCapacity = 0;
            double totalProjectCapacity = 0;
            foreach (var department in _departmentDatas.Data)
            {
                _departmentCapacityDetailDatas = _departmentCapacityManager.GetAllByDateAndDepartmentName(new DateTime(2024, 6, 1), department.DepartmentName);

                foreach (var departmentDetail in _departmentCapacityDetailDatas.Data)
                {
                    totalDepartmentCapacity += departmentDetail.DTotalCapacity;
                }

                _projectCapacityDetailDatas = _projectCapacityManager.GetProjectCapacityDetailsByDateBetweenAndDepartmentId(new DateTime(2024, 6, 1), new DateTime(2024, 6, 1), department.DepartmentId);
                foreach (var projectDetail in _projectCapacityDetailDatas.Data)
                {
                    totalProjectCapacity += projectDetail.PTotalCapacity;
                }
            }

            newSerie.Points.AddXY("", totalDepartmentCapacity);
            newSerie.Points.AddXY("Capacity", totalProjectCapacity);
            newSerie.Points.AddXY("Available Capacity", totalDepartmentCapacity - totalProjectCapacity);
        }

        //CHART 4
        private void GenerateCapacityAgainstWorkloadChart()
        {
            //var serieSplineArea = chartCapacityAgainstWork.Series["Series1"];
            //serieSplineArea.Points.Clear();
            //serieSplineArea.IsValueShownAsLabel = true;

            //double totalDepartmentCapacity = 0;
            //double totalProjectCapacity = 0;

            //foreach (var department in _departmentDatas.Data)
            //{
            //    _departmentCapacityDetailDatas = _departmentCapacityManager.GetAllByDateBetweenAndDepartmentName(new DateTime(2024, 1, 1), new DateTime(2025, 1, 1), department.DepartmentName);

            //    foreach (var departmentDetail in _departmentCapacityDetailDatas.Data)
            //    {
            //        totalDepartmentCapacity += departmentDetail.DTotalCapacity;
            //    }

            //    _projectCapacityDetailDatas = _projectCapacityManager.GetProjectCapacityDetailsByDateBetweenAndDepartmentId(new DateTime(2024, 6, 1), new DateTime(2024, 6, 1), department.DepartmentId);
            //    foreach (var projectDetail in _projectCapacityDetailDatas.Data)
            //    {
            //        totalProjectCapacity += projectDetail.PTotalCapacity;
            //    }
            //}
            
        }

        //CHART 5
        private void GenerateOngoingCompletedProjectsChart()
        {
            int completedProjects = 0;
            int progressingProjects = 0;

            foreach (var project in _projectDetailDatas.Data)
            {
                if (project.IsCompleted)
                    completedProjects++;
                else
                    progressingProjects++;
            }

            var newSerie = chartOngoingCompletedProjects.Series["Series1"];
            newSerie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            newSerie.Points.Clear();
            newSerie.IsValueShownAsLabel = true;

            newSerie.Points.AddXY("Completed Projects", completedProjects);
            newSerie.Points.AddXY("Ongoing Projects", progressingProjects);
        }

        //DATAGRID
        private void GenerateDataGridData(bool isProgressing)
        {
            List<ProjectDetailDto> completedProjects = new List<ProjectDetailDto>();
            List<ProjectDetailDto> ongiongProjects = new List<ProjectDetailDto>();


            foreach (var project in _projectDetailDatas.Data)
            {

                if (project.IsCompleted)
                    completedProjects.Add(project);
                else
                    ongiongProjects.Add(project);
            }

            if (!isProgressing)
                dataGridViewOngoingProjects.DataSource = completedProjects;
            else
                dataGridViewOngoingProjects.DataSource = ongiongProjects;
        }
    }
}
