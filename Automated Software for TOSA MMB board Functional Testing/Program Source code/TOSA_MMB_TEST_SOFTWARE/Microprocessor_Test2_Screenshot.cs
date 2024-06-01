using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using Agilent.AgilentE36xx.Interop;
using Excel = Microsoft.Office.Interop.Excel;


namespace TOSA_MMB_TEST_SOFTWARE
{
    public partial class Microprocessor_Test2_Screenshot : Form
    {
        AgilentE36xx e3649a1 = new AgilentE36xx();
        string SERIAL1 = MAIN_WINDOW.send_serial;
        string folder_name = MAIN_WINDOW.send_folder_name;
        string USER = MAIN_WINDOW.send_operator_name;

        public Microprocessor_Test2_Screenshot()
        {
            InitializeComponent();
        }

        private void PASSLOGIC_Click(object sender, EventArgs e)
        {
            //SCREEN SHOT CAPTURING
            Bitmap captureBitmap = new Bitmap(1366, 768, PixelFormat.Format32bppArgb);
            Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
            Graphics captureGraphics = Graphics.FromImage(captureBitmap);
            captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
            captureBitmap.Save(@"D:\Resources\Report\TOSA MMB FUNCTIONAL TEST\REPORTS\" + folder_name + "\\" + "Microprocessor(UBoot Dataloading)_Test" + ".jpg", ImageFormat.Jpeg);

            Thread.Sleep(100);
            foreach (Process p in Process.GetProcesses())

            {

                if (p.ProcessName == "cmd")

                {

                    p.Kill();

                }


            }
            Thread.Sleep(100);
            e3649a1.Initialize("ASRL1", false, false, "");
            Thread.Sleep(500);
            e3649a1.Outputs.Channel = Agilent.AgilentE36xx.Interop.AgilentE36xxOutputEnum.AgilentE36xxOutput1;
            e3649a1.Outputs.Enabled = false;
            Thread.Sleep(500);
            e3649a1.Close();
            Microprocessor_Test3 main = new Microprocessor_Test3();
            this.Hide();
            main.ShowDialog();
        }

        private void FAILLOGIC_Click(object sender, EventArgs e)
        {
            string A = "FAIL";
            string B = "_";
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"D:\Resources\Report\TOSA MMB FUNCTIONAL TEST\TEMPLATE\TOSA MMB test report template.xlsx");
            Excel.Worksheet xlWorkSheet = xlWorkbook.ActiveSheet;
            DateTime TO = DateTime.Now;
            String TODAY = Convert.ToString(TO);
            xlWorkSheet.Cells[4, 2] = USER;
            xlWorkSheet.Cells[3, 2] = SERIAL1;
            xlWorkSheet.Cells[5, 2] = A;
            xlWorkSheet.Cells[4, 4] = TODAY;
            xlWorkSheet.Cells[7, 3] = "FAIL";
            xlWorkSheet.Cells[8, 3] = "PASS";
            xlWorkSheet.Cells[9, 3] = "FAIL";
            xlWorkSheet.Cells[10, 3] = "____";
            xlWorkSheet.Cells[11, 3] = "____";
            xlWorkSheet.Cells[12, 3] = "____";
            xlWorkSheet.Cells[13, 3] = "____";
            xlWorkSheet.Cells[14, 3] = "____";
            xlWorkSheet.Cells[15, 3] = "____";
            xlWorkSheet.Cells[16, 3] = "____";
            xlWorkSheet.Cells[17, 3] = "____";
            xlWorkSheet.Cells[18, 3] = "____";
            xlWorkSheet.Cells[19, 3] = "____";
            xlWorkSheet.Cells[20, 3] = "____";
            xlWorkSheet.Cells[21, 3] = "____";
            xlWorkSheet.Cells[22, 3] = "____";
            xlWorkSheet.Cells[23, 3] = "____";
            Thread.Sleep(100);
            string filename = SERIAL1 + B + A + B + DateTime.Now.ToString("ddMMyyyy_hhmmss") + ".xlsx";
            xlWorkbook.SaveAs(@"D:\Resources\Report\TOSA MMB FUNCTIONAL TEST\REPORTS\" + filename);
            Thread.Sleep(100);

            foreach (Process p in Process.GetProcesses())

            {

                if (p.ProcessName == "cmd")

                {

                    p.Kill();

                }


            }
            e3649a1.Initialize("ASRL1", false, false, "");
            Thread.Sleep(500);
            e3649a1.Outputs.Channel = Agilent.AgilentE36xx.Interop.AgilentE36xxOutputEnum.AgilentE36xxOutput1;
            e3649a1.Outputs.Enabled = false;
            Thread.Sleep(500);
            e3649a1.Close();

            MAIN_WINDOW main = new MAIN_WINDOW();
            this.Hide();
            main.ShowDialog();

        }
    }
}
