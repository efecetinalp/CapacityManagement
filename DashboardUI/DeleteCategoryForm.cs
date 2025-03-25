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
    public partial class DeleteCategoryForm : Form
    {
        //Form window drag to move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private CategoryManager _categoryManager;
        private ProjectManager _projectManager;
        private Category _categoryToDelete;

        public DeleteCategoryForm(CategoryManager categoryManager, ProjectManager projectManager, Category category)
        {
            _categoryManager = categoryManager;
            _projectManager = projectManager;
            _categoryToDelete = category;
            InitializeComponent();
            new DropShadow().ApplyShadows(this);

        }

        private void DeleteCategoryForm_Load(object sender, EventArgs e)
        {
            textBoxDelete.Enabled = false;

            var projectList = _projectManager.GetAllByCategoryId(_categoryToDelete.CategoryId);

            if (!projectList.Success)
            {
                MessageBox.Show(projectList.Massage, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            labelDelete.Text = "You are going to delete " + _categoryToDelete.CategoryName + " permanently!"
                + Environment.NewLine + projectList.Data.Count + " project(s) will effect by this action and effected datas will be lost! "
                + Environment.NewLine + "Type: DELETE CATEGORY for approval";

            //Delete Confirmation
            textBoxDelete.PlaceholderText = "DELETE CATEGORY";
        }

        private void DeleteCategoryForm_MouseDown(object sender, MouseEventArgs e)
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
                var categoryOperation = _categoryManager.Delete(_categoryToDelete);
                if (categoryOperation.Success)
                {
                    MessageBox.Show(categoryOperation.Massage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show(categoryOperation.Massage, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
