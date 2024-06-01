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
using Excel = Microsoft.Office.Interop.Excel;
using Agilent.AgilentE36xx.Interop;
using System.Threading;



namespace TOSA_MMB_TEST_SOFTWARE
{
    public partial class Erase_Memory_Test_Screenshot : Form
    {
        AgilentE36xx e3649a1 = new AgilentE36xx();
        string SERIAL1 = MAIN_WINDOW.send_serial;
        string folder_name = MAIN_WINDOW.send_folder_name;
        string USER = MAIN_WINDOW.send_operator_name;
        string TP4 = PLL_frequency_Test.send_TP4;
        string TP5 = PLL_frequency_Test.send_TP5;
        string TP6 = PLL_frequency_Test.send_TP6;
        string R138 = PLL_frequency_Test.send_R138;
        string CH1 = Video_Test.send_CH1;
        string CH2 = Video_Test.send_CH2;
        string CH3 = Video_Test.send_CH3;


        public Erase_Memory_Test_Screenshot()
        {
            InitializeComponent();
        }

        private void PASSLOGIC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BOARD PASSED THE FUNCTIONAL TEST");
            //SCREEN SHOT CAPTURING
            Bitmap captureBitmap = new Bitmap(1366, 768, PixelFormat.Format32bppArgb);
            Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
            Graphics captureGraphics = Graphics.FromImage(captureBitmap);
            captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
            captureBitmap.Save(@"D:\Resources\Report\TOSA MMB FUNCTIONAL TEST\REPORTS\" + folder_name + "\\" + "Erase_Memory_Test" + ".jpg", ImageFormat.Jpeg);
            Thread.Sleep(100);
            string A = "PASS";
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
            xlWorkSheet.Cells[7, 3] = "PASS";
            xlWorkSheet.Cells[8, 3] = "PASS";
            xlWorkSheet.Cells[9, 3] = "PASS";
            xlWorkSheet.Cells[10, 3] = "PASS";
            xlWorkSheet.Cells[11, 3] = "PASS";
            xlWorkSheet.Cells[12, 3] = "PASS";
            xlWorkSheet.Cells[13, 3] = TP4;
            xlWorkSheet.Cells[14, 3] = TP5;
            xlWorkSheet.Cells[15, 3] = TP6;
            xlWorkSheet.Cells[16, 3] = R138;
            xlWorkSheet.Cells[17, 3] = "PASS";
            xlWorkSheet.Cells[18, 3] = CH1;
            xlWorkSheet.Cells[19, 3] = CH2;
            xlWorkSheet.Cells[20, 3] = CH3;
            xlWorkSheet.Cells[21, 3] = "PASS";
            xlWorkSheet.Cells[22, 3] = "PASS";
            xlWorkSheet.Cells[23, 3] = "PASS";
            Thread.Sleep(500);
           
            string filename = SERIAL1 + B + A + B + DateTime.Now.ToString("ddMMyyyy_hhmmss") + ".xlsx";
            xlWorkbook.SaveAs(@"D:\Resources\Report\TOSA MMB FUNCTIONAL TEST\REPORTS\" + filename);

           // MessageBox.Show("BOARD PASSED THE FUNCTIONAL TESTING");

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
            Thread.Sleep(100);
            MAIN_WINDOW main = new MAIN_WINDOW();
            this.Hide();
            main.ShowDialog();

        }

        private void FAILLOGIC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BOARD FAILED IN FUNCTIONAL TEST");
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
            xlWorkSheet.Cells[7, 3] = "PASS";
            xlWorkSheet.Cells[8, 3] = "PASS";
            xlWorkSheet.Cells[9, 3] = "PASS";
            xlWorkSheet.Cells[10, 3] = "PASS";
            xlWorkSheet.Cells[11, 3] = "PASS";
            xlWorkSheet.Cells[12, 3] = "PASS";
            xlWorkSheet.Cells[13, 3] = TP4;
            xlWorkSheet.Cells[14, 3] = TP5;
            xlWorkSheet.Cells[15, 3] = TP6;
            xlWorkSheet.Cells[16, 3] = R138;
            xlWorkSheet.Cells[17, 3] = "PASS";
            xlWorkSheet.Cells[18, 3] = CH1;
            xlWorkSheet.Cells[19, 3] = CH2;
            xlWorkSheet.Cells[20, 3] = CH3;
            xlWorkSheet.Cells[21, 3] = "FAIL";
            xlWorkSheet.Cells[22, 3] = "FAIL";
            xlWorkSheet.Cells[23, 3] = "FAIL";
            Thread.Sleep(100);
            string filename = SERIAL1 + B + A + B + DateTime.Now.ToString("ddMMyyyy_hhmmss") + ".xlsx";
            xlWorkbook.SaveAs(@"D:\Resources\Report\TOSA MMB FUNCTIONAL TEST\REPORTS\" + filename);

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
