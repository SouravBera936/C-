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

namespace LITHIUM_BATTERY
{
    public partial class P1_TEST_PART1 : Form
    {
        public P1_TEST_PART1()
        {
            InitializeComponent();
        }

        private void start_logic_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            Thread.Sleep(500);
            serialPort1.Write("OP2 0\n");
            serialPort1.Close(); ;
           P1_TEST_PART1B PART = new P1_TEST_PART1B();
            this.Hide();
           PART.ShowDialog();
        }

        private void heading_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Version_lbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}