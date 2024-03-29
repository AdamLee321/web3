﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web3project_BookIT.Controllers;
using Web3project_BookIT.Models;
using System.Collections.Specialized;
using System.Collections;
using System.Web.ModelBinding;
using Stripe;
using System.Threading.Tasks;
using System.Globalization;

//Shooping Cart By Adam with help from ASP.Net
//Paypal By Adam
//Stripe payment option added by Michael
namespace Web3project_BookIT
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        public delegate void MyDelegate(string var);
        protected void Page_Load(object sender, EventArgs e)
        {
            //var TicketPrice = Ticket.UnitPrice;

            using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
            {
                decimal cartTotal = 0; //Set cart equal to zero
                cartTotal = usersShoppingCart.GetTotal();
                if (cartTotal > 0 )
                {
                    // Display Total.
                    lblTotal.Text = String.Format("{0:c}", cartTotal);
                }
                else
                {
                    LabelTotalText.Text = "";
                    lblTotal.Text = "";
                    ShoppingCartTitle.InnerText = "Shopping Cart is Empty";
                    Update.Visible = false;
                    CheckoutImageBtn.Visible = false;

                }
            }
        }
        public List<CartItem> GetShoppingCartItems() //List of Items in the cart
        {
            ShoppingCartActions actions = new ShoppingCartActions();
            return actions.GetCartItems();
        }
        public List<CartItem> UpdateCartItems()
        {
            using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
            {
                String cartId = usersShoppingCart.GetCartId();

                ShoppingCartActions.ShoppingCartUpdates[] cartUpdates = new ShoppingCartActions.ShoppingCartUpdates[CartList.Rows.Count];
                for (int i = 0; i < CartList.Rows.Count; i++)
                {
                    IOrderedDictionary rowValues = new OrderedDictionary();
                    rowValues = GetValues(CartList.Rows[i]);
                    cartUpdates[i].TicketId = Convert.ToInt32(rowValues["TicketID"]);

                    CheckBox cbRemove = new CheckBox();
                    cbRemove = (CheckBox)CartList.Rows[i].FindControl("Remove");
                    cartUpdates[i].RemoveItem = cbRemove.Checked;

                    TextBox quantityTextBox = new TextBox();
                    quantityTextBox = (TextBox)CartList.Rows[i].FindControl("PurchaseQuantity");
                    cartUpdates[i].PurchaseQuantity = Convert.ToInt16(quantityTextBox.Text.ToString());
                }
                usersShoppingCart.UpdateShoppingCartDatabase(cartId, cartUpdates);
                CartList.DataBind();
                lblTotal.Text = String.Format("{0:c}", usersShoppingCart.GetTotal());
                return usersShoppingCart.GetCartItems();
            }
        }

        public static IOrderedDictionary GetValues(GridViewRow row)
        {
            IOrderedDictionary values = new OrderedDictionary();
            foreach (DataControlFieldCell cell in row.Cells)
            {
                if (cell.Visible)
                {
                    // Extract values from the cell.
                    cell.ContainingField.ExtractValuesFromCell(values, cell, row.RowState, true);
                }
            }
            return values;
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            UpdateCartItems();
        }

        protected void BtnPay_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaymentStripe.aspx");
        }
        //PayPal Update Event Handler
        protected void CheckoutBtn_Click(object sender, ImageClickEventArgs e)
        {
            using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
            {
                Session["payment_amt"] = usersShoppingCart.GetTotal();
            }
            Response.Redirect("Checkout/CheckoutStart.aspx");
        }


    }
}