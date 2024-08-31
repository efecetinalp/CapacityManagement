using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProjectManager projectManager = new ProjectManager(new EfProjectDal());

            foreach (var project in projectManager.GetAll())
            {
                listBox1.Items.Add(project.ProjectName);
            }

            foreach (var project in projectManager.GetAllByCategoryId(2))
            {
                listBox1.Items.Add(project.ProjectName);

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}