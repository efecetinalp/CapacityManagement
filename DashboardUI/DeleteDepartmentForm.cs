using Business.Concrete;
using Entities.Concrete;

namespace DashboardUI
{
    public partial class DeleteDepartmentForm : Form
    {
        //Form window drag to move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private Department _departmentToDelete;
        private DepartmentManager _departmentManager;
        private DepartmentCapacityManager _departmentCapacityManager;
        private ProjectManager _projectManager;

        public DeleteDepartmentForm(DepartmentManager departmentManager, DepartmentCapacityManager departmentCapacityManager, ProjectManager projectManager, Department department)
        {
            _departmentManager = departmentManager;
            _departmentCapacityManager = departmentCapacityManager;
            _projectManager = projectManager;
            _departmentToDelete = department;
            InitializeComponent();
            new DropShadow().ApplyShadows(this);
        }
        private void DeleteDepartmentForm_Load(object sender, EventArgs e)
        {
            textBoxDelete.Enabled = false;

            var projectList = _projectManager.GetAllByDepartmentId(_departmentToDelete.DepartmentId);
            var departmentCapacityList = _departmentCapacityManager.GetAllByDepartmentId(_departmentToDelete.DepartmentId);

            if (!projectList.Success)
            {
                MessageBox.Show(projectList.Massage, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            if (!departmentCapacityList.Success)
            {
                MessageBox.Show(departmentCapacityList.Massage, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            labelDelete.Text = "You are going to delete " + _departmentToDelete.DepartmentName + " permanently!"
                + Environment.NewLine + projectList.Data.Count + " project(s) will effect by this action and effected datas will be lost! "
                + Environment.NewLine + departmentCapacityList.Data.Count + " department capacities will effect by this action and effected datas will be lost! "
                + Environment.NewLine + "Type: DELETE DEPARTMENT for approval";

            //Delete Confirmation
            textBoxDelete.PlaceholderText = "DELETE DEPARTMENT";
        }

        private void DeleteDepartmentForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxDelete.Text.ToUpper() == textBoxDelete.PlaceholderText.ToUpper() && checkBoxApproval.Checked)
            {
                var departmentOperation = _departmentManager.Delete(_departmentToDelete);
                if (departmentOperation.Success)
                {
                    MessageBox.Show(departmentOperation.Massage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show(departmentOperation.Massage, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Wrong input entered!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void checkBoxApproval_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxApproval.Checked)
                textBoxDelete.Enabled = true;
            else
                textBoxDelete.Enabled = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
