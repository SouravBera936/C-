using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Access = Microsoft.Office.Interop.Access;

namespace _1922_board_test_software
{
    public partial class LOGIN_LOGIC : Form
    {
        
        public LOGIN_LOGIC()
        {
            InitializeComponent();
        }
        public static string sendtext = "";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void heading_lbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendtext = USERNAME.Text;
            serial_logic P = new serial_logic();
            this.Hide();
            P.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
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

                    serial_logic P = new serial_logic();
                    this.Hide();
                    P.ShowDialog();
                }
                else if (USERNAME.Text == "BISHNU" && PASSWORD.Text == "123")
                {
                    serial_logic P = new serial_logic();
                    this.Hide();
                    P.ShowDialog();
                }
                else if (USERNAME.Text == "GAGAN" && PASSWORD.Text == "123")
                {
                    serial_logic P = new serial_logic();
                    this.Hide();
                    P.ShowDialog();
                }
                else if (USERNAME.Text == "PRERNA" && PASSWORD.Text == "123")
                {
                    serial_logic P = new serial_logic();
                    this.Hide();
                    P.ShowDialog();
                }
                else if (USERNAME.Text == "RAMYA" && PASSWORD.Text == "1234")
                {
                    serial_logic P = new serial_logic();
                    this.Hide();
                    P.ShowDialog();
                }
                else if (USERNAME.Text == "SWAPNA" && PASSWORD.Text == "123")
                {
                    serial_logic P = new serial_logic();
                    this.Hide();
                    P.ShowDialog();
                }
                else if (USERNAME.Text == "YUVARAJ" && PASSWORD.Text == "123")
                {
                    serial_logic P = new serial_logic();
                    this.Hide();
                    P.ShowDialog();
                }
                else if (USERNAME.Text == "AKSHAY" && PASSWORD.Text == "123")
                {
                    serial_logic P = new serial_logic();
                    this.Hide();
                    P.ShowDialog();
                }
                else
                {
                    MessageBox.Show("LOGIN DETAILS NOT VALIED");
                }
            }
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void EXIT_LOGIC_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
