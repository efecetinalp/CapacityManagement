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
        private CategoryManager _categoryManager;
        private Category _categoryToDelete;

        public DeleteCategoryForm(CategoryManager categoryManager, Category category)
        {
            _categoryManager = categoryManager;
            _categoryToDelete = category;
            InitializeComponent();
        }

        private void DeleteCategoryForm_Load(object sender, EventArgs e)
        {
            labelDelete.Text = _categoryToDelete.CategoryName + " is going to delete permanently!" + System.Environment.NewLine + "Type: " + _categoryToDelete.CategoryName + " for approval";
            textBoxDelete.PlaceholderText = _categoryToDelete.CategoryName;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxDelete.Text == textBoxDelete.PlaceholderText)
            {
                _categoryManager.Delete(_categoryToDelete);
                Debug.Print("delete test worked!");
            }
            else
            {
                Debug.Print("wrong input");
            }

        }
    }
}
