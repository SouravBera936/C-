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
    public partial class firmware1 : Form
    {
        public firmware1()
        {
            InitializeComponent();
        }

        private void start_logic_Click(object sender, EventArgs e)
        {
            firmware2 P = new firmware2();
            this.Hide();
            P.ShowDialog();
        }
    }
}
