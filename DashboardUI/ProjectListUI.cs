using Entities.Concrete;
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
    public partial class ProjectListUI : Form
    {
        //Form window drag to move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private List<Project> _projectList;
        private string _formText;

        public ProjectListUI(List<Project> projects, string formText)
        {
            _projectList = projects;
            _formText = formText;
            InitializeComponent();
            new DropShadow().ApplyShadows(this);
        }

        private void ProjectListUI_Load(object sender, EventArgs e)
        {
            dataGridViewProjectList.DataSource = _projectList;
            for (int i = 0; i < dataGridViewProjectList.Columns.Count; i++)
            {
                if (i != 5)
                    dataGridViewProjectList.Columns[i].Visible = false;
            }

            lblProjectList.Text = _formText;
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProjectListUI_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
