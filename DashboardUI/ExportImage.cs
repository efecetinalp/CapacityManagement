using System.Drawing.Imaging;
using System.Windows.Forms.DataVisualization.Charting;

namespace DashboardUI
{
    public partial class ExportImage : Form
    {
        //Form window drag to move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private Chart _areaChart;
        private AlertBox _alertBox;

        public ExportImage(Chart exportedChart)
        {
            InitializeComponent();
            new DropShadow().ApplyShadows(this);

            _areaChart = exportedChart;
            _alertBox = new(this);

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

        private void ExportImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
