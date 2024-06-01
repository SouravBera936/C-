using System;
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
    public partial class PART_NUMBER : Form
    {
        public PART_NUMBER()
        {
            InitializeComponent();
        }

        private void PART_NUMBER_Load(object sender, EventArgs e)
        {
            string AJAL = "(select Partnumber)";
            SELECTION.Text = AJAL;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.SELECTION.SelectedItem == "FS-9001-29")
            {

                MAIN_FORM main = new MAIN_FORM();
                this.Hide();
                main.ShowDialog();
            }
            else
            {
                SETUP_CALIBRATION SETUP = new SETUP_CALIBRATION();
                this.Hide();
                SETUP.ShowDialog();
            }
        }
    }
}
