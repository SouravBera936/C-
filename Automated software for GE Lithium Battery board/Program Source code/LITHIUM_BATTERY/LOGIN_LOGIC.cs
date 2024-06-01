using System;
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
                if (USERNAME.Text == "ADMIN" && PASSWORD.Text == "1234")
                {

                    SERIAL_LOGIC PART = new SERIAL_LOGIC();
                    this.Hide();
                    PART.ShowDialog();
                }
                else if (USERNAME.Text == "ANUSHA" && PASSWORD.Text == "123")
                {
                    SERIAL_LOGIC PART = new SERIAL_LOGIC();
                    this.Hide();
                    PART.ShowDialog();
                }
                else if (USERNAME.Text == "GAGAN" && PASSWORD.Text == "123")
                {
                    SERIAL_LOGIC PART = new SERIAL_LOGIC();
                    this.Hide();
                    PART.ShowDialog();
                }
                else if (USERNAME.Text == "PRERNA" && PASSWORD.Text == "123")
                {
                    SERIAL_LOGIC PART = new SERIAL_LOGIC();
                    this.Hide();
                    PART.ShowDialog();
                }
                else if (USERNAME.Text == "SANTu" && PASSWORD.Text == "123")
                {
                    SERIAL_LOGIC PART = new SERIAL_LOGIC();
                    this.Hide();
                    PART.ShowDialog();
                }
                else if (USERNAME.Text == "BISHNU" && PASSWORD.Text == "123")
                {
                    SERIAL_LOGIC PART = new SERIAL_LOGIC();
                    this.Hide();
                    PART.ShowDialog();
                }
                else if (USERNAME.Text == "YUVARAJ" && PASSWORD.Text == "123")
                {
                    SERIAL_LOGIC PART = new SERIAL_LOGIC();
                    this.Hide();
                    PART.ShowDialog();
                }
                else if (USERNAME.Text == "SHARANYA" && PASSWORD.Text == "123")
                {
                    SERIAL_LOGIC PART = new SERIAL_LOGIC();
                    this.Hide();
                    PART.ShowDialog();
                }
                else
                {
                    MessageBox.Show("LOGIN DETAILS NOT VALIED");
                }
                }
            }

        private void EXIT_LOGIC_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

       
    }
