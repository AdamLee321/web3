using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web3project_BookIT.Models
{
    //All Tickets for every event
    public class Ticket
    {
        [ScaffoldColumn(false)]
        public int TicketID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string TicketName { get; set; }

        [Required, StringLength(10000), Display(Name = "Ticket Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string TicketDate { get; set; }

        public string TicketTime { get; set; }

        public string TicketVenue { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Price")]
        public double? UnitPrice { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}