using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertSinifi
{
    public partial class btnConvert : Form
    {
        public btnConvert()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string sayi = "123";
            byte s1 = Convert.ToByte(sayi);
            sbyte s2 = Convert.ToSByte(sayi);

            short s3 = Convert.ToInt16(sayi);
            ushort s6 = Convert.ToUInt16(sayi);

            int s4 = Convert.ToInt32(sayi);
            uint s9 = Convert.ToUInt32(sayi);

            double s5 = Convert.ToDouble(sayi);
            decimal s10 = Convert.ToDecimal(sayi);
            float s11 = Convert.ToSingle(sayi);

            long s7 = Convert.ToInt64(sayi);
            ulong s8 = Convert.ToUInt64(sayi);
            

        }
    }
}
