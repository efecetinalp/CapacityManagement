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
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace DashboardUI
{
    public partial class FilterSeriesForm : Form
    {
        //Form window drag to move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        ChartRequest _chartRequest;
        public ChartRequest _filteredRequest { get; private set; }

        public FilterSeriesForm(ChartRequest chartRequest)
        {
            InitializeComponent();
            new DropShadow().ApplyShadows(this);
            _chartRequest = chartRequest;
        }

        private void FilterSeriesForm_Load(object sender, EventArgs e)
        {
            checkedSeries.Items.AddRange(_chartRequest.Legends.ToArray());

            for (int i = 0; i < checkedSeries.Items.Count; i++)
            {
                checkedSeries.SetItemChecked(i, _chartRequest.isActive[i]);
            }
        }

        private void FilterSeriesForm_MouseDown(object sender, MouseEventArgs e)
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

        private void buttonApply_Click(object sender, EventArgs e)
        {
            _filteredRequest = new();

            for (int i = 0; i < checkedSeries.Items.Count; i++)
            {
                if (checkedSeries.GetItemCheckState(i) == CheckState.Checked)
                {
                    _chartRequest.isActive[i] = true;
                }
                else
                {
                    _chartRequest.isActive[i] = false;
                }
            }

            _filteredRequest = _chartRequest;
            this.Close();
        }

        #region List Hover Effect

        private int hoveredIndex = -1;

        private void checkedSeries_MouseMove(object sender, MouseEventArgs e)
        {
            int index = checkedSeries.IndexFromPoint(e.Location);
            if (index != hoveredIndex)
            {
                hoveredIndex = index;
                checkedSeries.SelectedIndex = index;
                checkedSeries.Invalidate();
            }
        }

        private void checkedSeries_MouseLeave(object sender, EventArgs e)
        {
            hoveredIndex = -1;
            checkedSeries.Invalidate();
        }

        #endregion
    }
}
