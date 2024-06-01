using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agilent.Agilent34401.Interop;
using System.Threading;
namespace WindowsFormsApplication4
{
    public partial class LOGIN_LOGIC : Form
    {
        Agilent34401 v34401A = new Agilent34401();
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
            v34401A.Initialize("ASRL1::INSTR", false, false, "");
            Thread.Sleep(500);
            bool val = v34401A.DCCurrent.AutoRange;
            Thread.Sleep(1000);
            v34401A.Close();
            if (USERNAME.Text==""||PASSWORD.Text=="")
            {
                MessageBox.Show("PLEASE ENTER THE USERANAME & PASSWORD");
            }
            else
            {
                if (USERNAME.Text=="ADMIN"&&PASSWORD.Text=="1234")
                {
                
                PART_NUMBER PART = new PART_NUMBER();
                    this.Hide();
                    PART.ShowDialog();
                }
             else if (USERNAME.Text == "BISHNU" && PASSWORD.Text == "123")
                {
                    PART_NUMBER PART = new PART_NUMBER();
                    this.Hide();
                    PART.ShowDialog();
                }
                else if (USERNAME.Text == "GAGAN" && PASSWORD.Text == "123")
                {
                    PART_NUMBER PART = new PART_NUMBER();
                    this.Hide();
                    PART.ShowDialog();
                }
                else if (USERNAME.Text == "PRERNA" && PASSWORD.Text == "123")
                {
                    PART_NUMBER PART = new PART_NUMBER();
                    this.Hide();
                    PART.ShowDialog();
                }
                else if (USERNAME.Text == "RAMYA" && PASSWORD.Text == "1234")
                {
                    PART_NUMBER PART = new PART_NUMBER();
                    this.Hide();
                    PART.ShowDialog();
                }
                else if (USERNAME.Text == "SWAPNA" && PASSWORD.Text == "123")
                {
                    PART_NUMBER PART = new PART_NUMBER();
                    this.Hide();
                    PART.ShowDialog();
                }
                else if (USERNAME.Text == "YUVARAJ" && PASSWORD.Text == "123")
                {
                    PART_NUMBER PART = new PART_NUMBER();
                    this.Hide();
                    PART.ShowDialog();
                }
                else if (USERNAME.Text == "AKSHAY" && PASSWORD.Text == "123")
                {
                    PART_NUMBER PART = new PART_NUMBER();
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
