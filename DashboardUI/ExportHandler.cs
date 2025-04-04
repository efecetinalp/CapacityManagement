using System.Diagnostics;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace DashboardUI
{
    public class ExportHandler
    {
        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;
        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, UIntPtr dwExtraInfo);
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        public static void ExportDataToExcel(DataGridView dataGrid)
        {
            dataGrid.SelectAll();
            DataObject dataObj = dataGrid.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);

            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            xlexcel = new Excel.Application();
            xlWorkBook = xlexcel.Workbooks.Add(Type.Missing);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.ActiveSheet;
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];


            System.Threading.Thread.Sleep(100); // Give some time for Excel to become active
            System.Windows.Forms.Cursor.Position = new System.Drawing.Point((int)xlexcel.Left + 100, (int)xlexcel.Top + 400);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, UIntPtr.Zero);
            CR.Select();

            xlexcel.Visible = true;
            bool isCompleted = false;
            while (!isCompleted)
            {
                try
                {
                    CR.PasteSpecial();
                    xlWorkSheet.PasteSpecial(Format: "HTML", Link: false, DisplayAsIcon: false, NoHTMLFormatting: true);
                    isCompleted = true;
                }
                catch (Exception)
                {

                    SetForegroundWindow(new IntPtr(xlexcel.Hwnd));
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, UIntPtr.Zero);
                    isCompleted = false;
                    Debug.Print((int)xlexcel.Left + 100 + " " + (int)xlexcel.Top);
                }
            }
        }
    }
}
