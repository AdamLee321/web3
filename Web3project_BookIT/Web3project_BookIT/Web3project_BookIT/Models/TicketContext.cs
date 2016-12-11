using System;
using System.Collections.Generic;
//This code adds the System.Data.Entity namespace so that you have access to all the core 
//functionality of Entity Framework, which includes the capability to query, insert, update, and delete data by working with strongly typed objects.
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web3project_BookIT.Models
{
    public class TicketContext : DbContext
    {
        public TicketContext() : base("Web3project_BookIT")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; } //Adding the shopping cart to the DBContext
        public DbSet<Order> Orders { get; set; } //Order info
        public DbSet<OrderDetail> OrderDetails { get; set; } //Order info
        public DbSet<Venue> Venues { get; set; } // Venue Details
    }
}