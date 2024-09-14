﻿using Business.Concrete;
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
    public partial class UpdateForm : Form
    {
        ManagementManager _managementManager;
        DepartmentManager _departmentManager;
        CategoryManager _categoryManager;
        ProjectManager _projectManager;

        public UpdateForm(ManagementManager managementManager, DepartmentManager departmentManager, CategoryManager categoryManager, ProjectManager projectManager)
        {
            _managementManager = managementManager;
            _departmentManager = departmentManager;
            _categoryManager = categoryManager;
            _projectManager = projectManager;

            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }

    }
}
