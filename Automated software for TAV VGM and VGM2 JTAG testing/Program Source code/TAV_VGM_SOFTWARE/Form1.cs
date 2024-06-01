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

namespace TAV_VGM_SOFTWARE
{
    public partial class Board_selection : Form
    {
        AgilentE36xx e3649a1 = new AgilentE36xx();
        public Board_selection()
        {
            InitializeComponent();
            STOP.Enabled = false;
        }

        private void PART_NUMBER_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SUMIT_Click(object sender, EventArgs e)
        {
            
            if (this.SELECTION1.SelectedItem.ToString() == ""  && this.PART_NUMBER.SelectedItem.ToString() == "" )

            {
                MessageBox.Show("Please select the Board Name and Partnumber & Proceed");
                return;
            }

           else if (this.SELECTION1.SelectedItem.ToString() == "VGM" && this.PART_NUMBER.SelectedItem.ToString() == "E30770DA01")

            {
                MessageBox.Show("You have selected VGM Board Testing");
               // MessageBox.Show("Have you verified the connecctions as per work instruction?");
                MessageBox.Show("Ensure to connect the 3.3V Power cable on OUTPUT1 & 5V Power cable on OUTPUT2 ");
                e3649a1.Initialize("ASRL1", false, false, "");
                e3649a1.System.EnableLocalControls();
                Thread.Sleep(1000);
                e3649a1.Outputs.get_Item("Output1").ApplyVoltageCurrent(3.3, 2.00);
                e3649a1.Outputs.get_Item("Output2").ApplyVoltageCurrent(5.0, 1.00);
                //Thread.Sleep(1000);
                e3649a1.Outputs.Enabled = true;
                e3649a1.Close();
                Thread.Sleep(100);
                 string str = @"D:\K4753AAA04_JTAG Software_4_5_2018\PORTAIL VGM.old\C_Portal.exe";
                 Process process = new Process();
                 process.StartInfo.FileName = str;
                 Thread.Sleep(500);
                 process.Start();
            }
            else if (this.SELECTION1.SelectedItem.ToString() == "VGM2" && this.PART_NUMBER.SelectedItem.ToString() == "E30770CB03")

            {
                MessageBox.Show("You have selected VGM2 Board Testing");
                // MessageBox.Show("Have you verified the connecctions as per work instruction?");
                MessageBox.Show("Ensure to connect the 3.3V Power cable on OUTPUT1 & 5V Power cable on OUTPUT2 ");
                e3649a1.Initialize("ASRL1", false, false, "");
                e3649a1.System.EnableLocalControls();
                Thread.Sleep(1000);
                e3649a1.Outputs.get_Item("Output1").ApplyVoltageCurrent(3.3, 2.00);
                e3649a1.Outputs.get_Item("Output2").ApplyVoltageCurrent(5.0, 1.00);
                //Thread.Sleep(1000);
                e3649a1.Outputs.Enabled = true;
                e3649a1.Close();
                Thread.Sleep(100);
                string str = @"D:\K4753AAA04_JTAG Software_4_5_2018\PORTAIL VGM\C_Portal.exe";
                Process process = new Process();
                process.StartInfo.FileName = str;
                Thread.Sleep(500);
                process.Start();
            }
            else if (this.SELECTION1.SelectedItem.ToString() == "VGM PGM ERRASE" && this.PART_NUMBER.SelectedItem.ToString() == "VGM PGM ERRASE")

            {
                MessageBox.Show("You have selected VGM Board Program Erasing ");
                // MessageBox.Show("Have you verified the connecctions as per work instruction?");
                MessageBox.Show("Ensure to connect the 3.3V Power cable on OUTPUT1 & 5V Power cable on OUTPUT2 ");
                e3649a1.Initialize("ASRL1", false, false, "");
                e3649a1.System.EnableLocalControls();
                Thread.Sleep(1000);
                e3649a1.Outputs.get_Item("Output1").ApplyVoltageCurrent(3.3, 2.00);
                e3649a1.Outputs.get_Item("Output2").ApplyVoltageCurrent(5.0, 1.00);
                //Thread.Sleep(1000);
                e3649a1.Outputs.Enabled = true;
                e3649a1.Close();
                Thread.Sleep(100);
                string str = @"D:\VGM\e30770da01_portal\C_Portal.exe";
                Process process = new Process();
                process.StartInfo.FileName = str;
                Thread.Sleep(500);
                process.Start();
            }
            else

            {
                MessageBox.Show("You have selected wrong details");
                return;
            }

            SUMIT.Enabled = false;
            STOP.Enabled = true;
            SELECTION1.Text = "";
            PART_NUMBER.Text = "";

        }

        private void STOP_Click(object sender, EventArgs e)
        {
            e3649a1.Initialize("ASRL1", false, false, "");
            Thread.Sleep(500);
            e3649a1.Outputs.Channel = Agilent.AgilentE36xx.Interop.AgilentE36xxOutputEnum.AgilentE36xxOutput1;
            e3649a1.Outputs.Enabled = false;
            e3649a1.Outputs.Channel = Agilent.AgilentE36xx.Interop.AgilentE36xxOutputEnum.AgilentE36xxOutput2;
            e3649a1.Outputs.Enabled = false;
            Thread.Sleep(500);
            e3649a1.Close();
            Process[] processes = Process.GetProcessesByName("C_Portal.exe");
            foreach (var process1 in processes)
             {
               process1.Kill();
            }
            Thread.Sleep(200);
            SUMIT.Enabled = true;
            return;
        }
    }
}
