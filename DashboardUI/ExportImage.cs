using System.Drawing.Imaging;
using System.Windows.Forms.DataVisualization.Charting;

namespace DashboardUI
{
    public partial class ExportImage : Form
    {
        private Chart _areaChart;
        private AlertBox _alertBox;

        public ExportImage(Chart exportedChart)
        {
            InitializeComponent();
            _areaChart = exportedChart;
            _alertBox = new(_areaChart.Left + _areaChart.Width, _areaChart.Top + _areaChart.Height);

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();

            string selectedPath = folderBrowserDialog.SelectedPath;
            textBoxExportPath.Text = selectedPath;
        }

        private bool ExportChart(string path, string filename)
        {
            try
            {
                int width = Convert.ToInt32(_areaChart.Width);
                int height = Convert.ToInt32(_areaChart.Height);
                using (Bitmap bmp = new Bitmap(width, height))
                {
                    _areaChart.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                    bmp.Save(filename + ".jpg", ImageFormat.Jpeg);
                    FileInfo image = new FileInfo(filename + ".jpg");
                    image.MoveTo(path + "\\" + filename + ".jpg");
                }
            }
            catch (Exception)
            {

                return false;
            }

            return true;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {

            if (textBoxFileName.Text != "" || textBoxExportPath.Text != "")
            {
                if (ExportChart(textBoxExportPath.Text, textBoxFileName.Text))
                {
                    _alertBox.SuccessAlert("Sucessfully exported.");
                }
                else
                {
                    _alertBox.ErrorAlert("Failed while exporting!");
                }
            }
            else
                _alertBox.WarningAlert("Please fill empty areas!");
        }
    }
}
