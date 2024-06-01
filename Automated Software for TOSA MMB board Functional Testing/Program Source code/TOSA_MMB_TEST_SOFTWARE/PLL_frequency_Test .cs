using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Agilent.AgilentE36xx.Interop;
//using Tektronix.Tkdpo2k3k4k.Interop;
using System.Threading;


namespace TOSA_MMB_TEST_SOFTWARE
{
    public partial class PLL_frequency_Test : Form
    {
      //  Tkdpo2k3k4k DPO2024B = new Tkdpo2k3k4k();
        AgilentE36xx e3649a1 = new AgilentE36xx();
        string SERIAL1 = MAIN_WINDOW.send_serial;
        string folder_name = MAIN_WINDOW.send_folder_name;
        string USER = MAIN_WINDOW.send_operator_name;
        double test1;
        double test2;
        double test3;
        double test4;

        public PLL_frequency_Test()
        {
            InitializeComponent();
        }
        public static string send_TP4 = ""; 
        public static string send_TP5 = "";
        public static string send_TP6 = "";
        public static string send_R138 = "";
        private void start_logic_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Click on Autoset and Set Channel 1 Amplitude to 5V range");

            if (TP4.Text == "" && TP5.Text == "" && TP6.Text == "" && R138.Text == "")
            {
                MessageBox.Show("FREQUENCY DETAILS ARE NOT UPDATED");
                return;
            }

            else
            {
                

                //DPO2024B.Initialize("USB0::0x0699::0x03A3::C020903::0::INSTR", false, false, "");
               // DPO2024B.Acquisition.AutoSet();
                

                //DPO2024B.MeasurementImmediate.Configure(Tektronix.Tkdpo2k3k4k.Interop.Tkdpo2k3k4kSourceEnum.Tkdpo2k3k4kSourceCH1, Tektronix.Tkdpo2k3k4k.Interop.Tkdpo2k3k4kMeasurementTypeEnum.Tkdpo2k3k4kMeasurementTypeFrequency);
               // double val = DPO2024B.MeasurementImmediate.Value;
               // DPO2024B.Close();

            send_TP4 = TP4.Text;
            send_TP5 = TP5.Text;
            send_TP6 = TP6.Text;
            send_R138 = R138.Text;

            test1 = Convert.ToDouble(send_TP4);
            test2 = Convert.ToDouble(send_TP5);
            test3 = Convert.ToDouble(send_TP6);
            test4 = Convert.ToDouble(send_R138);

            if (test1 >= 39.5 && test1 <= 40.5)

            { 

            if (test2 >= 49.00 && test2 <= 50.00)
             { 
             if (test3 >= 29.00 && test3 <= 30.00)
             {
                            if (test4 >= 24.0 && test4 <= 26.0)
                            {
                                TP4.BackColor = Color.Green;
                                TP5.BackColor = Color.Green;
                                TP6.BackColor = Color.Green;
                                R138.BackColor = Color.Green;
                                MessageBox.Show("BOARD PASSED FOR PLL FREQUENCY TEST");
                                Video_Test next = new Video_Test();
                                this.Hide();
                                next .ShowDialog();
                            }

                        }
                    }
                }

                                 TP4.BackColor = Color.Red;
                                 TP5.BackColor = Color.Red;
                                 TP6.BackColor = Color.Red;
                                 R138.BackColor = Color.Red;
                                MessageBox.Show("BOARD FAILED FOR PLL FREQUENCY TEST");
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
                                xlWorkSheet.Cells[12, 3] = "FAIL";
                                xlWorkSheet.Cells[13, 3] = send_TP4;
                                xlWorkSheet.Cells[14, 3] = send_TP5;
                                xlWorkSheet.Cells[15, 3] = send_TP6;
                                xlWorkSheet.Cells[16, 3] = send_R138;
                                xlWorkSheet.Cells[17, 3] = "____";
                                xlWorkSheet.Cells[18, 3] = "____";
                                xlWorkSheet.Cells[19, 3] = "____";
                                xlWorkSheet.Cells[20, 3] = "____";
                                xlWorkSheet.Cells[21, 3] = "____";
                                xlWorkSheet.Cells[22, 3] = "____";
                                xlWorkSheet.Cells[23, 3] = "____";
                                Thread.Sleep(500);
                                string filename = SERIAL1 + B + A + B + DateTime.Now.ToString("ddMMyyyy_hhmmss") + ".xlsx";
                                xlWorkbook.SaveAs(@"D:\Resources\Report\TOSA MMB FUNCTIONAL TEST\REPORTS\" + filename);

                                MAIN_WINDOW main = new MAIN_WINDOW();
                                this.Hide();
                                main.ShowDialog();

                            
            }


        }
    }
}
        
