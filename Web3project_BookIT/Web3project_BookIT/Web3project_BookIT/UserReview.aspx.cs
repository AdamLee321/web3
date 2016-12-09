using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Web3project_BookIT.Logic;
using Web3project_BookIT.Models;
using System.Collections.Specialized;

namespace Web3project_BookIT
{
    public partial class UserReview : System.Web.UI.Page
    {
       
            protected void Page_Load(object sender, EventArgs e)
            {

            }
            protected void Btn_SendMail_Click(object sender, EventArgs e)
            {
                MailMessage mailObj = new MailMessage(
                    txtFrom.Text, txtTo.Text, txtSubject.Text, txtBody.Text);
                SmtpClient SMTPServer = new SmtpClient("mail.smtp2go.com");
                try
                {
                    SMTPServer.Send(mailObj);
                }
                catch (Exception ex)
                {
                    Label1.Text = ex.ToString();
                }

            }

            protected void btnValue_Click(object sender, EventArgs e)
            {
                //            SqlConnection con = new SqlConnection(System.Configuration.
                //ConfigurationManager.ConnectionStrings["con"].ToString());
                //            try
                //            {
                //                string query = "insert into UserDetail(Name,Rating,TicketBought) 
                //                values('" + Name.Text + "', '" + Rating2.Text + "', '" + TickeName.Text + "'); ";
                //                SqlDataAdapter da = new SqlDataAdapter(query, con);
                //                con.Open();
                //                da.SelectCommand.ExecuteNonQuery();
                //                con.Close();
                //                Label12.Text = "Data saved successfully.";
                //            }
                //            catch
                //            {
                //                con.Close();
                //                Label13.Text = "Error while saving data.";
                //            }

                Label2.Text = Rating2.Text;
                Label3.Text = TickeName.Text;
                Label4.Text = Name.Text;
                lblThanks.Text = "Thank you for the review";
                //Label2.Text = Rating1.CurrentRating.ToString();
            }
        }
    }
