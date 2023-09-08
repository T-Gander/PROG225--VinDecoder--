using System.Runtime.CompilerServices;
using System.Web;

namespace VinDecoder
{
    public partial class Form1 : Form
    {
        internal static Form1 MainForm;

        public Form1()
        {
            InitializeComponent();
            MainForm = this;
        }

        private VINDecoder225 VINDecoder = new VINDecoder225();

        private void btnDecode_Click(object sender, EventArgs e)
        {
            string vin = txtVin.Text;
            VINDecoder.Decode(vin);
        }
    }
}