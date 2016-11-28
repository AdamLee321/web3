using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Web3project_BookIT.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        public string Username { get; set; }

        public int TicketId { get; set; }

        public int Quantity { get; set; }

        public double? UnitPrice { get; set; }

    }
}