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

namespace TOSA_MMB_TEST_SOFTWARE
{
    public partial class MAIN_WINDOW : Form
    {
        AgilentE36xx e3649a1 = new AgilentE36xx();
        public MAIN_WINDOW()
        {
            InitializeComponent();
        }

        public static string send_serial = "";
        public static string send_operator_name = "";
        public static string send_folder_name = "";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

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
                string foldername = serial + "_" + DateTime.Now.ToString("ddMMyyyy_hhmmss");
                System.IO.Directory.CreateDirectory("D:\\Resources\\Report\\TOSA MMB FUNCTIONAL TEST\\REPORTS\\" + foldername);
                Thread.Sleep(100);
                send_folder_name = foldername;
                
                Microprocessor_Test1 main = new Microprocessor_Test1 ();
                this.Hide();
                main.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            e3649a1.Initialize("ASRL1", false, false, "");
            Thread.Sleep(500);
            e3649a1.Outputs.Channel = Agilent.AgilentE36xx.Interop.AgilentE36xxOutputEnum.AgilentE36xxOutput1;
            e3649a1.Outputs.Enabled = false;
            Thread.Sleep(500);
            e3649a1.Close();
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
