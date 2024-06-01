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
    public partial class settings2 : Form
    {
        public settings2()
        {
            InitializeComponent();
        }

        private void start_logic_Click(object sender, EventArgs e)
        {
            string str = @"C:\Users\Administrator\Desktop\1922\Centum Package\Programs\TridentBoot\TridentBoot.exe";
            Process process = new Process();
            process.StartInfo.FileName = str;
            Thread.Sleep(500);
            process.Start();
            Thread.Sleep(500);
            memory_test1 P = new memory_test1();
            this.Hide();
            P.ShowDialog();
        }
    }
}
