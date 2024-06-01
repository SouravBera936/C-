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
using System.Threading;
using System.Diagnostics;
using Agilent.AgilentE36xx.Interop;



namespace TOSA_MMB_TEST_SOFTWARE
{
    public partial class Microprocessor_Test2 : Form
    {
        AgilentE36xx e3649a1 = new AgilentE36xx();
        string SERIAL1 = MAIN_WINDOW.send_serial;
        string folder_name = MAIN_WINDOW.send_folder_name;
        string USER = MAIN_WINDOW.send_operator_name;

        public Microprocessor_Test2()
        {
            InitializeComponent();
        }

        private void start_logic_Click(object sender, EventArgs e)
        {

            e3649a1.Initialize("ASRL1", false, false, "");
            e3649a1.System.EnableLocalControls();
            Thread.Sleep(1000);
            e3649a1.Outputs.get_Item("Output2").VoltageLevel = 12D;
            e3649a1.Outputs.get_Item("Output2").CurrentLimit = 1D;
            //Thread.Sleep(1000);
            e3649a1.Outputs.Enabled = true;
            e3649a1.Close();

            string str = @"cmd.exe";
            Process process = new Process();
            process.StartInfo.FileName = str;
            Thread.Sleep(100);
            process.Start();

            Microprocessor_Test2_Screenshot main = new Microprocessor_Test2_Screenshot();
            this.Hide();
            main.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Process[] processes = Process.GetProcessesByName("ttermpro.exe");
            foreach (var process1 in processes)
            {
                process1.Kill();
            }
            Thread.Sleep(100);
            MAIN_WINDOW main = new MAIN_WINDOW();
            this.Hide();
            main.ShowDialog();

        }
    }
}
