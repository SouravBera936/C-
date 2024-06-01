using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agilent.AgilentE36xx.Interop;
using System.Diagnostics;
using System.Threading;

namespace TRIXELL_MAPIX_PGM_VERIFICATION
{
    public partial class BOARD_SELECCTION : Form
    {
        AgilentE36xx e3649a1 = new AgilentE36xx();
        public BOARD_SELECCTION()
        {
            InitializeComponent();
        }

        private void SELECTION_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.SELECTION.SelectedItem.ToString() == "MAPIX-63117944")
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
                string str = @"C:\altera\14.0\qprogrammer\bin64\quartus_pgmw.exe";
                Process process = new Process();
                process.StartInfo.FileName = str;
                //Thread.Sleep(500);
                process.Start();
                Thread.Sleep(1000);
                RUN_TEST_7944 main = new RUN_TEST_7944();
                this.Hide();
                main.ShowDialog();
            }
            else
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
                
               
                string str = @"C:\altera\14.0\qprogrammer\bin64\quartus_pgmw.exe";
                Process process = new Process();
                process.StartInfo.FileName = str;
                // Thread.Sleep(500);
                process.Start();
                Thread.Sleep(1000);
                RUN_TEST_8235 SETUP = new RUN_TEST_8235();
                this.Hide();
                SETUP.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BOARD_SELECCTION_Load(object sender, EventArgs e)
        {
            string AJAL = "(select Partnumber)";
            SELECTION.Text = AJAL;
        }
    }
}
