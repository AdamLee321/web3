using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web3project_BookIT.Models;
using System.Web.ModelBinding;

namespace Web3project_BookIT
{
    public partial class TicketDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Ticket> GetTicket([QueryString("TicketID")] int? TicketID)
        {
            var _db = new Web3project_BookIT.Models.TicketContext();
            IQueryable<Ticket> query = _db.Tickets;
            if (TicketID.HasValue && TicketID > 0)
            {
                query = query.Where(t => t.TicketID == TicketID);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}