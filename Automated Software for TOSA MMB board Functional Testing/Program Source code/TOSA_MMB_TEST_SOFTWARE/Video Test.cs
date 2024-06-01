using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Excel = Microsoft.Office.Interop.Excel;
using Agilent.AgilentE36xx.Interop;

namespace TOSA_MMB_TEST_SOFTWARE
{
    public partial class Video_Test : Form
    {
        AgilentE36xx e3649a1 = new AgilentE36xx();
        string SERIAL1 = MAIN_WINDOW.send_serial;
        string folder_name = MAIN_WINDOW.send_folder_name;
        string USER = MAIN_WINDOW.send_operator_name;
        string TP4 = PLL_frequency_Test.send_TP4;
        string TP5 = PLL_frequency_Test.send_TP4;
        string TP6 = PLL_frequency_Test.send_TP6;
        string R138 = PLL_frequency_Test.send_R138;

        double test1;
        double test2;
        double test3;

        public Video_Test()
        {
            InitializeComponent();
        }
        public static string send_CH1 = "";
        public static string send_CH2 = "";
        public static string send_CH3 = "";

        private void start_logic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on Autoset and set Channel 1 Amplitude to 500mV range");
            if (CH1.Text == "" && CH2.Text == "" && CH3.Text == "" )
            {
                MessageBox.Show("FREQUENCY DETAILS ARE NOT UPDATED");
                return;
            }

            else
            {

                send_CH1 = CH1.Text;
                send_CH2 = CH2.Text;
                send_CH3 = CH3.Text;
               

                test1 = Convert.ToDouble(send_CH1);
                test2 = Convert.ToDouble(send_CH2);
                test3 = Convert.ToDouble(send_CH2);
                

                if (test1 >= 25.0 && test1 <= 100.0)

                {

                    if (test2 >= 25.00 && test2 <= 100.00)
                    {
                        if (test3 >= 25.00 && test3 <= 100.00)
                        {
                            CH1.BackColor = Color.Green;
                            CH2.BackColor = Color.Green;
                            CH3.BackColor = Color.Green;
                            MessageBox.Show("BOARD PPASSED FOR VIDEO FREQUENCY TEST");
                            e3649a1.Initialize("ASRL1", false, false, "");
                            Thread.Sleep(500);
                            e3649a1.Outputs.Channel = Agilent.AgilentE36xx.Interop.AgilentE36xxOutputEnum.AgilentE36xxOutput1;
                            e3649a1.Outputs.Enabled = false;
                            Thread.Sleep(500);
                            e3649a1.Close();

                                Ethernet_Test NEXT = new Ethernet_Test();
                                this.Hide();
                                NEXT.ShowDialog();
                            

                        }
                    }
                }
                CH1.BackColor = Color.Red;
                CH2.BackColor = Color.Red;
                CH3.BackColor = Color.Red;

                MessageBox.Show("BOARD FALED FOR VIDEO FREQUENCY TEST");
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
                xlWorkSheet.Cells[17, 3] = "FAIL";
                xlWorkSheet.Cells[18, 3] = send_CH1;
                xlWorkSheet.Cells[19, 3] = send_CH2;
                xlWorkSheet.Cells[20, 3] = send_CH3;
                xlWorkSheet.Cells[21, 3] = "____";
                xlWorkSheet.Cells[22, 3] = "____";
                xlWorkSheet.Cells[23, 3] = "____";
                Thread.Sleep(100);
                string filename = SERIAL1 + B + A + B + DateTime.Now.ToString("ddMMyyyy_hhmmss") + ".xlsx";
                xlWorkbook.SaveAs(@"D:\Resources\Report\TOSA MMB FUNCTIONAL TEST\REPORTS\" + filename);

                MAIN_WINDOW main = new MAIN_WINDOW();
                this.Hide();
                main.ShowDialog();


            }

        }
    }
}
