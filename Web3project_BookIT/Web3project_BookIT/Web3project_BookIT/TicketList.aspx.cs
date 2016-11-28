using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web3project_BookIT.Models;

namespace Web3project_BookIT
{
    public partial class TicketList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Ticket> GetTickets([QueryString("id")] int? categoryId)
        {
            var _db = new TicketContext();
            IQueryable<Ticket> query = _db.Tickets;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            return query;
        }
    }
}
