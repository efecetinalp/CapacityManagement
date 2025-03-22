using Business.Concrete;
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

namespace DashboardUI
{
    public partial class DeleteProject : Form
    {
        private ProjectManager _projectManager;
        private Project _projectToDelete;

        public DeleteProject(ProjectManager projectManager, Project project)
        {
            _projectManager = projectManager;
            _projectToDelete = project;
            InitializeComponent();
        }

        private void DeleteProject_Load(object sender, EventArgs e)
        {
            labelDelete.Text = _projectToDelete.ProjectName + " is going to delete permanently!" + System.Environment.NewLine + "Type: " + _projectToDelete.ProjectName + " for approval";
            textBoxDelete.PlaceholderText = _projectToDelete.ProjectName;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxDelete.Text == textBoxDelete.PlaceholderText)
            {
                _projectManager.Delete(_projectToDelete);
                Debug.Print("delete test worked!");
            }
            else
            {
                Debug.Print("wrong input");
            }

        }
    }
}
