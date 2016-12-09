using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web3project_BookIT.Models;

namespace Web3project_BookIT.Logic
{
    public class AddVenues
    {
        public bool AddVenue(string VenueName, string VenueAdd1, string VenueAdd2, string VenueCity, string VenueCounty, string VenueCapacity)
        {
            var myVenue = new Venue();
            myVenue.VenueName = VenueName;
            myVenue.Address1 = VenueAdd1;
            myVenue.Address2 = VenueAdd2;
            myVenue.City = VenueCity;
            myVenue.County = VenueCounty;
            myVenue.Capacity = Convert.ToInt32(VenueCapacity);
            
            using (TicketContext _db = new TicketContext())
            {
                // Add venue to the DB.
                _db.Venue.Add(myVenue);
                _db.SaveChanges();
            }
            // Success.
            return true;
        }
    }
}