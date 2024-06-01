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
using Agilent.AgilentE36xx.Interop;
using System.Diagnostics;

namespace TAV_PSU_CP_Programming
{
    public partial class Form1 : Form
    {
        AgilentE36xx e3649a1 = new AgilentE36xx();
        public Form1()
        {
            InitializeComponent();
        }

        public static string send_serial = "";
        public static string send_operator_name = "";
        public static string send_folder_name = "";
        private void OPERATOR_NAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void SUBMIT_Click(object sender, EventArgs e)
        {
            if (SERIAL_NUMBER.Text == "" && OPERATOR_NAME.Text == "")
            {
                MessageBox.Show("Please Enter Operator name & Serial Number and Then Continue");
                return;
            }
            else
            {
                e3649a1.Initialize("ASRL1", false, false, "");
                e3649a1.System.EnableLocalControls();
                Thread.Sleep(1000);
                e3649a1.Outputs.get_Item("Output1").ApplyVoltageCurrent(3.3, 0.05);
                //Thread.Sleep(1000);
                e3649a1.Outputs.Enabled = true;
                e3649a1.Close();
                send_operator_name = OPERATOR_NAME.Text;
                send_serial = SERIAL_NUMBER.Text;
                send_operator_name = OPERATOR_NAME.Text;
                string serial;
                serial = SERIAL_NUMBER.Text;
                string foldername = serial + "_" + DateTime.Now.ToString("ddMMyyyy_hhmmss");
                System.IO.Directory.CreateDirectory("D:\\A400M_PSU_CP\\Logs\\" + foldername);
                Thread.Sleep(100);
                send_folder_name = foldername;
                string str = @"C:\lscc\Programmer\3.4\bin\nt\programmer.exe";
                Process process = new Process();
                process.StartInfo.FileName = str;
                Thread.Sleep(500);
                process.Start();
                Thread.Sleep(500);
                Programming main = new Programming();
                this.Hide();
                main.ShowDialog();
            }
        }

        private void EXIT_LOGIC_Click(object sender, EventArgs e)
        {
            e3649a1.Initialize("ASRL1", false, false, "");
            Thread.Sleep(500);
            e3649a1.Outputs.Channel = Agilent.AgilentE36xx.Interop.AgilentE36xxOutputEnum.AgilentE36xxOutput1;
            e3649a1.Outputs.Enabled = false;
            Thread.Sleep(500);
            e3649a1.Close();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Initializing and Configuring 34401A
                e3649a1.Initialize("ASRL1", false, false, "");
                e3649a1.Close();

            }
            catch (Exception ex)
            {
                // executes if initializing and configuring fails
                MessageBox.Show("AGILENT POWER SUPPLY E3649A1 IS NOT CONNECTED");
                return;
            }
        }
    }
}