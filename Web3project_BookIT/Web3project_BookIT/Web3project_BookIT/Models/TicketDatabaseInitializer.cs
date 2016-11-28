using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Web3project_BookIT.Models
{
    //This Class is to initialise the database and add the categories and events so far
    public class TicketDatabaseInitializer : DropCreateDatabaseIfModelChanges<TicketContext>
    {
        protected override void Seed(TicketContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetTickets().ForEach(p => context.Tickets.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Music"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Sport"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Comedy"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Arts"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Family"
                },
            };

            return categories;
        }

        private static List<Ticket> GetTickets()
        {
            var tickets = new List<Ticket> {
                new Ticket
                {
                    TicketID = 1,
                    TicketName = "Electric Picnic",
                    Description = "EP is Awesome ",
                    TicketTime = "11:00",
                    TicketDate = "12/07/17",
                    ImagePath="ep-logo-2017_1.png", //When working check the images
                    UnitPrice = 120.00,
                    CategoryID = 1
               },
               new Ticket
               {
                    TicketID = 2,
                    TicketName = "Pat Shortt How's Tings",
                    Description = "Latest Tour from the legendary Pat Shortt",
                    TicketTime = "21:00",
                    TicketDate = "12/07/17",
                    ImagePath="",
                    UnitPrice = 25.50,
                    CategoryID = 3
               },
               new Ticket
               {
                    TicketID = 3,
                    TicketName = "Frozen On Ice",
                    Description = "Frozen the movie but on ice ",
                    TicketTime = "17:00",
                    TicketDate = "12/07/17",
                    ImagePath="",
                    UnitPrice = 20.00,
                    CategoryID = 5
                },
               new Ticket
               {
                   TicketID = 4,
                    TicketName = "GAA Croke Park Season Pass",
                    Description = "Access All Year to Croke Park for all GAA events ",
                    TicketTime = "14:00",
                    TicketDate = "12/07/17",
                    ImagePath="",
                    UnitPrice = 500.00,
                    CategoryID = 2
               },
               new Ticket
               {
                   TicketID = 5,
                    TicketName = "Grease Musical",
                    Description = "Sligo IT Drama students will perform the musical Grease",
                    TicketTime = "18:00",
                    TicketDate = "12/07/17",
                    ImagePath="",
                    UnitPrice = 10.00,
                    CategoryID = 4
               }
               };

            return tickets;
        }
    }
}