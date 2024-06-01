using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1922_board_test_software
{
    public partial class serial_logic : Form
    {
        public serial_logic()
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
                sendserial =  sl_no_txtbx.Text;
                settings1 P = new settings1();
                this.Hide();
                P.ShowDialog();
            }
        }
    }
}
