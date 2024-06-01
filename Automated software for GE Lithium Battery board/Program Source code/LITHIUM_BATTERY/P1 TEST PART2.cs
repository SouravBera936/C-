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
using System.IO;
using Agilent.Agilent34401.Interop;
using Ivi.Dmm.Interop;
using Excel = Microsoft.Office.Interop.Excel;

namespace LITHIUM_BATTERY
{
    public partial class P1_TEST_PART2 : Form
    {
        public P1_TEST_PART2()
        {
            InitializeComponent();
        }

        private void start_logic_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            Thread.Sleep(500);
            serialPort1.Write("OP2 0\n");
            serialPort1.Close();
            P1_TEST_PART2B PART = new P1_TEST_PART2B();
            this.Hide();
            PART.ShowDialog();
        }

        private void start_logic_Click_1(object sender, EventArgs e)
        {
            serialPort1.Open();
            Thread.Sleep(500);
            serialPort1.Write("OP2 0\n");
            serialPort1.Close();
           P1_TEST_PART2B PART = new P1_TEST_PART2B();
            this.Hide();
           PART.ShowDialog();
        }
    }
}
