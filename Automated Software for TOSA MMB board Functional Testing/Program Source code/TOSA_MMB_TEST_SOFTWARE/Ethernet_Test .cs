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
    public partial class Ethernet_Test : Form
    {
        AgilentE36xx e3649a1 = new AgilentE36xx();
        string SERIAL1 = MAIN_WINDOW.send_serial;
        string folder_name = MAIN_WINDOW.send_folder_name;
        string USER = MAIN_WINDOW.send_operator_name;
        string TP4 = PLL_frequency_Test.send_TP4;
        string TP5 = PLL_frequency_Test.send_TP5;
        string TP6 = PLL_frequency_Test.send_TP6;
        string R138 = PLL_frequency_Test.send_R138;
        string CH1 = Video_Test.send_CH1;
        string CH2 = Video_Test.send_CH2;
        string CH3 = Video_Test.send_CH3;

        public Ethernet_Test()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

            string str = @"C:\Program Files (x86)\teraterm\ttermpro.exe";
            Process process = new Process();
            process.StartInfo.FileName = str;
            //Thread.Sleep(500);
            process.Start();
            Thread.Sleep(500);

            Ethernet_Test_Screenshot main = new Ethernet_Test_Screenshot();
            this.Hide();
            main.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MAIN_WINDOW main = new MAIN_WINDOW();
            this.Hide();
            main.ShowDialog();

        }
    }
}
