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
    public partial class fail : Form
    {
        public fail()
        {
            InitializeComponent();
        }

        private void FAIL_LOGIC_Click(object sender, EventArgs e)
        {
            serial_logic P = new serial_logic();
            this.Hide();
            P.ShowDialog();
        }
    }
}
