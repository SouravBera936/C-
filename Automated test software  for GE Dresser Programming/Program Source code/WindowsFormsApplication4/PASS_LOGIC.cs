using System;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml;


namespace WindowsFormsApplication4
{
    public partial class PASS_LOGIC : Form
    {
        String USER = LOGIN_LOGIC.sendtext;
        string SERIAL1 = SERIAL.sendserial;
        AgilentE36xx e3649a1 = new AgilentE36xx();
        public PASS_LOGIC()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PASSLOGIC_Click(object sender, EventArgs e)
        {
            string A = "_";
            DateTime TO = DateTime.Now;
            String TODAY = Convert.ToString(TO);
            string STATUS = "PASS";
            XmlDocument report = new XmlDocument();
            string reporttemplatefilepath = @"E:\programming reports\Test Report.xml";
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
            // XmlElement usl1 = report.CreateElement("USL");
            //XmlElement lsl1 = report.CreateElement("LSL");
            // XmlElement value = report.CreateElement("Output_Current");
            XmlElement result = report.CreateElement("Test_status");
            name_1.InnerText = USER;
            Serial_1.InnerText = SERIAL1;
            DATE_1.InnerText = TODAY;
            result.InnerText = STATUS;
            rootdut1.AppendChild(name_1);
            rootdut1.AppendChild(Serial_1);
            rootdut1.AppendChild(DATE_1);
            rootdut1.AppendChild(result);
            report.DocumentElement.AppendChild(rootdut1);
            report.Save(reporttemplatefilepath);
            string filename = SERIAL1 + A + STATUS + ".txt";
            System.IO.StreamWriter swExtLogFile = new System.IO.StreamWriter(@"E:\programming reports\reports\" + filename, true);
            DataTable dt = new DataTable();
            //Adding data To DataTable
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("OUPUT");
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
            e3649a1.Initialize("ASRL1", false, false, "");
            Thread.Sleep(500);
            e3649a1.Outputs.Channel = Agilent.AgilentE36xx.Interop.AgilentE36xxOutputEnum.AgilentE36xxOutput1;
            // e3649a1.Outputs.Enabled = true;
            e3649a1.Outputs.Enabled = false;
            Thread.Sleep(500);
            e3649a1.Close();
            SERIAL MAIN = new SERIAL();
            this.Hide();
            MAIN.ShowDialog();
        }

        private void FAILLOGIC_Click(object sender, EventArgs e)
        {
            string A = "_";
            DateTime TO = DateTime.Now;
            String TODAY = Convert.ToString(TO);
            string STATUS = "FAIL";
            XmlDocument report = new XmlDocument();
            string reporttemplatefilepath = @"E:\programming reports\Test Report.xml";
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
            // XmlElement usl1 = report.CreateElement("USL");
            //XmlElement lsl1 = report.CreateElement("LSL");
            // XmlElement value = report.CreateElement("Output_Current");
            XmlElement result = report.CreateElement("Test_status");
            name_1.InnerText = USER;
            Serial_1.InnerText = SERIAL1;
            DATE_1.InnerText = TODAY;
            result.InnerText = STATUS;
            rootdut1.AppendChild(name_1);
            rootdut1.AppendChild(Serial_1);
            rootdut1.AppendChild(DATE_1);
            rootdut1.AppendChild(result);
            report.DocumentElement.AppendChild(rootdut1);
            report.Save(reporttemplatefilepath);
            string filename = SERIAL1 + A + STATUS + ".txt";
            System.IO.StreamWriter swExtLogFile = new System.IO.StreamWriter(@"E:\programming reports\reports\" + filename, true);
            DataTable dt = new DataTable();
            //Adding data To DataTable
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("OUPUT");
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
            e3649a1.Initialize("ASRL1", false, false, "");
            Thread.Sleep(500);
            e3649a1.Outputs.Channel = Agilent.AgilentE36xx.Interop.AgilentE36xxOutputEnum.AgilentE36xxOutput1;
            // e3649a1.Outputs.Enabled = true;
            e3649a1.Outputs.Enabled = false;
            Thread.Sleep(500);
            e3649a1.Close();
            SERIAL MAIN = new SERIAL();
            this.Hide();
            MAIN.ShowDialog();
        }
    }
}
