using Business.Concrete;
using Core.Utilities.Results;
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
    public partial class UpdateCategoryForm : Form
    {
        //Form window drag to move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        CategoryManager _categoryManager;
        IDataResult<Category> _categoryData;
        int _categoryIndex;

        public UpdateCategoryForm(CategoryManager categoryManager, int index)
        {
            _categoryManager = categoryManager;
            _categoryIndex = index;
            InitializeComponent();
        }

        private void UpdateCategoryForm_Load(object sender, EventArgs e)
        {
            _categoryData = _categoryManager.GetById(_categoryIndex);

            if (_categoryData.Success)
            {
                textBoxCategory.Text = _categoryData.Data.CategoryName;
            }
            else
                MessageBox.Show(_categoryData.Massage, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UpdateCategoryForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxCategory.Text != "")
            {
                Category categoryToUpdate = _categoryData.Data;
                categoryToUpdate.CategoryName = textBoxCategory.Text;

                var categoryOperation = _categoryManager.Update(categoryToUpdate);

                if (categoryOperation.Success)
                {
                    MessageBox.Show(categoryOperation.Massage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show(categoryOperation.Massage, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please fill empty selections!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
