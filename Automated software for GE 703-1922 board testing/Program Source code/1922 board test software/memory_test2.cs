using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
namespace _1922_board_test_software
{
    public partial class memory_test2 : Form
    {
        public memory_test2()
        {
            InitializeComponent();
        }

        private void start_logic_Click(object sender, EventArgs e)
        {
           
            memory_test3 P = new memory_test3();
            this.Hide();
            P.ShowDialog();
        }
    }
}
