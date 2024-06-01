using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agilent.Agilent34401.Interop;
using System.Xml;
using System.Threading;
using System.IO;

namespace WindowsFormsApplication4
{
    public partial class MAIN_FORM : Form
    {
        String USER = LOGIN_LOGIC.sendtext;
        // Declaring object for agilent 34401A
        Agilent34401 v34401A = new Agilent34401();
        // Declaring a variable for the identification of test completed butten click
        private bool button1WasClicked = false;
        public MAIN_FORM()
        {
            InitializeComponent();
        }
      //  double value ;
        // test butten click
        public void BOARD_START_Click(object sender, EventArgs e)
        {
            
            // cheching if serial Number text box is empty
            if (sl_no_txtbx.Text == "")
            {
                MessageBox.Show("Please Enter Serial Number and Then Continue");
                return;
            }
            else
            {
                try
                {
                    // Initializing and Configuring 34401A
                    v34401A.Initialize("ASRL1::INSTR", false, false, "");
                   // v34401A.DCCurrent.Configure(0.1, 10);
                    //v34401A.Close();
                    bool val = v34401A.DCCurrent.AutoRange;

                }
                catch (Exception ex)
                {
                    // executes if initializing and configuring fails
                    MessageBox.Show(ex.Message);
                    BOARD_START.Enabled = true;
                    return;
                }
                BOARD_START.Enabled = false;
                TEST_COMPLETED.Enabled = true;
                BackgroundWorker worker = new BackgroundWorker();
                worker.WorkerSupportsCancellation = true;
                worker.WorkerReportsProgress = true;
                worker.DoWork += worker_Dowork;
                worker.ProgressChanged += worker_Progresschanged;
               // worker.RunWorkerCompleted += worker_RunworkerCompleted;
                worker.RunWorkerAsync();
                // testing starts
                
               
               
                
            }
        }
        double retval;
        private void worker_Dowork(object sender, DoWorkEventArgs e)
        {
            //MessageBox.Show(USER);
            //MessageBox.Show("SWITCH ON POWER SWITCH ");
            serialPort1.Open();
            Thread.Sleep(500);
            //thread.sleep(100);
            serialPort1.Write("*RST\n");
            Thread.Sleep(500);
           // MessageBox.Show(serialPort1.ReadExisting());
            // string test = serialPort1.ReadExisting();
            serialPort1.Write("V2 24\n");
            Thread.Sleep(500);
            //MessageBox.Show(serialPort1.ReadExisting());
            //Thread.Sleep(100);
            serialPort1.Write("I2 1\n");
            Thread.Sleep(100);
            serialPort1.Write("OP2 1\n");
            //serialPort1.Write("OP1 0");
            serialPort1.Close();
            MessageBox.Show("ADJUST POTENTIOMETER");
            while (button1WasClicked == false)
            {
                // declaring measuring function
                // Measure();
               
                Thread.Sleep(1000);
                // Measuring Value from 34401A
                Thread.Sleep(1000);
                retval = v34401A.Measurement.Read(1000);
                //Converting the obtained Value from A to mA range
                //value = retval * 1000
                retval = retval * 1000;
                retval = Math.Round(retval,2);
                //(sender as BackgroundWorker).ReportProgress(1);
                //  RESULT_VALUE.MaxLength = 4;
                //Converting the mA value to string to display it in the textbox
                // RESULT_VALUE.Text = retval.ToString("0.##");

               // double val = value;
                //converting the lsl and usl value to double for the comparison
                //  double lsl = Convert.ToDouble(LSL_VALUE_txtbx.Text);
                // double usl = Convert.ToDouble(USL_VALUE_txtbx.Text);
                //Comparing if the obtained value is within the limit
                if (retval < 4.02 && retval > 3.98)
                {
                    (sender as BackgroundWorker).ReportProgress(2);
                 //   RESULT_VALUE.BackColor = Color.Green;
                  //  button1WasClicked = true;
                    // timer1.Enabled = true;

                }
                else
                {
                    (sender as BackgroundWorker).ReportProgress(3);
                 //   RESULT_VALUE.BackColor = Color.Red;
                  //  button1WasClicked = true;
                    // timer1.Enabled = true;
                }

               // v34401A.Close();

            }
        }
      

        
        private void worker_Progresschanged(object sender, ProgressChangedEventArgs e)
        {

            if (e.ProgressPercentage == 1)
            {
                RESULT_VALUE.Text = Convert.ToString(retval);
            }
            if (e.ProgressPercentage==2)
            {
                RESULT_VALUE.Text = Convert.ToString(retval);
                RESULT_VALUE.BackColor = Color.Green;
            }
            if(e.ProgressPercentage==3)
            {
                RESULT_VALUE.Text = Convert.ToString(retval);
                RESULT_VALUE.BackColor = Color.Red;
            }
        }
        private void MAIN_FORM_Load(object sender, EventArgs e)
        {
            TEST_COMPLETED.Enabled = false;
            // declaring object for loadiing xml file
            DataSet ds = new DataSet();
            //reading xml file
            XmlReader xmlfile = XmlReader.Create(@"E:\Resources\Config\config.xml");

            ds.ReadXml(xmlfile);
            //displaying the lsl and usl value from config xml file to curresponding textbox
            LSL_VALUE_txtbx.Text = Convert.ToString(ds.Tables[0].Rows[0][2]);
            USL_VALUE_txtbx.Text = Convert.ToString(ds.Tables[0].Rows[0][1]);


            ds.ReadXml(xmlfile);
            //  ds.Dispose();
            xmlfile.Close();

        }

        private void TEST_COMPLETED_Click(object sender, EventArgs e)
        {
            //v34401A.Close();
            string A = "_";
            DateTime TO = DateTime.Now;
            String TODAY = Convert.ToString(TO);
            XmlDocument report = new XmlDocument();
            string reporttemplatefilepath = @"E:\Resources\FS-9009-29\Test Report.xml";
            if (!File.Exists(reporttemplatefilepath))
            {
                XmlNode docNode = report.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlNode reportnode = report.CreateElement("report");
                report.AppendChild(docNode);
                report.AppendChild(reportnode);
                report.Save(reporttemplatefilepath);
            }
            report.Load(reporttemplatefilepath);
            XmlElement rootdut1 = report.CreateElement("testreport");
            XmlElement name_1 = report.CreateElement("Username");
            XmlElement Serial_1 = report.CreateElement("Serial_No");
            XmlElement DATE_1 = report.CreateElement("DATE");
            XmlElement usl1 = report.CreateElement("USL");
            XmlElement lsl1 = report.CreateElement("LSL");
            XmlElement value = report.CreateElement("Output_Current");
            XmlElement result = report.CreateElement("Test_status");

            button1WasClicked = true;
            String OUTPUT = RESULT_VALUE.Text;
            string status = "";
            if (RESULT_VALUE.BackColor == Color.Green)
            {
                // timer1.Enabled = false;
               // MessageBox.Show("Board PASS");
                status = "PASS";
                name_1.InnerText = USER;
                Serial_1.InnerText = sl_no_txtbx.Text;
                DATE_1.InnerText = TODAY;
                usl1.InnerText = USL_VALUE_txtbx.Text;
                lsl1.InnerText = LSL_VALUE_txtbx.Text;
                value.InnerText = OUTPUT;
                result.InnerText = status;
                rootdut1.AppendChild(name_1);
                rootdut1.AppendChild(Serial_1);
                rootdut1.AppendChild(DATE_1);
                rootdut1.AppendChild(usl1);
                rootdut1.AppendChild(value);
                rootdut1.AppendChild(lsl1);
                rootdut1.AppendChild(result);
                report.DocumentElement.AppendChild(rootdut1);
                report.Save(reporttemplatefilepath);
                string filename = sl_no_txtbx.Text +A+status+ ".txt";
                System.IO.StreamWriter swExtLogFile = new System.IO.StreamWriter(@"E:\Resources\FS-9009-29\Test Report\" + filename, true);
                DataTable dt = new DataTable();
                //Adding data To DataTable
                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("OUPUT");
                dt.Columns.Add("RESULT");
                dt.Rows.Add(1, "USERNAME", USER);
                dt.Rows.Add(2, "SERIAL NUMBER", sl_no_txtbx.Text);
                dt.Rows.Add(3, "OUTPUT(3.99mA-4.01mA)", OUTPUT);
                dt.Rows.Add(4, "RESULT", status);

                int i;
                swExtLogFile.Write(Environment.NewLine);
                foreach (DataRow row in dt.Rows)
                {
                    object[] array = row.ItemArray;
                    for (i = 0; i < array.Length - 1; i++)
                    {
                        swExtLogFile.Write(array[i].ToString() + " | ");
                    }
                    swExtLogFile.WriteLine(array[i].ToString());
                }
                swExtLogFile.Write("*****END OF DATA****" + DateTime.Now.ToString());

                swExtLogFile.Flush();
                swExtLogFile.Close();
                sl_no_txtbx.Text = "";
                RESULT_VALUE.Text = "";
                RESULT_VALUE.BackColor = Color.White;
                TEST_COMPLETED.Enabled = false;
                BOARD_START.Enabled = true;
                button1WasClicked = false;
                serialPort1.Open();
                Thread.Sleep(100);
                serialPort1.Write("OP2 0\n");
                Thread.Sleep(100);
                serialPort1.Close();
                v34401A.Close();
                PASS main = new PASS();
                this.Hide();
                main.ShowDialog();

            }
            else
            {
                // timer1.Enabled = false;
               // MessageBox.Show("Board FAIL");
                status = "FAIL";

                name_1.InnerText = USER;
                Serial_1.InnerText = sl_no_txtbx.Text;
                DATE_1.InnerText = TODAY;
                usl1.InnerText = USL_VALUE_txtbx.Text;
                lsl1.InnerText = LSL_VALUE_txtbx.Text;
                value.InnerText = OUTPUT;
                result.InnerText = status;
                rootdut1.AppendChild(name_1);
                rootdut1.AppendChild(Serial_1);
                rootdut1.AppendChild(DATE_1);
                rootdut1.AppendChild(usl1);
                rootdut1.AppendChild(value);
                rootdut1.AppendChild(lsl1);
                rootdut1.AppendChild(result);
                report.DocumentElement.AppendChild(rootdut1);
                report.Save(reporttemplatefilepath);
                string filename = sl_no_txtbx.Text +A+ status + ".txt";
                System.IO.StreamWriter swExtLogFile = new System.IO.StreamWriter(@"E:\Resources\FS-9009-29\Test Report\" + filename, true);
                DataTable dt = new DataTable();
                //Adding data To DataTable
                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("OUPUT");
                dt.Columns.Add("RESULT");
                dt.Rows.Add(1, "USERNAME", USER);
                dt.Rows.Add(2, "SERIAL NUMBER", sl_no_txtbx.Text);
                dt.Rows.Add(3, "OUTPUT(3.99mA-4.01mA)", OUTPUT);
                dt.Rows.Add(4, "RESULT", status);

                int i;
                swExtLogFile.Write(Environment.NewLine);
                foreach (DataRow row in dt.Rows)
                {
                    object[] array = row.ItemArray;
                    for (i = 0; i < array.Length - 1; i++)
                    {
                        swExtLogFile.Write(array[i].ToString() + " | ");
                    }
                    swExtLogFile.WriteLine(array[i].ToString());
                }
                swExtLogFile.Write("*****END OF DATA****" + DateTime.Now.ToString());

                swExtLogFile.Flush();
                swExtLogFile.Close();
                sl_no_txtbx.Text = "";
                RESULT_VALUE.Text = "";
                RESULT_VALUE.BackColor = Color.White;
                TEST_COMPLETED.Enabled = false;
                BOARD_START.Enabled = true;
                button1WasClicked = false;
                serialPort1.Open();
                Thread.Sleep(100);
                serialPort1.Write("OP2 0\n");
                Thread.Sleep(100);
                serialPort1.Close();
                v34401A.Close();
                FAIL main = new FAIL();
                this.Hide();
                main.ShowDialog();
            }
        }
        private void MAIN_FORM_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

      
    }

