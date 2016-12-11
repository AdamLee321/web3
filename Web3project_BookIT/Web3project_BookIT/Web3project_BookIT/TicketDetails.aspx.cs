using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web3project_BookIT.Models;
using System.Web.ModelBinding;

//Code to display individual tickets on a seperate page
namespace Web3project_BookIT
{
    public partial class TicketDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Ticket> GetTicket(
                    [QueryString("TicketID")] int? ticketId,
                    [RouteData] string ticketName)
        {
            var _db = new TicketContext();
            IQueryable<Ticket> query = _db.Ticket;
            if (ticketId.HasValue && ticketId > 0)
            {
                query = query.Where(t => t.TicketID == ticketId);
            }
            else if (!String.IsNullOrEmpty(ticketName))
            {
                query = query.Where(t =>
                          String.Compare(t.TicketName, ticketName) == 0);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}