using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication4
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            XmlReader xmlfile = XmlReader.Create(@"E:\Resources\Config\config.xml");

            ds.ReadXml(xmlfile);

            lsl_txtbx.Text = Convert.ToString(ds.Tables[0].Rows[0][2]);
            usl_txtbx.Text = Convert.ToString(ds.Tables[0].Rows[0][1]);


            ds.ReadXml(xmlfile);
            //  ds.Dispose();
            xmlfile.Close();

        }
    }
}
