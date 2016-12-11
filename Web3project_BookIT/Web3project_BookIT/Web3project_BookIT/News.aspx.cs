using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web3project_BookIT
{
    public partial class Newblog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\adaml\Desktop\BookIT\web3\Web3project_BookIT\Web3project_BookIT\Web3project_BookIT\App_Data\Web3project_BookIT.mdf;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into Blog(Title, Body) values('Third News Post', 'we hope you it works');");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            //cmd.CommandText = "INSERT INTO Blog VALUES ('" + txtTitle.Text + "','" + txtBody.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            //if (!this.IsPostBack)
            //{
            //    this.PopulateBlog();
            //}
        }

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
        //    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\adaml\Desktop\BookIT\web3\Web3project_BookIT\Web3project_BookIT\Web3project_BookIT\App_Data\Web3project_BookIT.mdf;Integrated Security=True");
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("Insert into Blog(Title, Body) values('Third News Post', 'we hope you it works');");
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = conn;
        //    //cmd.CommandText = "INSERT INTO Blog VALUES ('" + txtTitle.Text + "','" + txtBody.Text + "')";
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        }
    }
}