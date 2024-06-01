using System;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class SERIAL : Form
    {
        String USER = LOGIN_LOGIC.sendtext;
        public SERIAL()
        {
            InitializeComponent();
        }
        string LOGIC1;
        public static string sendserial = "";
        private void PASS_LOGIC_CheckedChanged(object sender, EventArgs e)
        {
            // PASS_LOGIC.Checked = true;
            // PASS_LOGIC.UseVisualStyleBackColor = Color.Green;

        }

        private void FAIL_LOGIC_CheckedChanged(object sender, EventArgs e)
        {
            // FAIL_LOGIC.Checked = true;
            // FAIL_LOGIC.BackColor = Color.Red;
        }

        private void SUBMIT_LOGIC_Click(object sender, EventArgs e)
        {
            if (SERIAL_NUMBER.Text == "")
            {
                MessageBox.Show("Please Enter Serial Number & Continue");
                return;
            }

            else
            {
                sendserial = SERIAL_NUMBER.Text;
                PROGRAMMING MAIN = new PROGRAMMING();
                this.Hide();
                MAIN.ShowDialog();
            }
        }
    }
}

