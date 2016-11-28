using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web3project_BookIT.Models;

namespace Web3project_BookIT.Logic
{
    public class AddTickets
    {
        public bool AddTicket(string TicketName, string TicketTime, string TicketDate, string TicketDesc, string TicketPrice, string TicketCategory, string TicketImagePath)
        {
            var myTicket = new Ticket();
            myTicket.TicketName = TicketName;
            myTicket.TicketTime = TicketTime;
            myTicket.TicketDate = TicketDate;
            myTicket.Description = TicketDesc;
            myTicket.UnitPrice = Convert.ToDouble(TicketPrice);
            myTicket.ImagePath = TicketImagePath;
            myTicket.CategoryID = Convert.ToInt32(TicketCategory);

            using (TicketContext _db = new TicketContext())
            {
                // Add ticket to the DB.
                _db.Tickets.Add(myTicket);
                _db.SaveChanges();
            }
            // Success.
            return true;
        }
    }
}