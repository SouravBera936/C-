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

namespace LITHIUM_BATTERY
{
    public partial class P6_TEST : Form
    {
        public P6_TEST()
        {
            InitializeComponent();
        }

        private void start_logic_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            Thread.Sleep(500);
            serialPort1.Write("OP2 0\n");
            serialPort1.Close();
            P6_TEST_PART1 PART = new P6_TEST_PART1();
            this.Hide();
            PART.ShowDialog();
        }
    }
}
