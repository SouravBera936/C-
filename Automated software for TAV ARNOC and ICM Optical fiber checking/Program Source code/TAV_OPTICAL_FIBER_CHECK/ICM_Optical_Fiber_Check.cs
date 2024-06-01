using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Xml;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;


namespace TAV_OPTICAL_FIBER_CHECK
{
    
    public partial class ICM_Optical_Fiber_Check : Form
    {
        //string foldername;
        string Optical_Report ;
        public ICM_Optical_Fiber_Check()
        {
            InitializeComponent();
            start_logic.Enabled = false;
            NOT_OK.Enabled = false;
            SUBMIT.Enabled = false;
            Select_report.Enabled = false;
            START.Enabled = true;
            //public String foldername;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (SERIAL_NUMBER.Text == "" && OPERATOR_NAME.Text == "")
            {
                MessageBox.Show("Please Enter Operator name & Serial Number and Then Continue");
                return;
            }
            else
            {

                string serial;
                serial = SERIAL_NUMBER.Text;
                string foldername = serial + "_" + DateTime.Now.ToString("ddMMyyyy_hhmmss");
                System.IO.Directory.CreateDirectory("D:\\Resources\\Report\\ICM optical cable test\\" + foldername);
                Thread.Sleep(100);
                string str = @"C:\Program Files (x86)\Viavi\FiberChekPRO\FiberChekPro.exe";
                Process process = new Process();
                process.StartInfo.FileName = str;
                Thread.Sleep(500);
                process.Start();
                Thread.Sleep(500);
                start_logic.Enabled = true;
                NOT_OK.Enabled = true;
                START.Enabled = false;


            }
        }

        private void NOT_OK_Click(object sender, EventArgs e)
        {
            String SERIAL1 = SERIAL_NUMBER.Text;
            String USER = OPERATOR_NAME.Text;
            string STATUS = "FAIL";
           // foldername = SERIAL1 + "_" + DateTime.Now.ToString("ddMMyyyy_hhmmss");
            string A = "_";
            string filename = SERIAL1 + A + STATUS +  A + DateTime.Now.ToString("ddMMyyyy_hhmmss") + ".txt";
            System.IO.StreamWriter swExtLogFile = new System.IO.StreamWriter(@"D:\Resources\Report\ICM optical cable test\" +  "\\" + filename, true);
            DataTable dt = new DataTable();
            //Adding data To DataTable
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            //dt.Columns.Add("OUPUT");
            dt.Columns.Add("RESULT");
            dt.Rows.Add(1, "USERNAME", USER);
            dt.Rows.Add(2, "SERIAL NUMBER", SERIAL1);
            //dt.Rows.Add(3, "OUTPUT(3.99mA-4.01mA)", OUTPUT);
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

            SERIAL_NUMBER.Text = "";
            OPERATOR_NAME.Text = "";
            START.Enabled = true;
            LOG_PATH.Text = "";
            return;
            
        }

        private void start_logic_Click(object sender, EventArgs e)
        {
            Select_report.Enabled = true;
            NOT_OK.Enabled = false;
            START.Enabled = false;
            start_logic.Enabled = false;
        }

        //private void Select_report_Click(object sender, EventArgs e)
        //{
        //    FolderBrowserDialog folderDlg = new FolderBrowserDialog();

        //    folderDlg.ShowNewFolderButton = true;

        //    // Show the FolderBrowserDialog.

        //    DialogResult result = folderDlg.ShowDialog();

        //    if (result == DialogResult.OK)

        //    {

        //        LOG_PATH.Text = folderDlg.;

        //        // Environment.SpecialFolder root = folderDlg.RootFolder;
        //        Environment.s root = folderDlg.RootFolder;

        //    }

        //    SUBMIT.Enabled = true;
        //}

        private void Select_report_Click(object sender, EventArgs e)
        {
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
            Optical_Report = LOG_PATH.Text;
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

            //richTextBox1.Text = text.ToString();
            if (text.ToString().Contains("Fail"))
            {
                MessageBox.Show("Optical fiber check Failed");
                String SERIAL1 = SERIAL_NUMBER.Text;
                String USER = OPERATOR_NAME.Text;
                string STATUS = "FAIL";
                //string folder_name = SERIAL1 + "_" + DateTime.Now.ToString("ddMMyyyy_hhmmss");
                string A = "_";
                string filename = SERIAL1 + A + STATUS + A+ DateTime.Now.ToString("ddMMyyyy_hhmmss") + ".txt";
                System.IO.StreamWriter swExtLogFile = new System.IO.StreamWriter(@"D:\Resources\Report\ICM optical cable test\" +  "\\" + filename, true);
                DataTable dt = new DataTable();
                //Adding data To DataTable
                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Optical_Report_Name");
                dt.Columns.Add("RESULT");
                dt.Rows.Add(1, "USERNAME", USER);
                dt.Rows.Add(2, "SERIAL NUMBER", SERIAL1);
                dt.Rows.Add(3, "Optical_Report_Name", Optical_Report);
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

                SERIAL_NUMBER.Text = "";
                OPERATOR_NAME.Text = "";
                SUBMIT.Enabled = false;
                START.Enabled = true;
                LOG_PATH.Text = "";

                return;
               


            }
            else
            {
                MessageBox.Show("Optical fiber check Passed");
                String SERIAL1 = SERIAL_NUMBER.Text;
                String USER = OPERATOR_NAME.Text;
                string STATUS = "PASS";
                //string folder_name = SERIAL1 + "_" + DateTime.Now.ToString("ddMMyyyy_hhmmss");
                string A = "_";
                string filename = SERIAL1 + A + STATUS + A + DateTime.Now.ToString("ddMMyyyy_hhmmss") + ".txt";
                System.IO.StreamWriter swExtLogFile = new System.IO.StreamWriter(@"D:\Resources\Report\ICM optical cable test\" + "\\" + filename, true);
                DataTable dt = new DataTable();
                //Adding data To DataTable
                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Optical_Report_Name");
                dt.Columns.Add("RESULT");
                dt.Rows.Add(1, "USERNAME", USER);
                dt.Rows.Add(2, "SERIAL NUMBER", SERIAL1);
                dt.Rows.Add(3, "Optical_Report_Name", Optical_Report);
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

                SERIAL_NUMBER.Text = "";
                OPERATOR_NAME.Text = "";
                SUBMIT.Enabled = false;
                START.Enabled = true;
                LOG_PATH.Text = "";

                return;


            }
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("FiberChekPro");
            foreach (var process1 in processes)
            {
                process1.Kill();
                return;
            }
                Thread.Sleep(500);

                Application.Exit();
            
        }
    }
}