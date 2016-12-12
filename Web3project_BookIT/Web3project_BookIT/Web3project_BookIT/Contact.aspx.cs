using System;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Web3project_BookIT.Controllers;
using Web3project_BookIT.Models;
using System.Collections.Specialized;
using System.Net;
using System.Web.UI.WebControls;

namespace Web3project_BookIT
{
    public partial class Contact : Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Web3project_BookIT"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label5.Text = "0 Users have rated this Product";
            //Label6.Text = "Average rating for this Product is 0";
            //if (!IsPostBack)
            //{
            //    BindRatings();
            //}
        }
        protected void Rating5_Changed(object sender, AjaxControlToolkit.RatingEventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = new SqlCommand("INSERT INTO UserRating(Rating) VALUES (@Rating)", con);
            //cmd.Parameters.AddWithValue("@Rating", SqlDbType.Int).Value = Rating5.CurrentRating;
            //cmd.ExecuteNonQuery();
            //con.Close();
            //BindRatings();
        }
        //public void BindRatings()
        //{
        //    int Total = 0;
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("SELECT Rating FROM UserRating", con);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    if (dt.Rows.Count > 0)
        //    {
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            Total += Convert.ToInt32(dt.Rows[i][0].ToString());
        //        }
        //        int Average = Total / (dt.Rows.Count);
        //        Rating5.CurrentRating = Average;
        //        Label5.Text = dt.Rows.Count + " " + "Users have rated this Product";
        //        Label6.Text = "Average rating for this Product is" + " " + Convert.ToString(Average);
        //    }
        //}

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

        //Contact Us Form Sending to a gmail from an email
        protected void Submit(object sender, EventArgs e)
        {
            //bookittestemail is the sender and receiver is adamleeplaysbball
            //To test your own email just replace the receiver email with your own
            try
            {
                MailMessage mm = new MailMessage("bookittestemail@gmail.com", "adamleeplaysbball@hotmail.com");
                mm.Subject = Subject.Text;
                mm.Body = "Name: " + FullName.Text + "<br /><br />Email: " + Email.Text + "<br />" + Message.Text;
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential();
                NetworkCred.UserName = "bookittestemail@gmail.com";
                NetworkCred.Password = "BookIT123$";
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.Send(mm);
                DisplayMessage.Text = "Your E-mail Sent Successfully!";
            }
            catch
            {
                DisplayMessage.Text = "Your E-mail Did Not Send!";
            }
        }

        protected void Clear(object sender, EventArgs e)
        {
            this.ClearForm(this);
        }

        private void ClearForm(Control control)
        {
            foreach (Control c in control.Controls)
            {
                var box = c as TextBox;
                if (box != null)
                {
                    box.Text = string.Empty;
                }

                this.ClearForm(c);
            }
        }
    }
}
