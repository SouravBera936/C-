﻿using System;
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
    public partial class FAIL : Form
    {
        public FAIL()
        {
            InitializeComponent();
        }

        private void FAIL_LOGIC_Click(object sender, EventArgs e)
        {
            SERIAL_LOGIC PART = new SERIAL_LOGIC();
            this.Hide();
            PART.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
