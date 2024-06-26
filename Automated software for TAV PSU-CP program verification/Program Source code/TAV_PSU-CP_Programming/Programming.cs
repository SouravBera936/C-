﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using Agilent.AgilentE36xx.Interop;
using System.Threading;
using System.Xml;
using System.Diagnostics;

namespace TAV_PSU_CP_Programming
{
    public partial class Programming : Form
    {
        AgilentE36xx e3649a1 = new AgilentE36xx();
        // private static readonly string send_serial;
        string SERIAL1 = Form1.send_serial;
        string folder_name = Form1.send_folder_name;
        string USER = Form1.send_operator_name;

        public Programming()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap captureBitmap = new Bitmap(1366, 768, PixelFormat.Format32bppArgb);
            Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
            Graphics captureGraphics = Graphics.FromImage(captureBitmap);
            captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
            captureBitmap.Save(@"D:\A400M_PSU_CP\Logs\" + folder_name + "\\" + SERIAL1 + ".jpg", ImageFormat.Jpeg);
            // captureBitmap.Save(@"D:\Capture.jpg", ImageFormat.Jpeg);
            e3649a1.Initialize("ASRL1", false, false, "");
            Thread.Sleep(500);
            e3649a1.Outputs.Channel = Agilent.AgilentE36xx.Interop.AgilentE36xxOutputEnum.AgilentE36xxOutput1;
            e3649a1.Outputs.Enabled = false;
            Thread.Sleep(500);
            e3649a1.Close();
            //REPORT GENERATION
            string A = "_";
            DateTime TO = DateTime.Now;
            String TODAY = Convert.ToString(TO);
            string STATUS = "PASS";
            XmlDocument report = new XmlDocument();
            string reporttemplatefilepath = @"D:\A400M_PSU_CP\Logs\Test Report.xml";
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
            System.IO.StreamWriter swExtLogFile = new System.IO.StreamWriter(@"D:\A400M_PSU_CP\Logs\" + folder_name + "\\" + filename, true);
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
            Thread.Sleep(500);
            //close the programming software
            Process[] processes = Process.GetProcessesByName("programmer");
            foreach (var process1 in processes)
            {
                process1.Kill();
            }
            Thread.Sleep(200);
            Form1 main = new Form1();
            this.Hide();
            main.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SCREEN SHOT CAPTURING
            Bitmap captureBitmap = new Bitmap(1366, 768, PixelFormat.Format32bppArgb);
            Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
            Graphics captureGraphics = Graphics.FromImage(captureBitmap);
            captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
            captureBitmap.Save(@"D:\A400M_PSU_CP\Logs\" + folder_name + "\\" + SERIAL1 + ".jpg", ImageFormat.Jpeg);
            //POWER SUPPLY OFF
            e3649a1.Initialize("ASRL1", false, false, "");
            Thread.Sleep(500);
            e3649a1.Outputs.Channel = Agilent.AgilentE36xx.Interop.AgilentE36xxOutputEnum.AgilentE36xxOutput1;
            e3649a1.Outputs.Enabled = false;
            Thread.Sleep(500);
            e3649a1.Close();
            //REPORT GENERATION
            string A = "_";
            DateTime TO = DateTime.Now;
            String TODAY = Convert.ToString(TO);
            string STATUS = "FAIL";
            XmlDocument report = new XmlDocument();
            string reporttemplatefilepath = @"D:\A400M_PSU_CP\Logs\Test Report.xml";
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
            System.IO.StreamWriter swExtLogFile = new System.IO.StreamWriter(@"D:\A400M_PSU_CP\\Logs\" + folder_name + "\\" + filename, true);
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
            Thread.Sleep(500);
            Process[] processes = Process.GetProcessesByName("programmer");
            foreach (var process1 in processes)
            {
                process1.Kill();
            }
            Thread.Sleep(200);
            Form1 main = new Form1();
            this.Hide();
            main.ShowDialog();
        }
    }
}
