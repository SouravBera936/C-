using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class PROGRAMMING : Form
    {
        String USER = LOGIN_LOGIC.sendtext;
        string SERIAL1 = SERIAL.sendserial;
        AgilentE36xx e3649a1 = new AgilentE36xx();
        public PROGRAMMING()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void start_logic_Click(object sender, EventArgs e)
        {
            e3649a1.Initialize("ASRL1", false, false, "");
            e3649a1.System.EnableLocalControls();
            Thread.Sleep(1000);
            e3649a1.Outputs.get_Item("Output1").ApplyVoltageCurrent(24, 0.500);
            //Thread.Sleep(1000);
            e3649a1.Outputs.Enabled = true;
            // Thread.Sleep(1000);
            // e3649a1.Outputs.get_Item("Output1").ApplyVoltageCurrent(24, 0.005);
            //e3649a1.Outputs.get_Item("Output1").CurrentLimit = 0.005;
            //e3649a1.Outputs.get_Item("Output1").ConfigureRange(Agilent.AgilentE36xx.Interop.AgilentE36xxRangeTypeEnum.AgilentE36xxRangeVoltage, 24);
            //Thread.Sleep(1000);
            //e3649a1.Outputs.Channel = Agilent.AgilentE36xx.Interop.AgilentE36xxOutputEnum.AgilentE36xxOutput1;
            //Thread.Sleep(2000);
            //e3649a1.Outputs.Enabled = true;
            //Thread.Sleep(3000);
            ////e3649a1.Outputs.Enabled = true;
            ////Thread.Sleep(100);
            e3649a1.Close();
            PASS_LOGIC MAIN = new PASS_LOGIC();
            this.Hide();
            MAIN.ShowDialog();
        }

        private void PROGRAMMING_Load(object sender, EventArgs e)
        {

        }
    }
}
