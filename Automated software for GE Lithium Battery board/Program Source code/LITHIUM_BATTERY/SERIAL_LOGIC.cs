using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LITHIUM_BATTERY
{
    public partial class SERIAL_LOGIC : Form
    {
        public SERIAL_LOGIC()
        {
            InitializeComponent();
        }
        public static string sendserial = "";
        private void start_logic_Click(object sender, EventArgs e)
        {
            if (sl_no_txtbx.Text == "")
            {
                MessageBox.Show("Please Enter Serial Number and Then Continue");
                return;
            }
            else
            {
                sendserial = sl_no_txtbx.Text;
                P1_TEST_PART1 PART = new P1_TEST_PART1();
                this.Hide();
                PART.ShowDialog();
            }
        }

        private void serial_number_Load(object sender, EventArgs e)
        {

        }
    }
}