using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesTaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            decimal ExtPrice1 = nudQuantity1.Value * int.Parse(tbPriceEach1.Text);
            decimal ExtPrice2 = nudQuantity2.Value * int.Parse(tbPriceEach2.Text);
            decimal ExtPrice3 = nudQuantity3.Value * int.Parse(tbPriceEach3.Text);
            decimal ExtPrice4 = nudQuantit4.Value *int.Parse(tbPriceEach4.Text);

          

        }
    }
}
