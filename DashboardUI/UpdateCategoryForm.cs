using Business.Concrete;
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
    public partial class UpdateCategoryForm : Form
    {
        CategoryManager _categoryManager;
        string _tableValue;

        public UpdateCategoryForm(CategoryManager categoryManager, string value)
        {
            _categoryManager = categoryManager;
            _tableValue = value;
            InitializeComponent();
        }

        private void UpdateCategoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
