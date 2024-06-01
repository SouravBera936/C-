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
    public partial class SETUP_CALIBRATION : Form
    {
        String USER = LOGIN_LOGIC.sendtext;
        Agilent34401 v34401A = new Agilent34401();
        private bool button1WasClicked = false;
        public SETUP_CALIBRATION()
        {
            InitializeComponent();
        }

        string value; 
        double C;
        double D;
        double E;
        double F;
        double retval;
        private void START_LOGIC1_Click(object sender, EventArgs e)
        {
            if (CAL_POINT.Text == "")
            {
                MessageBox.Show("Please Enter GOLDEN BOARD CALIBRATION POINT  and Then Continue");
                return;
            }
            else
            {
               
                //START_LOGIC1.Enabled = false;
                START_LOGIC2.Enabled = false;
                TEST_COMPLETED.Enabled = false;
                String GOLDEN = CAL_POINT.Text;
                double INPUT = Convert.ToDouble(GOLDEN);
                double B = 0.01;
                 C = INPUT + B;
                 D = INPUT - B;
                E = C + B;
                F = D - B;
                LSL_VALUE.Text = Convert.ToString(D);
                USL_VALUE.Text = Convert.ToString(C);
                MessageBox.Show("Set the Power switch & LED switch in ON position" );
                MessageBox.Show("Warm the LED for 30 minutes prior to performing tests"); 
                MessageBox.Show("LED WARMUP FOR 30 MIN COMPLETED? ");
                MessageBox.Show("Set the LED switch to the “Off” position");
                MessageBox.Show("Set the Power switch in the “On” position.");
               
                try
                {
                    // Initializing and Configuring 34401A
                    v34401A.Initialize("ASRL1::INSTR", false, false, "");
                    // v34401A.DCCurrent.Configure(0.1, 10);
                    bool val = v34401A.DCCurrent.AutoRange;

                }
                catch (Exception ex)
                {
                    // executes if initializing and configuring fails
                    MessageBox.Show(ex.Message);
                    START_LOGIC1.Enabled = true;
                    return;
                }
                Thread.Sleep(1000);
                // Measuring Value from 34401A
                retval = v34401A.Measurement.Read(1000);
                //Converting the obtained Value from A to mA range
                //value = retval * 1000
                retval = retval * 1000;
                retval = Math.Round(retval, 2);
                RESULT_VALUE.Text = Convert.ToString(retval);
                if (retval < 4.02 && retval > 3.98)
                {
                    
                    RESULT_VALUE.BackColor = Color.Green;
                    value = RESULT_VALUE.Text;
                    MessageBox.Show("CONTINUE FOR MINIMUM LIGHT OUTPUT TEST");
                    START_LOGIC2.Enabled = true;
                    START_LOGIC1.Enabled = false;
                    TEST_COMPLETED.Enabled = false;
                    // button1WasClicked = true;
                }
                else
                {
                    // RESULT_VALUE.Text = Convert.ToString(retval);
                    RESULT_VALUE.BackColor = Color.Red;
                    MessageBox.Show("CHECK THE CONNECTIONS & TEST AGAIN");
                    MessageBox.Show("SAME FAIL REPEATING THEN CALL TEST ENGINEER");
                    START_LOGIC1.Enabled = true;
                    START_LOGIC2.Enabled = false;
                    TEST_COMPLETED.Enabled = false;
                    //  button1WasClicked = true;
                    // timer1.Enabled = true;
                    RESULT_VALUE.Text = "";
                    RESULT_VALUE.BackColor = Color.White;
                }

                v34401A.Close();




            }

        }

        private void START_LOGIC2_Click(object sender, EventArgs e)
        {
           // RESULT_VALUE.Text = "";
            START_LOGIC1.Enabled = false;
            TEST_COMPLETED.Enabled = false;
           

            // BOARD_START.Enabled = false;
            TEST_COMPLETED.Enabled = true;
            try
            {
                // Initializing and Configuring 34401A
                v34401A.Initialize("ASRL1::INSTR", false, false, "");
                // v34401A.DCCurrent.Configure(0.1, 10);
                bool val = v34401A.DCCurrent.AutoRange;

            }
            catch (Exception ex)
            {
                // executes if initializing and configuring fails
                MessageBox.Show(ex.Message);
                START_LOGIC1.Enabled = true;
                return;
            }
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_Dowork;
            worker.ProgressChanged += worker_Progresschanged;
            // worker.RunWorkerCompleted += worker_RunworkerCompleted;
            worker.RunWorkerAsync();
            // testing starts




        }
    
    double retvalvalue;
    private void worker_Dowork(object sender, DoWorkEventArgs e)
    {
            //MessageBox.Show(USER);
            MessageBox.Show("Set the LED switch to the “On” position");
            MessageBox.Show("Adjust the blue potentiometer on the 24V LED regulator board until the ammeter reads ±0.01mA of the calibrated Golden board minimum light output");
           
            while (button1WasClicked == false)
        {
            // declaring measuring function
            // Measure();
            
            Thread.Sleep(1000);
                // Measuring Value from 34401A
                retvalvalue = v34401A.Measurement.Read(1000);
                //Converting the obtained Value from A to mA range
                //value = retval * 1000
                retvalvalue = retvalvalue * 1000;
                retvalvalue = Math.Round(retvalvalue, 2);
            //(sender as BackgroundWorker).ReportProgress(1);
            //  RESULT_VALUE.MaxLength = 4;
            //Converting the mA value to string to display it in the textbox
            // RESULT_VALUE.Text = retval.ToString("0.##");

            // double val = value;
            //converting the lsl and usl value to double for the comparison
            //  double lsl = Convert.ToDouble(LSL_VALUE_txtbx.Text);
            // double usl = Convert.ToDouble(USL_VALUE_txtbx.Text);
            //Comparing if the obtained value is within the limit
            if (retvalvalue < E && retvalvalue > F)
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
            RESULT_VALUE1.Text = Convert.ToString(retvalvalue);
        }
        if (e.ProgressPercentage == 2)
        {
            RESULT_VALUE1.Text = Convert.ToString(retvalvalue);
            RESULT_VALUE1.BackColor = Color.Green;
        }
        if (e.ProgressPercentage == 3)
        {
            RESULT_VALUE1.Text = Convert.ToString(retvalvalue);
            RESULT_VALUE1.BackColor = Color.Red;
        }
    }

        private void TEST_COMPLETED_Click(object sender, EventArgs e)
        {
            START_LOGIC1.Enabled = false;
            START_LOGIC2.Enabled = false;
            
            string status = "";
            if (retvalvalue < E && retvalvalue > F)
            {
                // timer1.Enabled = false;
                MessageBox.Show("Setup calibration PASSED");
                status = "PASS";
                DateTime TO = DateTime.Now;
                String TODAY = Convert.ToString(TO);

                XmlDocument report = new XmlDocument();
                string reporttemplatefilepath = @"E:\Resources\FS-9009-60\SETUP CALIBRATION\Test Report.xml";
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
                //XmlElement Serial_1 = report.CreateElement("Serial_No");
                XmlElement DATE_1 = report.CreateElement("DATE");
                XmlElement test1 = report.CreateElement("NO_LIGHT_OUTPUT");
                XmlElement test2 = report.CreateElement("MINIMUM_LIGHT_OUTPUT");
                // XmlElement value = report.CreateElement("Output_Current");
                XmlElement result = report.CreateElement("Test_status");
                button1WasClicked = true;
                String OUTPUT = RESULT_VALUE1.Text;
                double OUT = Convert.ToDouble(OUTPUT);
                name_1.InnerText = USER;
                // Serial_1.InnerText = sl_no_txtbx.Text;
                DATE_1.InnerText = TODAY;
                test1.InnerText = value;
                test2.InnerText = OUTPUT;
                //value.InnerText = OUTPUT;
                result.InnerText = status;
                rootdut1.AppendChild(name_1);
                // rootdut1.AppendChild(Serial_1);
                rootdut1.AppendChild(DATE_1);
                rootdut1.AppendChild(test1);
                // rootdut1.AppendChild(value);
                rootdut1.AppendChild(test2);
                rootdut1.AppendChild(result);
                report.DocumentElement.AppendChild(rootdut1);
                report.Save(reporttemplatefilepath);
                v34401A.Close();
                BOARD_TEST BOARD = new BOARD_TEST();
                this.Hide();
                BOARD.ShowDialog();
            }
            else
            {

                START_LOGIC1.Enabled = false;
                START_LOGIC2.Enabled = true;
                TEST_COMPLETED.Enabled = false;
                // timer1.Enabled = false;
                MessageBox.Show("Setup calibration FAILED");
                MessageBox.Show("CHECK THE CONNECTIONS & TEST AGAIN");
                MessageBox.Show("SAME FAIL REPEATING THEN CALL TEST ENGINEER");
               // status = "FAIL";
                RESULT_VALUE.Text = "";
                RESULT_VALUE1.Text = "";
                RESULT_VALUE1.BackColor = Color.White;
                RESULT_VALUE.BackColor = Color.White;
                v34401A.Close();
            }
           
        }
    }
    }

    

