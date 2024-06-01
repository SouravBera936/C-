using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace TAV_OPTICAL_FIBER_CHECK
{
    public partial class ARINC_OPTICAL_CABLE_TEST : Form
    {
        string foldername;
        public ARINC_OPTICAL_CABLE_TEST()
        {
            InitializeComponent();
        }

        public static string send_serial = "";
        public static string send_operator_name = "";
        public static string send_folder_name = "";

        private void START1_Click(object sender, EventArgs e)
        {
            ARINC_BOARD_OPTICAL_TEST_VERIFICATION main = new ARINC_BOARD_OPTICAL_TEST_VERIFICATION();
            this.Hide();
            main.ShowDialog();
        }


        private void START2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ARINC_OPTICAL_CABLE_TEST_Load(object sender, EventArgs e)
        { }
            

        private void button1_Click(object sender, EventArgs e)
        {
            if (SERIAL_NUMBER.Text == "" && OPERATOR_NAME.Text == "")
            {
                MessageBox.Show("Please Enter Operator name & Serial Number and Then Continue");
                return;
            }
            else
            {
                send_operator_name = OPERATOR_NAME.Text;
                send_serial = SERIAL_NUMBER.Text;
                send_operator_name = OPERATOR_NAME.Text;
                string serial;
                serial = SERIAL_NUMBER.Text;
                foldername = serial + "_" + DateTime.Now.ToString("ddMMyyyy_hhmmss");
                System.IO.Directory.CreateDirectory("D:\\Resources\\Report\\arinc optical cable test\\" + foldername);
                Thread.Sleep(100);
                send_folder_name = foldername;
                string str = @"C:\Program Files (x86)\Viavi\FiberChekPRO\FiberChekPro.exe";
                Process process = new Process();
                process.StartInfo.FileName = str;
                Thread.Sleep(500);
                process.Start();
                Thread.Sleep(500);
                ARINC_BOARD_OPTICAL_TEST_VERIFICATION main = new ARINC_BOARD_OPTICAL_TEST_VERIFICATION();
                this.Hide();
                main.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void SERIAL_NUMBER_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
