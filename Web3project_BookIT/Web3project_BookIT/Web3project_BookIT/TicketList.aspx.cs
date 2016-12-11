using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web3project_BookIT.Models;
using System.Web.Routing;

namespace Web3project_BookIT
{
    public partial class TicketList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Ticket> GetTickets(
                    [QueryString("id")] int? categoryId,
                    [RouteData] string categoryName)
        {
            var _db = new TicketContext();
            IQueryable<Ticket> query = _db.Ticket;

            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }

            if (!String.IsNullOrEmpty(categoryName))
            {
                query = query.Where(p =>
                                    String.Compare(p.Category.CategoryName,
                                    categoryName) == 0);
            }
            return query;
        }
    }
}
