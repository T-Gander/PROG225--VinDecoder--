using System.Runtime.CompilerServices;
using System.Web;

namespace VinDecoder
{
    public partial class Form1 : Form
    {
        internal static Form1 MainForm = new Form1();

        public Form1()
        {
            InitializeComponent();
            MainForm = this;
            txtVin.Text = VINDecoder225.GenerateVIN();
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            string vin = txtVin.Text;
            VINDecoder225.Decode(vin);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtVin.Text = VINDecoder225.GenerateVIN();
            btnDecode.PerformClick();
        }
    }
}