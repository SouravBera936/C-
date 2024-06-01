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
using System.IO;
using Agilent.Agilent34401.Interop;
using Excel = Microsoft.Office.Interop.Excel;
using Ivi.Dmm.Interop;
//using Excel = Microsoft.Office.Interop.Excel;

namespace LITHIUM_BATTERY
{
    public partial class P6_TEST_PART1 : Form
    {
        String USER = LOGIN_LOGIC.sendtext;
        string SERIAL = SERIAL_LOGIC.sendserial;
        string TEST1 = P1_TEST_PART1B.sendtest1;
        string TEST2 = P1_TEST_PART1B.sendtest2;
        String TEST3 = P1_TEST_PART2B.sendtest3;
        String TEST4 = P1_TEST_PART2B.sendtest4;
        String TEST5 = P2_TEST_PART1.sendtest5;
        String TEST6 = P2_TEST_PART1.sendtest6;
        // private bool button1WasClicked = false;
        double retval;
        double test1;
        string test2;
        Agilent34401 v34401A = new Agilent34401();
        public P6_TEST_PART1()
        {
            InitializeComponent();
            next_step.Enabled = false;
            //stagefail_step.Enabled = false;
        }
        public static string sendtest7 = "";
        public static string sendtest8 = "";
        private void start_logic_Click(object sender, EventArgs e)
        {
            // double test3;
            MessageBox.Show("ADJUST THE LOAD TO JUST BEFORE VOLTAGE & CURRENT CUTOFF CONDITION & CHECK CONNECTIONS");
            Thread.Sleep(500);
            v34401A.Initialize("ASRL1::INSTR", false, false, "");
            v34401A.DCVoltage.Configure(1000, 1000);
            Thread.Sleep(1000);
            test1 = v34401A.Measurement.Read(1000);
            // serialPort1.Write("V2O?\n");
            // test1 = serialPort1.ReadLine();
            sendtest7 = Convert.ToString(test1);
            // if (test1 > 9 && test1 < 10.5)
            // {
            trip_voltage.Text = Convert.ToString(test1);
            //trip_voltage.BackColor = Color.Green;
            //  }
            //  else
            // {
            //    trip_voltage.Text = Convert.ToString(test1);
            // trip_voltage.BackColor = Color.Red;

            //    trip_voltage.Text = "";
            // trip_voltage.Text = "";
            //   return;
            // }
            Thread.Sleep(500);
            serialPort1.Open();
            serialPort1.Write("I2O?\n");
            test2 = serialPort1.ReadLine(); //need to check
            sendtest8 = test2;
            Thread.Sleep(500);
            // test3 = Convert.ToDouble(test2);
            //  if (test3 > 2.40 && test3 < 2.53)
            // {
            trip_current.Text = test2;
            //   trip_current.BackColor = Color.Green;
            // }
            //  else
            // {
            //    trip_current.Text = test2;
            //    trip_current.BackColor = Color.Red;
            // }
            serialPort1.Close();
            // MessageBox.Show("Check the whether the Displayed Voltage & Current correct or not ?");
            next_step.Enabled = true;
            // stagefail_step.Enabled = true;
            start_logic.Enabled = false;
        }

        private void next_step_Click(object sender, EventArgs e)
        {
            if (test1 > 8 && test1 < 10.5)
            {
                serialPort1.Open();
                Thread.Sleep(500);
                serialPort1.Write("OP2 0\n");
                serialPort1.Close();
                string A = "PASS";
                string B = "_";
                DateTime TO = DateTime.Now;
                String TODAY = Convert.ToString(TO);
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"E:\Resources\Report\LITHIUM BATTERY TEST REPORT.xls");
                Excel.Worksheet xlWorkSheet = xlWorkbook.ActiveSheet;
                // Excel.Range range;
                xlWorkSheet.Cells[11, 1] = SERIAL;
                //Thread.Sleep(50);
                xlWorkSheet.Cells[11, 2] = TEST1;
                // Thread.Sleep(50);
                xlWorkSheet.Cells[11, 3] = TEST2;
                // Thread.Sleep(50);
                xlWorkSheet.Cells[11, 4] = TEST3;
                //Thread.Sleep(50);
                xlWorkSheet.Cells[11, 5] = TEST4;
                // Thread.Sleep(50);
                xlWorkSheet.Cells[11, 6] = TEST5;
                // Thread.Sleep(50);
                xlWorkSheet.Cells[11, 7] = TEST6;
                // Thread.Sleep(50);
                xlWorkSheet.Cells[11, 8] = sendtest7;
                // Thread.Sleep(50);
                xlWorkSheet.Cells[11, 9] = sendtest8;
                // Thread.Sleep(50);
                xlWorkSheet.Cells[6, 2] = TODAY;
                // Thread.Sleep(50);
                xlWorkSheet.Cells[5, 2] = USER;
                // Thread.Sleep(50);
                xlWorkSheet.Cells[11, 10] = "PASS";
                serialPort1.Open();
                v34401A.Close();
                Thread.Sleep(1000);
                string filename = SERIAL + B + A + ".xls";
                xlWorkbook.SaveAs(@"E:\Resources\LITHIUM BATTERY\" + filename);
                // Thread.Sleep(3000);
                xlWorkbook.Close();
                xlApp.Quit();
                Thread.Sleep(500);
                serialPort1.Write("OP1 0\n");
                serialPort1.Close();
                PASS PART = new PASS();
                this.Hide();
                PART.ShowDialog();
            }
            else
            {
                serialPort1.Open();
                Thread.Sleep(500);
                serialPort1.Write("OP2 0\n");
                serialPort1.Close();
                string A = "FAIL";
                string B = "_";
                DateTime TO = DateTime.Now;
                String TODAY = Convert.ToString(TO);
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"E:\Resources\Report\LITHIUM BATTERY TEST REPORT.xls");
                Excel.Worksheet xlWorkSheet = xlWorkbook.ActiveSheet;
                // Excel.Range range;
                xlWorkSheet.Cells[11, 1] = SERIAL;
                xlWorkSheet.Cells[11, 2] = TEST1;
                xlWorkSheet.Cells[11, 3] = TEST2;
                xlWorkSheet.Cells[11, 4] = TEST3;
                xlWorkSheet.Cells[11, 5] = TEST4;
                xlWorkSheet.Cells[11, 6] = TEST5;
                xlWorkSheet.Cells[11, 7] = TEST6;
                xlWorkSheet.Cells[11, 8] = sendtest7;
                xlWorkSheet.Cells[11, 9] = sendtest8;
                xlWorkSheet.Cells[6, 2] = TODAY;
                xlWorkSheet.Cells[5, 2] = USER;
                xlWorkSheet.Cells[11, 10] = "FAIL";

                // serialPort1.Open();
                // Thread.Sleep(500);
                // serialPort1.Write("OP1 0\n");
                // serialPort1.Close();

                Thread.Sleep(3000);
                string filename = SERIAL + B + A + ".xls";
                xlWorkbook.SaveAs(@"E:\Resources\LITHIUM BATTERY\" + filename);
                Thread.Sleep(3000);
                v34401A.Close();
                xlWorkbook.Close();
                xlApp.Quit();
                FAIL PART = new FAIL();
                this.Hide();
                PART.ShowDialog();

            }
        }

        private void stagefail_step_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            Thread.Sleep(500);
            serialPort1.Write("OP1 0\n");
            serialPort1.Close();
            FAIL PART = new FAIL();
            this.Hide();
            PART.ShowDialog();
            v34401A.Close();
        }

        private void resistace_check_Click(object sender, EventArgs e)
        {

            Votage_test.Enabled = false;
            start_logic.Enabled = false;
            next_step.Enabled = false;
            //stagefail_step.Enabled = false;
            v34401A.Initialize("ASRL1::INSTR", false, false, "");
            try
            {
                v34401A.IviDmm.Configure(Ivi.Dmm.Interop.IviDmmFunctionEnum.IviDmmFunction2WireRes, 100, 3000);
            }
            catch (Exception ex)
            {

            }
            // bool val = v34401A.Resistance.AutoRange;
            v34401A.Resistance.Configure(10, 10);

            Thread.Sleep(1000);
            retval = v34401A.Measurement.Read(3000);
            RESULT_VALUE.Text = Convert.ToString(retval);
            if (retval < 5)
            {
                MessageBox.Show("Increse the Resistance > 5 ohm");
                v34401A.Close();
                return;
            }
            else
            {
                v34401A.Close();
                Votage_test.Enabled = true;
            }
        }

        private void Votage_test_Click(object sender, EventArgs e)
        {
            start_logic.Enabled = false;
            //button1WasClicked = true;
            resistace_check.Enabled = false;
            serialPort1.Open();
            Thread.Sleep(500);
            //thread.sleep(100);
            serialPort1.Write("*RST\n");
            Thread.Sleep(500);
            // MessageBox.Show(serialPort1.ReadExisting());
            // string test = serialPort1.ReadExisting();
            serialPort1.Write("V2 10.8\n");
            Thread.Sleep(500);
            //MessageBox.Show(serialPort1.ReadExisting());
            //Thread.Sleep(100);
            serialPort1.Write("I2 3\n");
            Thread.Sleep(100);
            serialPort1.Write("OP2 1\n");
            //serialPort1.Write("OP1 0");
            serialPort1.Close();
            start_logic.Enabled = true;
            Votage_test.Enabled = false;
        }

        private void resistace_check_Click_1(object sender, EventArgs e)
        {
            Votage_test.Enabled = false;
            start_logic.Enabled = false;
            next_step.Enabled = false;
            //stagefail_step.Enabled = false;
            v34401A.Initialize("ASRL1::INSTR", false, false, "");
            try
            {
                v34401A.IviDmm.Configure(Ivi.Dmm.Interop.IviDmmFunctionEnum.IviDmmFunction2WireRes, 100, 3000);
            }
            catch (Exception ex)
            {

            }
            // bool val = v34401A.Resistance.AutoRange;
            v34401A.Resistance.Configure(10, 10);

            Thread.Sleep(1000);
            retval = v34401A.Measurement.Read(3000);
            RESULT_VALUE.Text = Convert.ToString(retval);
            if (retval < 5)
            {
                MessageBox.Show("Increse the Resistance > 5 ohm");
                v34401A.Close();
                return;
            }
            else
            {
                v34401A.Close();
                Votage_test.Enabled = true;
            }
        }

        private void start_logic_Click_1(object sender, EventArgs e)
        {
            // double test3;
            MessageBox.Show("ADJUST THE LOAD TO JUST BEFORE VOLTAGE & CURRENT CUTOFF CONDITION & CHECK CONNECTIONS");
            Thread.Sleep(500);
            v34401A.Initialize("ASRL1::INSTR", false, false, "");
            v34401A.DCVoltage.Configure(1000, 1000);
            Thread.Sleep(1000);
            test1 = v34401A.Measurement.Read(1000);
            // serialPort1.Write("V2O?\n");
            // test1 = serialPort1.ReadLine();
            sendtest7 = Convert.ToString(test1);
            // if (test1 > 9 && test1 < 10.5)
            // {
            trip_voltage.Text = Convert.ToString(test1);
            //trip_voltage.BackColor = Color.Green;
            //  }
            //  else
            // {
            //    trip_voltage.Text = Convert.ToString(test1);
            // trip_voltage.BackColor = Color.Red;

            //    trip_voltage.Text = "";
            // trip_voltage.Text = "";
            //   return;
            // }
            Thread.Sleep(500);
            serialPort1.Open();
            serialPort1.Write("I2O?\n");
            test2 = serialPort1.ReadLine(); //need to check
            sendtest8 = test2;
            Thread.Sleep(500);
            // test3 = Convert.ToDouble(test2);
            //  if (test3 > 2.40 && test3 < 2.53)
            // {
            trip_current.Text = test2;
            //   trip_current.BackColor = Color.Green;
            // }
            //  else
            // {
            //    trip_current.Text = test2;
            //    trip_current.BackColor = Color.Red;
            // }
            serialPort1.Close();
            // MessageBox.Show("Check the whether the Displayed Voltage & Current correct or not ?");
            next_step.Enabled = true;
            // stagefail_step.Enabled = true;
            start_logic.Enabled = false;
        }

        private void next_step_Click_1(object sender, EventArgs e)
        {
            if (test1 > 7 && test1 < 10.5)
            {
                serialPort1.Open();
                Thread.Sleep(500);
                serialPort1.Write("OP2 0\n");
                serialPort1.Close();
                string A = "PASS";
                string B = "_";
                DateTime TO = DateTime.Now;
                String TODAY = Convert.ToString(TO);
                Thread.Sleep(200);
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"E:\Resources\Report\LITHIUM BATTERY TEST REPORT.xls");
                Excel.Worksheet xlWorkSheet = xlWorkbook.ActiveSheet;
                // Excel.Range range;
                xlWorkSheet.Cells[11, 1] = SERIAL;
                //Thread.Sleep(50);
                xlWorkSheet.Cells[11, 2] = TEST1;
                // Thread.Sleep(50);
                xlWorkSheet.Cells[11, 3] = TEST2;
                // Thread.Sleep(50);
                xlWorkSheet.Cells[11, 4] = TEST3;
                //Thread.Sleep(50);
                xlWorkSheet.Cells[11, 5] = TEST4;
                // Thread.Sleep(50);
                xlWorkSheet.Cells[11, 6] = TEST5;
                // Thread.Sleep(50);
                xlWorkSheet.Cells[11, 7] = TEST6;
                // Thread.Sleep(50);
                xlWorkSheet.Cells[11, 8] = sendtest7;
                // Thread.Sleep(50);
                xlWorkSheet.Cells[11, 9] = sendtest8;
                // Thread.Sleep(50);
                xlWorkSheet.Cells[6, 2] = TODAY;
                // Thread.Sleep(50);
                xlWorkSheet.Cells[5, 2] = USER;
                // Thread.Sleep(50);
                xlWorkSheet.Cells[11, 10] = "PASS";
                serialPort1.Open();
                v34401A.Close();
                Thread.Sleep(1000);
                string filename = SERIAL + B + A + ".xls";
                xlWorkbook.SaveAs(@"E:\Resources\LITHIUM BATTERY\" + filename);
                // Thread.Sleep(3000);
                xlWorkbook.Close();
                xlApp.Quit();
                Thread.Sleep(500);
                serialPort1.Write("OP1 0\n");
                serialPort1.Close();
                PASS PART = new PASS();
                this.Hide();
                PART.ShowDialog();
            }
            else
            {
                serialPort1.Open();
                Thread.Sleep(500);
                serialPort1.Write("OP2 0\n");
                serialPort1.Close();
                string A = "FAIL";
                string B = "_";
                DateTime TO = DateTime.Now;
                String TODAY = Convert.ToString(TO);
                Thread.Sleep(200);
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"E:\Resources\Report\LITHIUM BATTERY TEST REPORT.xls");
                Excel.Worksheet xlWorkSheet = xlWorkbook.ActiveSheet;
                // Excel.Range range;
                xlWorkSheet.Cells[11, 1] = SERIAL;
                xlWorkSheet.Cells[11, 2] = TEST1;
                xlWorkSheet.Cells[11, 3] = TEST2;
                xlWorkSheet.Cells[11, 4] = TEST3;
                xlWorkSheet.Cells[11, 5] = TEST4;
                xlWorkSheet.Cells[11, 6] = TEST5;
                xlWorkSheet.Cells[11, 7] = TEST6;
                xlWorkSheet.Cells[11, 8] = sendtest7;
                xlWorkSheet.Cells[11, 9] = sendtest8;
                xlWorkSheet.Cells[6, 2] = TODAY;
                xlWorkSheet.Cells[5, 2] = USER;
                xlWorkSheet.Cells[11, 10] = "FAIL";

                // serialPort1.Open();
                // Thread.Sleep(500);
                // serialPort1.Write("OP1 0\n");
                // serialPort1.Close();

                Thread.Sleep(3000);
                string filename = SERIAL + B + A + ".xls";
                xlWorkbook.SaveAs(@"E:\Resources\LITHIUM BATTERY\" + filename);
                Thread.Sleep(3000);
                v34401A.Close();
                xlWorkbook.Close();
                xlApp.Quit();
                FAIL PART = new FAIL();
                this.Hide();
                PART.ShowDialog();

            }
        }
    }
}

