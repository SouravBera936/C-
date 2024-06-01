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
using System.Xml;

namespace TRIXELL_MIMO_AUTOMTION
{
    public partial class MIMO : Form
    {
        double retval;
        //void delay;
        Agilent34401 v34401A = new Agilent34401();
        string status = "";
        public MIMO()
        {
            InitializeComponent();
        }


        private void heading_lbl_Click(object sender, EventArgs e)
        {

        }

        private void SUBMIT_Click(object sender, EventArgs e)
        {
            
            if (SERIAL_NUMBER.Text == "" && OPERATOR_NAME.Text == "")
            {
                MessageBox.Show("Please Enter Operator name & Serial Number and Then Continue");
                return;
            }
            if (SERIAL_NUMBER.Text.Length == 7)
            {
                SUBMIT.Enabled = false;
                Thread.Sleep(100);
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 1000;

                for (int i = 0; i <= 1000; i++)
                {
                    Thread.Sleep(10);
                    progressBar1.Value = i;
                }

                v34401A.Initialize("ASRL1::INSTR", false, false, "");
                try
                {
                    v34401A.IviDmm.Configure(Ivi.Dmm.Interop.IviDmmFunctionEnum.IviDmmFunction2WireRes, 100, 3000);
                }
                catch (Exception ex)
                {
                   // MessageBox.Show("Check the Agilent Multimeter connection ");

                }
                bool val = v34401A.Resistance.AutoRange;

                Thread.Sleep(1000);
                retval = v34401A.Measurement.Read(3000);
                String RESULT = Convert.ToString(retval);
                string A = "_";
                DateTime TO = DateTime.Now;
                String TODAY = Convert.ToString(TO);
                XmlDocument report = new XmlDocument();
                string reporttemplatefilepath = @"D:\Resources\Report\TRIXELL MIMO BOARD COLD TEST\Test Report.xml";
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


                if (retval > 200 && retval < 100000)
                {
                    MessageBox.Show("TEST PASSED");
                    status = "PASS";
                    name_1.InnerText = OPERATOR_NAME.Text;
                    Serial_1.InnerText = SERIAL_NUMBER.Text;
                    DATE_1.InnerText = TODAY;
                    usl1.InnerText = "100000 OHM";
                    lsl1.InnerText = "200 OHM";
                    value.InnerText = RESULT;
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
                    string filename = SERIAL_NUMBER.Text + A + status + ".txt";
                    System.IO.StreamWriter swExtLogFile = new System.IO.StreamWriter(@"D:\Resources\Report\TRIXELL MIMO BOARD COLD TEST\" + filename, true);
                    DataTable dt = new DataTable();
                    //Adding data To DataTable
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Name");
                    dt.Columns.Add("OUPUT");
                    dt.Columns.Add("RESULT");
                    dt.Rows.Add(1, "USERNAME", OPERATOR_NAME.Text);
                    dt.Rows.Add(2, "SERIAL NUMBER", SERIAL_NUMBER.Text);
                    dt.Rows.Add(3, "OUTPUT(> 200 Ohm)", RESULT);
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
                    SERIAL_NUMBER.Text = "";
                    //OPERATOR_NAME.Text = "";
                    v34401A.Close();
                    progressBar1.Value = 0;
                    SUBMIT.Enabled = true;
                    return;
                }
                else
                {
                    MessageBox.Show("TEST FAILED");
                    status = "FAIL";
                    name_1.InnerText = OPERATOR_NAME.Text;
                    Serial_1.InnerText = SERIAL_NUMBER.Text;
                    DATE_1.InnerText = TODAY;
                    usl1.InnerText = "100000 OHM";
                    lsl1.InnerText = "200 OHM";
                    value.InnerText = RESULT;
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
                    string filename = SERIAL_NUMBER.Text + A + status + ".txt";
                    System.IO.StreamWriter swExtLogFile = new System.IO.StreamWriter(@"D:\Resources\Report\TRIXELL MIMO BOARD COLD TEST\" + filename, true);
                    DataTable dt = new DataTable();
                    //Adding data To DataTable
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Name");
                    dt.Columns.Add("OUPUT");
                    dt.Columns.Add("RESULT");
                    dt.Rows.Add(1, "USERNAME", OPERATOR_NAME.Text);
                    dt.Rows.Add(2, "SERIAL NUMBER", SERIAL_NUMBER.Text);
                    dt.Rows.Add(3, "OUTPUT(> 200 OHM)", RESULT);
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
                    SERIAL_NUMBER.Text = "";
                   // OPERATOR_NAME.Text = "";
                    progressBar1.Value = 0;
                    v34401A.Close();
                    SUBMIT.Enabled = true;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Enter correct Serial");
            }
        }

        private void MIMO_Load(object sender, EventArgs e)
        {
            try
            {
                // Initializing and Configuring 34401A
                v34401A.Initialize("ASRL1::INSTR", false, false, "");
                v34401A.DCVoltage.Configure(1000, 1000);
                v34401A.Close();

            }
            catch (Exception ex)
            {
                // executes if initializing and configuring fails
                MessageBox.Show("AGILENT 34401 MULTIMETER HAS NOT CONNECTED");
                return;
            }
        }
    }

}