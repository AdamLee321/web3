using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web3project_BookIT.Models;

namespace Web3project_BookIT
{
    public partial class News : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        //public IQueryable<News> GetNews([QueryString("id")] int? NewsID)
        //{
        //    var _db = new Models.TicketContext();
        //    IQueryable<News> query = _db.News;
        //    if (NewsID.HasValue && NewsID > 0)
        //    {
        //        query = query.Where(p => p.NewsID == NewsID);
        //    }
        //    return query;
        //}
    
            

        //private void PopulateBlog()
        //{
        //    string blogId = this.Page.RouteData.Values["BlogId"].ToString();
        //    string query = "SELECT [Title], [Blog] FROM [Blog] WHERE [BlogId] = @BlogId";
        //    string conString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        //    using (SqlConnection con = new SqlConnection(conString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand(query))
        //        {
        //            using (SqlDataAdapter sda = new SqlDataAdapter())
        //            {
        //                cmd.Parameters.AddWithValue("@BlogId", blogId);
        //                cmd.Connection = con;
        //                sda.SelectCommand = cmd;
        //                using (DataTable dt = new DataTable())
        //                {
        //                    sda.Fill(dt);
        //                    lblTitle.Text = dt.Rows[0]["Title"].ToString();
        //                    lblBody.Text = dt.Rows[0]["Blog"].ToString();
        //                }
        //            }
        //        }
        //    }
        //}
        protected void Submit(object sender, EventArgs e)
        {
        
        }
    }
}