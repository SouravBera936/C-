using System;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class LOGIN_LOGIC : Form
    {
        public LOGIN_LOGIC()
        {
            InitializeComponent();



        }

        private void LOGIN_LOGIC_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public static string sendtext = "";
        private void button1_Click(object sender, EventArgs e)
        {
            sendtext = USERNAME.Text;
            if (USERNAME.Text == "" || PASSWORD.Text == "")
            {
                MessageBox.Show("PLEASE ENTER THE USERANAME & PASSWORD");
            }
            else
            {
                if (USERNAME.Text == "SOURAV" && PASSWORD.Text == "123")
                {

                    SERIAL MAIN = new SERIAL();
                    this.Hide();
                    MAIN.ShowDialog();
                }
                else if (USERNAME.Text == "PRITAM" && PASSWORD.Text == "123")
                {
                    SERIAL MAIN = new SERIAL();
                    this.Hide();
                    MAIN.ShowDialog();
                }
                else if (USERNAME.Text == "VINAY" && PASSWORD.Text == "123")
                {
                    SERIAL MAIN = new SERIAL();
                    this.Hide();
                    MAIN.ShowDialog();
                }
                else if (USERNAME.Text == "LALAN" && PASSWORD.Text == "9596")
                {
                    SERIAL MAIN = new SERIAL();
                    this.Hide();
                    MAIN.ShowDialog();
                }
                else if (USERNAME.Text == "SUMAN" && PASSWORD.Text == "123")
                {
                    SERIAL MAIN = new SERIAL();
                    this.Hide();
                    MAIN.ShowDialog();
                }
                else if (USERNAME.Text == "RAVI" && PASSWORD.Text == "123")
                {
                    SERIAL MAIN = new SERIAL();
                    this.Hide();
                    MAIN.ShowDialog();
                }
                else
                {
                    SERIAL MAIN = new SERIAL();
                    this.Hide();
                    MAIN.ShowDialog();
                }
            }

            private void EXIT_LOGIC_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

        private void PASSWORD_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
