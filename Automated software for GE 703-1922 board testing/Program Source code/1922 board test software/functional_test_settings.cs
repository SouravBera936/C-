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
using System.Diagnostics;

namespace _1922_board_test_software
{
    public partial class functional_test_settings : Form
    {
        public functional_test_settings()
        {
            InitializeComponent();
        }

        private void start_logic_Click(object sender, EventArgs e)
        {
            string str = @"C:\Program Files (x86)\Aurora Main Board\Aurora Main Board Test.exe";
            Process process = new Process();
            process.StartInfo.FileName = str;
            Thread.Sleep(500);
            process.Start();
            Thread.Sleep(500);
            functional_test P = new functional_test();
            this.Hide();
            P.ShowDialog();
        }
    }
}
