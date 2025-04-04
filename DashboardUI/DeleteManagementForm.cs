using Business.Concrete;
using Entities.Concrete;

namespace DashboardUI
{
    public partial class DeleteManagementForm : Form
    {
        //Form window drag to move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private Management _managementToDelete;
        private DepartmentManager _departmentManager;
        private ManagementManager _managementManager;

        public DeleteManagementForm(ManagementManager managementManager, DepartmentManager departmentManager, Management management)
        {
            _managementManager = managementManager;
            _departmentManager = departmentManager;
            _managementToDelete = management;
            InitializeComponent();
            new DropShadow().ApplyShadows(this);

        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            textBoxDelete.Enabled = false;

            var departmentList = _departmentManager.GetAllByManagementId(_managementToDelete.ManagementId);

            if (!departmentList.Success)
            {
                MessageBox.Show(departmentList.Massage, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            labelDelete.Text = "You are going to delete " + _managementToDelete.ManagementName + " permanently!"
                + Environment.NewLine + departmentList.Data.Count + " department will effect by this action and effected datas will be lost! "
                + Environment.NewLine + "Type: DELETE MANAGEMENT for approval";

            //Delete Confirmation
            textBoxDelete.PlaceholderText = "DELETE MANAGEMENT";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxDelete.Text.ToUpper() == textBoxDelete.PlaceholderText.ToUpper() && checkBoxApproval.Checked)
            {
                var managementOperation = _managementManager.Delete(_managementToDelete);
                if (managementOperation.Success)
                {
                    MessageBox.Show(managementOperation.Massage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show(managementOperation.Massage, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Wrong input entered!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DeleteManagementForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
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
