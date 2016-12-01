using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web3project_BookIT.Logic;

namespace Web3project_BookIT.Admin
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string TicketAction = Request.QueryString["TicketAction"];
            if (TicketAction == "add")
            {
                LabelAddStatus.Text = "Ticket added!";
            }

            if (TicketAction == "remove")
            {
                LabelRemoveStatus.Text = "Ticket removed!";
            }
        }

        protected void AddTicketButton_Click(object sender, EventArgs e)
        {
            Boolean fileOK = false;
            String path = Server.MapPath("~/Catalog/Images/");
            if (TicketImage.HasFile)
            {
                String fileExtension = System.IO.Path.GetExtension(TicketImage.FileName).ToLower();
                String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }

            if (fileOK)
            {
                try
                {
                    // Save to Images folder.
                    TicketImage.PostedFile.SaveAs(path + TicketImage.FileName);
                    // Save to Images/Thumbs folder.
                    TicketImage.PostedFile.SaveAs(path + "Thumbs/" + TicketImage.FileName);
                }
                catch (Exception ex)
                {
                    LabelAddStatus.Text = ex.Message;
                }

                // Add ticket data to DB.
                AddTickets Tickets = new AddTickets();
                bool addSuccess = Tickets.AddTicket(AddTicketName.Text, AddTicketTime.Text, AddTicketDate.Text, AddTicketDescription.Text, AddTicketVenue.Text,
                    AddTicketPrice.Text, DropDownAddCategory.SelectedValue, TicketImage.FileName);
                if (addSuccess)
                {
                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?TicketAction=add");
                }
                else
                {
                    LabelAddStatus.Text = "Unable to add new ticket to database.";
                }
            }
            else
            {
                LabelAddStatus.Text = "Unable to accept file type.";
            }
        }

        public IQueryable GetCategories()
        {
            var _db = new Models.TicketContext();
            IQueryable query = _db.Categories;
            return query;
        }

        public IQueryable GetTickets()
        {
            var _db = new Models.TicketContext();
            IQueryable query = _db.Tickets;
            return query;
        }

        protected void RemoveTicketButton_Click(object sender, EventArgs e)
        {
            using (var _db = new Models.TicketContext())
            {
                int TicketId = Convert.ToInt16(DropDownRemoveTicket.SelectedValue);
                var myItem = (from c in _db.Tickets where c.TicketID == TicketId select c).FirstOrDefault();
                if (myItem != null)
                {
                    _db.Tickets.Remove(myItem);
                    _db.SaveChanges();

                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?TicketAction=remove");
                }
                else
                {
                    LabelRemoveStatus.Text = "Unable to locate ticket.";
                }
            }
        }
    }
}