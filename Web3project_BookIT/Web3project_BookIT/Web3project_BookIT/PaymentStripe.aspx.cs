﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// coded by Michael
namespace Web3project_BookIT
{
    public partial class PaymentStripe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TicketPrice_TextChanged(object sender, EventArgs e)
        {
            lblChecker.Text = "Purchase Complete Thanks again";
        }
        //protected void CheckoutBtn_Click(object sender, ImageClickEventArgs e)
        //{
        //    using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
        //    {
        //        Session["payment_amt"] = usersShoppingCart.GetTotal();
        //    }
        //    Response.Redirect("Checkout/CheckoutStart.aspx");
        //}
    }
}