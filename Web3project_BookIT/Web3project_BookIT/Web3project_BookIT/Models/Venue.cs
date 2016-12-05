using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web3project_BookIT.Models
{
    public class Venue
    {
        [ScaffoldColumn(false)]
        public int VenueID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string VenueName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Capacity { get; set; }

    }
}