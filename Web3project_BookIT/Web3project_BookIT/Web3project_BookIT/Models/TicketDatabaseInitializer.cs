using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Web3project_BookIT.Models
{
    //This Class is to initialise the database and add the categories,Venues and Events.
    public class TicketDatabaseInitializer : DropCreateDatabaseIfModelChanges<TicketContext>
    {
        protected override void Seed(TicketContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetTickets().ForEach(p => context.Tickets.Add(p));
            GetVenues().ForEach(v => context.Venue.Add(v));
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
                    TicketVenue = "Stradbally Hall",
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
                    TicketVenue = "3 Arena",
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
                    TicketVenue = "RDS",
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
                    TicketVenue = "Croke Park",
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
                    TicketVenue = "Hawks Well Theatre",
                    ImagePath="",
                    UnitPrice = 10.00,
                    CategoryID = 4
               }
               };

            return tickets;
        }

        private static List<Venue> GetVenues()
        {
            var venues = new List<Venue> {
            new Venue
            {
                VenueID = 1,
                VenueName = "RDS",
                Address1 = "Royal Dublin Society",
                Address2 = "Anglesea Rd",
                City = "Dublin",
                County = "Dublin",
                Capacity = 500
            },
            new Venue
            {
                VenueID = 2,
                VenueName = "3 Arena",
                Address1 = "N Wall Quay",
                Address2 = "North Dock",
                City = "Dublin",
                County = "Dublin",
                Capacity = 1000
            },
            new Venue
            {
                VenueID = 3,
                VenueName = "Stradbally Hall",
                Address1 = "Stradbally",
                Address2 = "North Dock",
                City = "Laois",
                County = "Laois",
                Capacity = 1000
            },
            new Venue
            {
                VenueID = 4,
                VenueName = "Croke Park",
                Address1 = "Jones' Rd",
                Address2 = "Drumcondra",
                City = "Dublin",
                County = "Dublin",
                Capacity = 82300
            },
            new Venue
            {
                VenueID = 5,
                VenueName = "Hawks Well Theatre",
                Address1 = "Temple Street",
                Address2 = "",
                City = "Sligo",
                County = "Sligo",
                Capacity = 330
            }
            };
            return venues;
        }
    }
}