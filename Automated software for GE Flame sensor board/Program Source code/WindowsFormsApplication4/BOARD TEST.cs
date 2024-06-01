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
    public partial class BOARD_TEST : Form
    {
         
        String USER = LOGIN_LOGIC.sendtext;
        // Declaring object for agilent 34401A
        Agilent34401 v34401A = new Agilent34401();
        // Declaring a variable for the identification of test completed butten click
        private bool button1WasClicked = false;
        String SPEC;
        string no_light;
        double ajal;
        public BOARD_TEST()
        {
            InitializeComponent();
        }

        private void BOARD_TEST_Load(object sender, EventArgs e)
        {
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

        private void BOARD_START_Click(object sender, EventArgs e)
        {
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
                    //v34401A.DCCurrent.Configure(0.1, 10);
                    bool val = v34401A.DCCurrent.AutoRange;

                }
                catch (Exception ex)
                {
                    // executes if initializing and configuring fails
                    MessageBox.Show(ex.Message);
                    BOARD_START.Enabled = true;
                    return;
                }
                SPEC = "<5.10mA";
                SPEC_VALUE.Text = SPEC;
                START_LOGIC1.Enabled = false;
                BOARD_START.Enabled = false;
                TEST_COMPLETED1.Enabled = true;
                TEST_COMPLETED2.Enabled = false;
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
            MessageBox.Show("SWITCH ON POWER SWITCH ");
            MessageBox.Show("Set the LED switch to the “Off” position");
            MessageBox.Show("Set the Power switch in the “On” position.");
            MessageBox.Show("ADJUST POTENTIOMETER");
            while (button1WasClicked == false)
            {
                // declaring measuring function
                // Measure();
               
                Thread.Sleep(1000);
                // Measuring Value from 34401A
                retval = v34401A.Measurement.Read(1000);
                //Converting the obtained Value from A to mA range
                //value = retval * 1000
                retval = retval * 1000;
                retval = Math.Round(retval, 2);
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

                

            }
        }



        private void worker_Progresschanged(object sender, ProgressChangedEventArgs e)
        {

            if (e.ProgressPercentage == 1)
            {
                RESULT_VALUE1.Text = Convert.ToString(retval);
            }
            if (e.ProgressPercentage == 2)
            {
                RESULT_VALUE1.Text = Convert.ToString(retval);
                RESULT_VALUE1.BackColor = Color.Green;
            }
            if (e.ProgressPercentage == 3)
            {
                RESULT_VALUE1.Text = Convert.ToString(retval);
                RESULT_VALUE1.BackColor = Color.Red;
            }
        }

        private void TEST_COMPLETED1_Click(object sender, EventArgs e)
        {
            START_LOGIC1.Enabled = false;
            TEST_COMPLETED2.Enabled = false;
            BOARD_START.Enabled = false;
            button1WasClicked = true;
            String OUTPUT = RESULT_VALUE1.Text;
            string status = "";
            if (RESULT_VALUE1.BackColor == Color.Green)
            {
               // RESULT_VALUE1.Text = Convert.ToString(retval);
                // timer1.Enabled = false;
                //MessageBox.Show("Board PASS");
                // status = "PASS";
                TEST_COMPLETED2.Enabled = false;
                MessageBox.Show("Start Minimum Light OUPUT test");
                BOARD_START.Enabled = false;
                TEST_COMPLETED1.Enabled = false;
                START_LOGIC1.Enabled = true;
                no_light = RESULT_VALUE1.Text;


            }
            else
            {
                // timer1.Enabled = false;
                MessageBox.Show("Board FAIL");
                status = "FAIL";
                TEST_COMPLETED2.Enabled = false;
                BOARD_START.Enabled = true;
                TEST_COMPLETED1.Enabled = false;
                DateTime TO = DateTime.Now;
                String TODAY = Convert.ToString(TO);
                XmlDocument report = new XmlDocument();
                string reporttemplatefilepath = @"E:\Resources\FS-9009-60\BOARD TESTING\Test Report.xml";
                if (!File.Exists(reporttemplatefilepath))
                {
                    XmlNode docNode = report.CreateXmlDeclaration("1.0", "UTF-8", null);
                    XmlNode reportnode = report.CreateElement("report");
                    report.AppendChild(docNode);
                    report.AppendChild(reportnode);
                    report.Save(reporttemplatefilepath);
                }
                report.Load(reporttemplatefilepath);
                XmlElement rootdut1 = report.CreateElement("FS-9001-60_testreport");
                XmlElement name_1 = report.CreateElement("Username");
                XmlElement Serial_1 = report.CreateElement("Serial_No");
                XmlElement DATE_1 = report.CreateElement("DATE");
                XmlElement test1 = report.CreateElement("NO_LIGHT_OUTPUT");
                XmlElement test2 = report.CreateElement("MINIMUM_LIGHT_OUTPUT");
                //XmlElement value = report.CreateElement("Output_Current");
                XmlElement result = report.CreateElement("Test_status");
                String light = RESULT_VALUE1.Text;
                double OUT = Convert.ToDouble(light);
                name_1.InnerText = USER;
                Serial_1.InnerText = sl_no_txtbx.Text;
                DATE_1.InnerText = TODAY;

               // usl1.InnerText = USL_VALUE_txtbx.Text;
                //lsl1.InnerText = LSL_VALUE_txtbx.Text;
                //value.InnerText = OUTPUT;
                result.InnerText = status;
                test1.InnerText = light;
                test2.InnerText = "Not Tested";
                rootdut1.AppendChild(name_1);
                rootdut1.AppendChild(Serial_1);
                rootdut1.AppendChild(DATE_1);
                rootdut1.AppendChild(test1);
               // rootdut1.AppendChild(value);
                rootdut1.AppendChild(test2);
                rootdut1.AppendChild(result);
                report.DocumentElement.AppendChild(rootdut1);
                report.Save(reporttemplatefilepath);
                sl_no_txtbx.Text = "";
                RESULT_VALUE2.Text = "";
                RESULT_VALUE1.BackColor = Color.White;
                TEST_COMPLETED2.Enabled = false;
                BOARD_START.Enabled = true;
                button1WasClicked = false;
                START_LOGIC1.Enabled = true;

            }
            v34401A.Close();
        }
        private void START_LOGIC1_Click(object sender, EventArgs e)
        {
            //START_LOGIC1.Enabled = false;
            BOARD_START.Enabled = false;
            TEST_COMPLETED1.Enabled = false;
            TEST_COMPLETED2.Enabled = false;
            MessageBox.Show("Set the LED switch to the “On” position");
            try
            {
                // Initializing and Configuring 34401A
                v34401A.Initialize("ASRL1::INSTR", false, false, "");
                //v34401A.DCCurrent.Configure(0.1, 10);
                bool val = v34401A.DCCurrent.AutoRange;

            }
            catch (Exception ex)
            {
                // executes if initializing and configuring fails
                MessageBox.Show(ex.Message);
                BOARD_START.Enabled = true;
                return;
            }
            Thread.Sleep(1000);
            // Measuring Value from 34401A
            ajal = v34401A.Measurement.Read(1000);
            //Converting the obtained Value from A to mA range
            //value = retval * 1000
            ajal = ajal * 1000;
            ajal = Math.Round(ajal, 2);
            RESULT_VALUE2.Text = Convert.ToString(ajal);
            START_LOGIC1.Enabled = false;
            BOARD_START.Enabled = false;
            TEST_COMPLETED1.Enabled = false;
            TEST_COMPLETED2.Enabled = true;

        }
        private void TEST_COMPLETED2_Click(object sender, EventArgs e)
        {
            BOARD_START.Enabled = false;
            TEST_COMPLETED1.Enabled = false;
            DateTime TO = DateTime.Now;
            String TODAY = Convert.ToString(TO); 
            XmlDocument report = new XmlDocument();
            string reporttemplatefilepath = @"E:\Resources\FS-9009-60\BOARD TESTING\Test Report.xml";
            if (!File.Exists(reporttemplatefilepath))
            {
                XmlNode docNode = report.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlNode reportnode = report.CreateElement("report");
                report.AppendChild(docNode);
                report.AppendChild(reportnode);
                report.Save(reporttemplatefilepath);
            }
            report.Load(reporttemplatefilepath);
            XmlElement rootdut1 = report.CreateElement("FS-9001-60_testreport");
            XmlElement name_1 = report.CreateElement("Username");
            XmlElement Serial_1 = report.CreateElement("Serial_No");
            XmlElement DATE_1 = report.CreateElement("DATE");
            XmlElement test1 = report.CreateElement("NO_LIGHT_OUTPUT");
            XmlElement test2 = report.CreateElement("MINIMUM_LIGHT_OUTPUT");
           // XmlElement value = report.CreateElement("Output_Current");
            XmlElement result = report.CreateElement("Test_status");
            RESULT_VALUE2.Text = Convert.ToString(ajal);
            string status = "";
            string OUT = Convert.ToString(ajal);
            if (ajal < 5.10)
            {
               
                // timer1.Enabled = false;
                MessageBox.Show("Board FAIL");
                status = "FAIL";
                RESULT_VALUE2.BackColor = Color.Red;
                String OUTPUT = RESULT_VALUE2.Text;
               
            }
            else
            {
               // RESULT_VALUE2.Text = Convert.ToString(ajal);
                // timer1.Enabled = false;
                MessageBox.Show("Board PASS");
                status = "PASS";
                RESULT_VALUE2.BackColor = Color.Green;
                String OUTPUT = RESULT_VALUE2.Text;
                
            }
            name_1.InnerText = USER;
            Serial_1.InnerText = sl_no_txtbx.Text;
            DATE_1.InnerText = TODAY;
            test1.InnerText = no_light;
            test2.InnerText = OUT;
            //value.InnerText = OUTPUT;
            result.InnerText = status;
            rootdut1.AppendChild(name_1);
            rootdut1.AppendChild(Serial_1);
            rootdut1.AppendChild(DATE_1);
            rootdut1.AppendChild(test1);
           // rootdut1.AppendChild(value);
            rootdut1.AppendChild(test2);
            rootdut1.AppendChild(result);
            report.DocumentElement.AppendChild(rootdut1);
            report.Save(reporttemplatefilepath);
            sl_no_txtbx.Text = "";
            RESULT_VALUE2.Text = "";
            RESULT_VALUE1.Text = "";
            RESULT_VALUE1.BackColor = Color.White;
            RESULT_VALUE2.BackColor = Color.White;
            TEST_COMPLETED2.Enabled = false;
            BOARD_START.Enabled = true;
            button1WasClicked = false;
            v34401A.Close();
        }

        private void OUT_PUT_Enter(object sender, EventArgs e)
        {

        }

       
    }

    
    }
    

