﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using Web3project_BookIT.Logic; //Importing the Logic Folder for the shopping cart


namespace Web3project_BookIT
{
    public partial class AddToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rawId = Request.QueryString["TicketID"]; //This might have to be events CHANGE IN THE CLEAN UP
            int ticketId;
            if (!String.IsNullOrEmpty(rawId) && int.TryParse(rawId, out ticketId))
            {
                using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
                {
                    usersShoppingCart.AddToCart(Convert.ToInt16(rawId));
                }

            }
            else
            {
                Debug.Fail("ERROR : We should never get to AddToCart.aspx without a TicketId.");
                throw new Exception("ERROR : It is illegal to load AddToCart.aspx without setting a TicketId.");
            }
            Response.Redirect("ShoppingCart.aspx");
        }
    }
}