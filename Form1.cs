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
            decimal ExtPrice4 = nudQuantit4.Value * int.Parse(tbPriceEach4.Text);
            decimal Subtotal = ExtPrice1 + ExtPrice2 + ExtPrice3 + ExtPrice4;
            decimal SalesTax = Subtotal * decimal.Parse(tbTaxRate.Text);
            decimal Grandtotal = Subtotal + SalesTax + int.Parse(tbShipping.Text);

            tbExtPrice1.Text = "€ " + ExtPrice1.ToString() + ",00";
            tbExtPrice2.Text = "€ " + ExtPrice2.ToString() + ",00";
            tbExtPrice3.Text = "€ " + ExtPrice3.ToString() + ",00";
            tbExtPrice4.Text = "€ " + ExtPrice4.ToString() + ",00";


            tbSubtotal.Text = "€ " + Subtotal.ToString() + ",00";
            tbSalesTax.Text = "€ " + SalesTax.ToString() + ",00";
            tbGrandTotal.Text = "€ " + Grandtotal.ToString() + ",00";
        }
    }
}
