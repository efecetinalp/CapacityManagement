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

namespace DashboardUI
{
    public partial class DataCardUI : Form
    {
        ProjectDetailDto _projectDetail;

        public DataCardUI(ProjectDetailDto projectDetail)
        {
            _projectDetail = projectDetail;
            InitializeComponent();
        }

        private void DataCardUI_Load(object sender, EventArgs e)
        {
            lblProjectName.Text = _projectDetail.ProjectName;
            lblManagement.Text = _projectDetail.ManagementName;
            lblDepartment.Text = _projectDetail.DepartmentName;
            lblCategory.Text = _projectDetail.CategoryName;
            lblStartDate.Text = _projectDetail.StartDate.ToString("MMM-yy");
            lblOwner.Text = _projectDetail.UserName;
            checkBoxIsProgressing.Checked = !_projectDetail.isProgressing;

            if (_projectDetail.isProgressing)
            {
                lblStatus.Text = "Progressing";
                lblEndDate.Text = "N/A";
            }
            else
            {
                lblStatus.Text = "Completed";
                lblEndDate.Text = _projectDetail.EndDate.ToString("MMM-yy");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imageClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imgEdit_Click(object sender, EventArgs e)
        {
            //start edit mode
            BeginEditMode();
        }

        private void BeginEditMode()
        {
            imgEdit.Visible = false;
            imgSave.Visible = true;

            lblProjectName.Visible = false;
            lblManagement.Visible = false;
            lblDepartment.Visible = false;
            lblCategory.Visible = false;
            lblStatus.Visible = false;
            lblStartDate.Visible = false;
            lblEndDate.Visible = false;
            lblOwner.Visible = false;

            txtProjectName.Visible = true;
            comboBoxManagement.Visible = true;
            comboBoxDepartment.Visible = true;
            comboBoxCategory.Visible = true;
            dateTimePickerStart.Visible = true;
            dateTimePickerEnd.Visible = true;
            checkBoxIsProgressing.Visible = true;
            comboBoxUser.Visible = true;

            if (_projectDetail.isProgressing)
                dateTimePickerEnd.Enabled = false;
        }

        private void QuitEditMode()
        {
            imgEdit.Visible = true;
            imgSave.Visible = false;

            lblProjectName.Visible = true;
            lblManagement.Visible = true;
            lblDepartment.Visible = true;
            lblCategory.Visible = true;
            lblStatus.Visible = true;
            lblStartDate.Visible = true;
            lblEndDate.Visible = true;
            lblOwner.Visible = true;

            txtProjectName.Visible = false;
            comboBoxManagement.Visible = false;
            comboBoxDepartment.Visible = false;
            comboBoxCategory.Visible = false;
            dateTimePickerStart.Visible = false;
            dateTimePickerEnd.Visible = false;
            checkBoxIsProgressing.Visible = false;
            comboBoxUser.Visible = false;
        }

        private void checkBoxIsProgressing_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxIsProgressing.Checked)
                dateTimePickerEnd.Enabled = false;
            else
                dateTimePickerEnd.Enabled = true;
        }

        private void imgSave_Click(object sender, EventArgs e)
        {
            //save edited card

            //UI change
            QuitEditMode();
        }
    }
}
