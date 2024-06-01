using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAV_OPTICAL_FIBER_CHECK
{
    public partial class BOARD_SELECTION : Form
    {
        public BOARD_SELECTION()
        {
            InitializeComponent();
        }

        private void SELECTION_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.SELECTION.SelectedItem.ToString() == "CARTE-ARNIC")
            {
                ARINC_OPTICAL_CABLE_TEST main = new ARINC_OPTICAL_CABLE_TEST();
                this.Hide();
                main.ShowDialog();
            }
            else
            {
                ICM_Optical_Fiber_Check main = new ICM_Optical_Fiber_Check();
                this.Hide();
                main.ShowDialog();
            }
        }
    }
}