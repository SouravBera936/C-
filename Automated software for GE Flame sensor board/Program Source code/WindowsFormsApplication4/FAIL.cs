﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class FAIL : Form
    {
        public FAIL()
        {
            InitializeComponent();
        }

        private void FAIL_LOGIC_Click(object sender, EventArgs e)
        {
            MAIN_FORM main = new MAIN_FORM();
            this.Hide();
            main.ShowDialog();
        }
    }
}
