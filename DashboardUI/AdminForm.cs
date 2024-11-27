using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
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
    public partial class AdminForm : Form
    {
        UserManager userManager;
        AlertBox alertBox;
        ToolTip toolTip;
        Dashboard _dashboardForm;

        object _tempCellValue;

        public AdminForm(Dashboard dashboardForm)
        {
            InitializeComponent();
            _dashboardForm = dashboardForm;
            userManager = new UserManager(new EfUserDal());
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            userDataGrid.DataSource = userManager.GetAll().Data;
            toolTip = new ToolTip();
            toolTip.SetToolTip(this.buttonCreate, "Create New User");
            toolTip.SetToolTip(this.buttonDelete, "Delete User");
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new();
            createUser.FormClosed += CreateUser_FormClosed;
            createUser.ShowDialog();
        }

        private void CreateUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshUserList();
        }

        private void RefreshUserList()
        {
            //reset gridview
            userDataGrid.DataSource = null;
            userDataGrid.Rows.Clear();
            userDataGrid.Columns.Clear();
            userDataGrid.DataSource = userManager.GetAll().Data;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete selected user permanently!", "User Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var userIndex = userDataGrid.Rows[userDataGrid.CurrentCell.RowIndex].Cells[0].Value;
                User userToDelete = userManager.GetById(Convert.ToInt32(userIndex)).Data;
                userManager.Delete(userToDelete);

                //notification
                alertBox = new AlertBox(_dashboardForm.Left + _dashboardForm.Width - 270, _dashboardForm.Top + _dashboardForm.Height - 70);
                alertBox.SuccessAlert("User deleted!");
            }

            RefreshUserList();
        }

        private void userDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 && e.ColumnIndex != 1)
            {

                var userIndex = userDataGrid.Rows[userDataGrid.CurrentCell.RowIndex].Cells[0].Value;
                User userToUpdate = userManager.GetById(Convert.ToInt32(userIndex)).Data;

                if (e.ColumnIndex == 2)
                {
                    userToUpdate.Admin = true;
                    userToUpdate.Author = false;
                    userToUpdate.Reader = false;
                    userManager.Update(userToUpdate);

                    //notification
                    alertBox = new AlertBox(_dashboardForm.Left + _dashboardForm.Width - 270, _dashboardForm.Top + _dashboardForm.Height - 70);
                    alertBox.InformationAlert("User set as Admin Role!");
                }
                else if (e.ColumnIndex == 3)
                {
                    userToUpdate.Admin = false;
                    userToUpdate.Author = true;
                    userToUpdate.Reader = false;
                    userManager.Update(userToUpdate);

                    //notification
                    alertBox = new AlertBox(_dashboardForm.Left + _dashboardForm.Width - 270, _dashboardForm.Top + _dashboardForm.Height - 70);
                    alertBox.InformationAlert("User set as Author Role!");
                }
                else if (e.ColumnIndex == 4)
                {
                    userToUpdate.Admin = false;
                    userToUpdate.Author = false;
                    userToUpdate.Reader = true;
                    userManager.Update(userToUpdate);

                    //notification
                    alertBox = new AlertBox(_dashboardForm.Left + _dashboardForm.Width - 270, _dashboardForm.Top + _dashboardForm.Height - 70);
                    alertBox.InformationAlert("User set as Reader Role!");
                }
            }
            else if (e.ColumnIndex == 1)
            {
                // name update
            }

            RefreshUserList();
        }

        private void userDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex != 1)
            {
                return;
            }

            var cellValue = userDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            //check if cell value is changed
            if (_tempCellValue != cellValue)
            {
                if (cellValue != null)
                {
                    var userIndex = userDataGrid.Rows[userDataGrid.CurrentCell.RowIndex].Cells[0].Value;
                    User userToUpdate = userManager.GetById(Convert.ToInt32(userIndex)).Data;
                    userToUpdate.UserName = cellValue.ToString();
                    userManager.Update(userToUpdate);

                    //notification
                    alertBox = new AlertBox(_dashboardForm.Left + _dashboardForm.Width - 270, _dashboardForm.Top + _dashboardForm.Height - 70);
                    alertBox.SuccessAlert("User name is updated!");
                }
                else
                {
                    userDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = _tempCellValue;

                    //notification
                    alertBox = new AlertBox(_dashboardForm.Left + _dashboardForm.Width - 270, _dashboardForm.Top + _dashboardForm.Height - 70);
                    alertBox.ErrorAlert("User name cannot be empty!");
                }
            }
            else
            {
                //notification
                alertBox = new AlertBox(_dashboardForm.Left + _dashboardForm.Width - 270, _dashboardForm.Top + _dashboardForm.Height - 70);
                alertBox.WarningAlert("The value is not changed!");
            }
        }
        private void userDataGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _tempCellValue = userDataGrid.Rows[e.RowIndex].Cells[1].Value;
        }
    }
}

