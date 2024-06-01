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
    public partial class Microprocessor_Test1 : Form
    {
        AgilentE36xx e3649a1 = new AgilentE36xx();
        string SERIAL1 = MAIN_WINDOW.send_serial;
        string folder_name = MAIN_WINDOW.send_folder_name;
        string USER = MAIN_WINDOW.send_operator_name;

        public Microprocessor_Test1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            e3649a1.Initialize("ASRL1", false, false, "");
            Thread.Sleep(500);
            e3649a1.Outputs.Channel = Agilent.AgilentE36xx.Interop.AgilentE36xxOutputEnum.AgilentE36xxOutput1;
            e3649a1.Outputs.Enabled = false;
            Thread.Sleep(500);
            e3649a1.Close();
            MAIN_WINDOW main = new MAIN_WINDOW();
            this.Hide();
            main.ShowDialog();
        }

        private void start_logic_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Please connect UART cable to RS232 MAINT connector of test fixture");
            MessageBox.Show(" Ensure the P3 JUMPER switch in Short Position");
            MessageBox.Show(" connect the Power supply cable to OUTPUT2 of Agilent E36XX Power Supply");
            e3649a1.Initialize("ASRL1", false, false, "");
            e3649a1.System.EnableLocalControls();
            Thread.Sleep(1000);
            e3649a1.Outputs.get_Item("Output2").VoltageLevel = 12D;
            e3649a1.Outputs.get_Item("Output2").CurrentLimit = 1D;

            //Thread.Sleep(1000);
            e3649a1.Outputs.Enabled = true;
            e3649a1.Close();

            string str = @"C:\Program Files (x86)\teraterm\ttermpro.exe";
            Process process = new Process();
            process.StartInfo.FileName = str;
            //Thread.Sleep(500);
            process.Start();
            Thread.Sleep(500);

            Microprocessor_test_screenshot main = new Microprocessor_test_screenshot();
            this.Hide();
            main.ShowDialog();
        }
    }
}
