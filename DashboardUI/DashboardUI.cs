using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Data.SqlClient.Server;
using Microsoft.VisualBasic;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace DashboardUI
{
    public partial class Dashboard : Form
    {
        //database manager referances
        ManagementManager managementManager = new ManagementManager(new EfManagementDal());
        DepartmentManager departmentManager = new DepartmentManager(new EfDepartmentDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        ProjectManager projectManager = new ProjectManager(new EfProjectDal());
        ProjectCapacityManager projectCapacityManager = new ProjectCapacityManager(new EfProjectCapacityDal());
        //grid view source table
        DataTable dataTable = new();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //form initialize options

            foreach (var management in managementManager.GetAll().Data)
            {
                comboBoxManagement.Items.Add(management.ManagementName);
            }

            foreach (var department in departmentManager.GetAll().Data)
            {
                comboBoxDepartment.Items.Add(department.DepartmentName);
            }

            foreach (var category in categoryManager.GetAll().Data)
            {
                comboBoxCategory.Items.Add(category.CategoryName);
            }

            dateTimePickerStart.Value = new DateTime(2024, 01, 01);
            dateTimePickerEnd.Value = dateTimePickerStart.Value.AddMonths(6);

            #region "Delete Later"

            //DataTable table = new DataTable();
            ////first column
            //table.Columns.Add("Cabin Structure Projects", typeof(string));

            //foreach (var item in projectCapacityManager.GetProjectCapacityDetails())
            //{
            //    table.Columns.Add(item.Date.ToString(), typeof(int));
            //}

            //foreach (var project in projectManager.GetProjectDetails().Data)
            //{
            //    table.Rows.Add(project.ProjectName);

            //}

            //for (int i = 0; i < table.Columns.Count; i++)
            //{
            //    if (table.Columns[i].ColumnName == projectCapacityManager.GetAllByProjectId(1).)
            //    {

            //    }
            //}

            //dbGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dbGrid.DataSource = table;


            //dbGrid.DataSource = projectManager.GetProjectDetails().Data;
            //dbGrid.DataSource = projectCapacityManager.GetProjectCapacityDetails();

            #endregion

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //create new project
            //CreateMenu createMenu = new();
            //createMenu.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //update selection
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete selection
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            ResetGridView();

            //first column on data table
            dbGrid.Columns.Add("Projects", "Projects");
            foreach (var data in projectCapacityManager.GetProjectCapacityDetailsByDateAndDepartmentId(new DateTime(2024,03,01), 1).Data)
            {
                dbGrid.Rows.Add(data.ProjectName);
            }


            int monthCalulate = (dateTimePickerEnd.Value.Year - dateTimePickerStart.Value.Year) * 12
                + (dateTimePickerEnd.Value.Month - dateTimePickerStart.Value.Month);

            //month columns
            DateTime tempMonth;
            for (int i = 0; i <= monthCalulate; i++)
            {
                //empty column
                dbGrid.Columns.Add("", "");

                DataGridViewColumn column = dbGrid.Columns[i + 1];

                tempMonth = dateTimePickerStart.Value.AddMonths(i);
                column.HeaderText = tempMonth.ToString("MMM-yy");

                if (projectCapacityManager.GetProjectCapacityDetailsByDateAndDepartmentId(tempMonth, 1).Data.Count != 0)
                {
                    for (int j = 0; j < projectCapacityManager.GetProjectCapacityDetailsByDateAndDepartmentId(tempMonth, 1).Data.Count; j++)
                    {
                        column.DataGridView.Rows[j].Cells[i + 1].Value = projectCapacityManager.GetProjectCapacityDetailsByDateAndDepartmentId(tempMonth, 1).Data[j].PTotalCapacity;
                        column.DataGridView.Rows[j].Cells[i + 1].Style.BackColor = Color.LightGreen;
                        //column.DefaultCellStyle.BackColor = Color.Green;
                    }

                }

               
                //dbGrid.Columns.Add(column);
            }


            //dbGrid.DataSource = projectCapacityManager.GetProjectCapacityDetailsByDateAndDepartmentId(dateTimePickerStart.Value, 1).Data;






            //FetchDataLater();
            #region "DELETE LATER"
            //DELETE LATER
            dbGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dbGrid.ColumnHeadersHeight = 50;
            dbGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            // Here we attach an event handler to the cell painting event
            dbGrid.CellPainting += new DataGridViewCellPaintingEventHandler(dbGrid_CellPainting);
            #endregion
        }

        private void FetchDataLater()
        {
            //fetch row datas
            for (int i = 0; i < projectManager.GetAll().Data.Count; i++)
            {
                dataTable.Rows.Add(projectManager.GetAll().Data[i].ProjectName);
            }

            dbGrid.DataSource = dataTable;

            for (int i = 0; i < projectCapacityManager.GetProjectCapacityDetails().Data.Count; i++)
            {
                int result = 0;
                if (dataTable.Columns.Contains(projectCapacityManager.GetProjectCapacityDetails().Data[i].PDate.ToString()))
                {

                    result = dataTable.Columns.IndexOf(projectCapacityManager.GetProjectCapacityDetails().Data[i].PDate.ToString());
                }

                dbGrid[i, result].Value = projectCapacityManager.GetProjectCapacityDetails().Data[i].PTotalCapacity;
            }



            dbGrid.DataSource = dataTable;
            dbGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dbGrid.ColumnHeadersHeight = 50;
            dbGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;

            // Here we attach an event handler to the cell painting event
            dbGrid.CellPainting += new DataGridViewCellPaintingEventHandler(dbGrid_CellPainting);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetGridView();

            //reset filters
            comboBoxManagement.ResetText();
            comboBoxDepartment.ResetText();
            comboBoxCategory.ResetText();

            dateTimePickerStart.Value = DateTime.Today;
            dateTimePickerEnd.Value = DateTime.Today.AddMonths(1);
        }

        private void ResetGridView()
        {
            //reset gridview
            dataTable = new();
            dbGrid.DataSource = null;
            dbGrid.Rows.Clear();
            dbGrid.Columns.Clear();
        }

        private void comboBoxManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update department comboBox
            comboBoxDepartment.Items.Clear();

            foreach (var department in departmentManager.GetByManagementId(comboBoxManagement.SelectedIndex + 1).Data)
            {
                comboBoxDepartment.Items.Add(department.DepartmentName);
            }
        }

        private void dbGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // check that we are in a header cell!
            //column index = 1 is for project names
            if (e.RowIndex == -1 && e.ColumnIndex >= 1)
            {
                e.PaintBackground(e.ClipBounds, true);
                Rectangle rect = this.dbGrid.GetColumnDisplayRectangle(e.ColumnIndex, true);
                Size titleSize = TextRenderer.MeasureText(e.Value.ToString(), e.CellStyle.Font);
                if (this.dbGrid.ColumnHeadersHeight < titleSize.Width)
                {
                    this.dbGrid.ColumnHeadersHeight = titleSize.Width;
                }

                e.Graphics.TranslateTransform(0, titleSize.Width);
                e.Graphics.RotateTransform(-90.0F);

                // This is the key line for bottom alignment - we adjust the PointF based on the 
                // ColumnHeadersHeight minus the current text width. ColumnHeadersHeight is the
                // maximum of all the columns since we paint cells twice - though this fact
                // may not be true in all usages!   
                e.Graphics.DrawString(e.Value.ToString(), this.Font, Brushes.Black, new PointF(rect.Y - (dbGrid.ColumnHeadersHeight - titleSize.Width), rect.X));

                // The old line for comparison
                //e.Graphics.DrawString(e.Value.ToString(), this.Font, Brushes.Black, new PointF(rect.Y, rect.X));


                e.Graphics.RotateTransform(90.0F);
                e.Graphics.TranslateTransform(0, -titleSize.Width);
                e.Handled = true;
            }
        }


    }
}