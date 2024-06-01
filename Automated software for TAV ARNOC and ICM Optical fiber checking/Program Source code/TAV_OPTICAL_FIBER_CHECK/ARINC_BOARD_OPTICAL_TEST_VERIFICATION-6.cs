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
using System.Xml;
using System.Diagnostics;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace TAV_OPTICAL_FIBER_CHECK
{
    public partial class ARINC_BOARD_OPTICAL_TEST_VERIFICATION_6 : Form
    {
        string SERIAL1 = ARINC_OPTICAL_CABLE_TEST.send_serial;
      //  string folder_name = ARINC_OPTICAL_CABLE_TEST.send_folder_name;
        string USER = ARINC_OPTICAL_CABLE_TEST.send_operator_name;
        string REPORT1 = ARINC_BOARD_OPTICAL_TEST_VERIFICATION.send_report1;
        string REPORT2 = ARINC_BOARD_OPTICAL_TEST_VERIFICATION_2.send_report2;
        string REPORT3 = ARINC_BOARD_OPTICAL_TEST_VERIFICATION_3.send_report3;
        string REPORT4 = ARINC_BOARD_OPTICAL_TEST_VERIFICATION_4.send_report4;
        string REPORT5 = ARINC_BOARD_OPTICAL_TEST_VERIFICATION_5.send_report5;
        

        public ARINC_BOARD_OPTICAL_TEST_VERIFICATION_6()
        {
            InitializeComponent();
        }

        private void SUBMIT_Click(object sender, EventArgs e)
        {
            Select_report.Enabled = false;
            StringBuilder text = new StringBuilder();
            using (PdfReader reader = new PdfReader(LOG_PATH.Text))

            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }
                //TrimEnd(text, 'F');
                //MessageBox.Show(text.ToString());


            }
            string REPORT6 = LOG_PATH.Text;
            //richTextBox1.Text = text.ToString();
            if (text.ToString().Contains("Fail"))
            {
                MessageBox.Show("6th Optical fiber check Failed");
                string STATUS = "6th Optical fiber check Failed";
                string RESULT = "FAIL";
                // string folder_name = SERIAL1 + "_" + DateTime.Now.ToString("ddMMyyyy_hhmmss");
                string A = "_";
                string filename = SERIAL1 + A + RESULT + A+  DateTime.Now.ToString("ddMMyyyy_hhmmss") + ".txt";
                System.IO.StreamWriter swExtLogFile = new System.IO.StreamWriter(@"D:\Resources\Report\arinc optical cable test\" + "\\" + filename, true);
                DataTable dt = new DataTable();
                //Adding data To DataTable
                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("STATS");
                dt.Columns.Add("RESULT");
                dt.Rows.Add(1, "USERNAME", USER);
                dt.Rows.Add(2, "SERIAL NUMBER", SERIAL1);
                dt.Rows.Add(3, "STATUS)", STATUS);
                dt.Rows.Add(3, "RESULT", RESULT);

                int i;
                swExtLogFile.Write(Environment.NewLine);
                foreach (DataRow row in dt.Rows)
                {
                    object[] array = row.ItemArray;
                    for (i = 0; i < array.Length - 1; i++)
                    {
                        swExtLogFile.Write(array[i].ToString() + " -------");
                    }
                    swExtLogFile.WriteLine(array[i].ToString());
                }
                swExtLogFile.Write("*****END OF DATA****" + DateTime.Now.ToString());

                swExtLogFile.Flush();
                swExtLogFile.Close();
                 Process[] processes = Process.GetProcessesByName("FiberChekPro");
                 foreach (var process1 in processes)
                 {
                  process1.Kill();
                 }
                Thread.Sleep(200);
                ARINC_OPTICAL_CABLE_TEST main = new ARINC_OPTICAL_CABLE_TEST();
                this.Hide();
                main.ShowDialog();

            }
            else
            {
                MessageBox.Show("Arinc Board all Optical fiber check PASSED ");
                string STATUS = "PASS";
              //  string folder_name = SERIAL1 + "_" + DateTime.Now.ToString("ddMMyyyy_hhmmss");
                string A = "_";
                string filename = SERIAL1 + A + "PASS" + A + DateTime.Now.ToString("ddMMyyyy_hhmmss") + ".txt";
                System.IO.StreamWriter swExtLogFile = new System.IO.StreamWriter(@"D:\Resources\Report\arinc optical cable test\" +  "\\" + filename, true);
                DataTable dt = new DataTable();
                //Adding data To DataTable
                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Optical Fiber1 Report_Name");
                dt.Columns.Add("Optical Fiber2 Report_Name");
                dt.Columns.Add("Optical Fiber3 Report_Name");
                dt.Columns.Add("Optical Fiber4 Report_Name");
                dt.Columns.Add("Optical Fiber5 Report_Name");
                dt.Columns.Add("Optical Fiber6 Report_Name");
                dt.Columns.Add("RESULT");
                dt.Rows.Add(1, "USERNAME", USER);
                dt.Rows.Add(2, "SERIAL NUMBER", SERIAL1);
                dt.Rows.Add(3, "Optical Fiber1 Report_Name", REPORT1);
                dt.Rows.Add(3, "Optical Fiber2 Report_Name", REPORT2);
                dt.Rows.Add(3, "Optical Fiber3 Report_Name", REPORT3);
                dt.Rows.Add(3, "Optical Fiber4 Report_Name", REPORT4);
                dt.Rows.Add(3, "Optical Fiber5 Report_Name", REPORT5);
                dt.Rows.Add(3, "Optical Fiber6 Report_Name", REPORT6);
                dt.Rows.Add(3, "RESULT", STATUS);

                int i;
                swExtLogFile.Write(Environment.NewLine);
                foreach (DataRow row in dt.Rows)
                {
                    object[] array = row.ItemArray;
                    for (i = 0; i < array.Length - 1; i++)
                    {
                        swExtLogFile.Write(array[i].ToString() + " -------");
                    }
                    swExtLogFile.WriteLine(array[i].ToString());
                }
                swExtLogFile.Write("*****END OF DATA****" + DateTime.Now.ToString());

                swExtLogFile.Flush();
                swExtLogFile.Close();
                Process[] processes = Process.GetProcessesByName("FiberChekPro");
                foreach (var process1 in processes)
                {
                    process1.Kill();
                }
                Thread.Sleep(200);
               // MessageBox.Show("1st Optical fiber check Passed");
                ARINC_OPTICAL_CABLE_TEST main =  new ARINC_OPTICAL_CABLE_TEST();
                this.Hide();
                main.ShowDialog();

            }
        }

        private void start_logic_Click(object sender, EventArgs e)
        {
            Select_report.Enabled = true;
            NOT_OK.Enabled = false;
        }

        private void NOT_OK_Click(object sender, EventArgs e)
        {
            string STATUS = "6th Optical fiber check Failed";
            string RESULT = "FAIL";
            // string folder_name = SERIAL1 + "_" + DateTime.Now.ToString("ddMMyyyy_hhmmss");
            string A = "_";
            string filename = SERIAL1 + A + RESULT + A + DateTime.Now.ToString("ddMMyyyy_hhmmss") + ".txt";
            System.IO.StreamWriter swExtLogFile = new System.IO.StreamWriter(@"D:\Resources\Report\arinc optical cable test\" + "\\" + filename, true);
            DataTable dt = new DataTable();
            //Adding data To DataTable
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("STATS");
            dt.Columns.Add("RESULT");
            dt.Rows.Add(1, "USERNAME", USER);
            dt.Rows.Add(2, "SERIAL NUMBER", SERIAL1);
            dt.Rows.Add(3, "STATUS)", STATUS);
            dt.Rows.Add(3, "RESULT", RESULT);

            int i;
            swExtLogFile.Write(Environment.NewLine);
            foreach (DataRow row in dt.Rows)
            {
                object[] array = row.ItemArray;
                for (i = 0; i < array.Length - 1; i++)
                {
                    swExtLogFile.Write(array[i].ToString() + " -------");
                }
                swExtLogFile.WriteLine(array[i].ToString());
            }
            swExtLogFile.Write("*****END OF DATA****" + DateTime.Now.ToString());

            swExtLogFile.Flush();
            swExtLogFile.Close();
            Process[] processes = Process.GetProcessesByName("FiberChekPro");
           foreach (var process1 in processes)
            {
                process1.Kill();
            }
            Thread.Sleep(200);
            ARINC_OPTICAL_CABLE_TEST main = new ARINC_OPTICAL_CABLE_TEST();
            this.Hide();
            main.ShowDialog();
        }

        private void Select_report_Click(object sender, EventArgs e)
        {
            start_logic.Enabled = false;
            OpenFileDialog folderDlg = new OpenFileDialog();

            // folderDlg.ShowNewFolderButton = true;

            // Show the FolderBrowserDialog.

            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)

            {

                LOG_PATH.Text = folderDlg.FileName;

                // Environment.SpecialFolder root = folderDlg.RootFolder;


            }

            SUBMIT.Enabled = true;
        }

       // private void Select_report_Click(object sender, EventArgs e)
        //{
          //  OpenFileDialog folderDlg = new OpenFileDialog();

            // folderDlg.ShowNewFolderButton = true;

            // Show the FolderBrowserDialog.

           // DialogResult result = folderDlg.ShowDialog();

           // if (result == DialogResult.OK)

           // {

               // LOG_PATH.Text = folderDlg.FileName;

                // Environment.SpecialFolder root = folderDlg.RootFolder;


           // }

          //  SUBMIT.Enabled = true;
        //}
    }
}
