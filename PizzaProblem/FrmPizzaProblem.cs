using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProblem
{
    public partial class FrmPizzaProblem : Form
    {
        public FrmPizzaProblem()
        {
            InitializeComponent();
        }

        double small, medium, large, extraLarge, basicPizza, veggie, meat, stuffedCrust, deluxe, extra, priceextras, type;

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            RdpBasic.Checked = false;
            RdpDeluxe.Checked = false;
            RdpLarge.Checked = false;
            RdpMeat.Checked = false;
            RdpMedium.Checked = false;
            RdpSmalll.Checked = false;
            RdpStuffedCrust.Checked = false;
            RdpVeggie.Checked = false;
            RdpXLarge.Checked = false;

            txtBasePrice.Text = "";
            TxtPrice.Text = "";
            TxtSubtotal.Text = "";
            TxtSurcharge.Text = "";
            TxtTax.Text = "";
            TxtTotal.Text = "";
            TxtQuantity.Text = "0";

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {

            TxtSubtotal.Text = (double.Parse(TxtQuantity.Text) * (type + extra)).ToString("c");
            TxtTax.Text = ((double.Parse(TxtQuantity.Text) * (type + extra)) * 0.20).ToString("c");
            TxtTotal.Text = (((double.Parse(TxtQuantity.Text) * (type + extra)) * 0.20) + ((double.Parse(TxtQuantity.Text) * (type + extra)))).ToString("c");
        }



        private void RdpStuffedCrust_CheckedChanged(object sender, EventArgs e)
        {
            extra = stuffedCrust;
            TxtSurcharge.Text = extra.ToString("c");
            TxtPrice.Text = (type + extra).ToString("c");
        }



        private void RdpMeat_CheckedChanged(object sender, EventArgs e)
        {
            extra = meat;
            TxtSurcharge.Text = extra.ToString("c");
            TxtPrice.Text = (type + extra).ToString("c");
        }



        private void RdpVeggie_CheckedChanged(object sender, EventArgs e)
        {
            extra = veggie;
            TxtSurcharge.Text = extra.ToString("c");
            TxtPrice.Text = (type + extra).ToString("c");
        }



        private void RdpXLarge_CheckedChanged(object sender, EventArgs e)
        {
            type = extraLarge;
            txtBasePrice.Text = type.ToString("c");
            TxtPrice.Text = (type + extra).ToString("c");
        }

        

        private void RdpMedium_CheckedChanged(object sender, EventArgs e)
        {
            type = medium;
            txtBasePrice.Text = type.ToString("c");
            TxtPrice.Text = (type + extra).ToString("c");
        }

        

        private void RdpBasic_CheckedChanged(object sender, EventArgs e)
        {
            extra = basicPizza;
            TxtSurcharge.Text = basicPizza.ToString("c");
            TxtPrice.Text = (type + extra).ToString("c");
        }
    

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RdpSmalll_CheckedChanged(object sender, EventArgs e)
        {
            txtBasePrice.Text = small.ToString("c");
            type = small;

            priceextras = type + extra;
            TxtPrice.Text = priceextras.ToString("c");
        }



        private void LblSurcharge_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            type = large;
            txtBasePrice.Text = type.ToString("c");
            TxtPrice.Text = (type + extra).ToString("c");

        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            extra = deluxe;
            TxtSurcharge.Text = extra.ToString("c");
            TxtPrice.Text = (type + extra).ToString("c");
        }

        private void FrmPizzaProblem_Load(object sender, EventArgs e)
        {
            small = 4.99;
            medium = 5.99;
            large = 7.99;
            extraLarge = 9.99;
            basicPizza = 0.89;
            veggie = 1.49;
            meat = 2.07;
            stuffedCrust = 3.45;
            deluxe = 4.75;

            type = 0;
            extra = 0;

            TxtQuantity.Text = "0";
            
        }
    }
}
