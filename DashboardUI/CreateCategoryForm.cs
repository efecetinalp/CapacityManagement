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
    public partial class CreateCategoryForm : Form
    {
        CategoryManager _categoryManager;

        public CreateCategoryForm(CategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Category categoryToCreate = new();
            categoryToCreate.CategoryName = textBoxCategory.Text;
            _categoryManager.Add(categoryToCreate);
            Debug.Print("category created");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
