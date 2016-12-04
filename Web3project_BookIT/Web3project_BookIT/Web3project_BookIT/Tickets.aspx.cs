using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web3project_BookIT
{
    public partial class Tickets1 : System.Web.UI.Page
    {
        static string Message = "Important Message: Threshold has been exceeded";
        static decimal ThresholdValue = 150;
        static PriceStore priceStore = new PriceStore(Message, ThresholdValue);
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            // Assign the delegate to the composed delegate
            // The Show message method is called when the TotalPrice exceeds a Threshold vlaue, in this case 150.
            priceStore.Exceeded += new PriceStore.ThresholdExceededHandler(ShowMessage);
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                decimal salesPrice = Convert.ToDecimal(txtSalesPrice.Text);
                decimal discountPercent = Convert.ToDecimal(txtDiscountPercent.Text) / 100;

                decimal discountAmount = salesPrice * discountPercent;
                decimal totalPrice = salesPrice - discountAmount;

                lblDiscountAmount.Text = discountAmount.ToString("c");
                lblTotalPrice.Text = totalPrice.ToString("c");
                priceStore.AddPriceToTotal(totalPrice);
            }
        }

        // 
        private void ShowMessage(string message)
        {
            MessageLabel.Text = message;
        }


      
    }
}