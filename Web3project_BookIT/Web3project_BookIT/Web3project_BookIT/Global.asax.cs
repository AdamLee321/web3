using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.Entity;
using Web3project_BookIT.Models;
using Web3project_BookIT.Logic;

namespace Web3project_BookIT
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Initialize the ticket database.
            Database.SetInitializer(new TicketDatabaseInitializer());

            //Create the custom role and user
            Logic.Roles roleActions = new Logic.Roles();
            roleActions.AddUserAndRole();

            // Add Routes.
            RegisterCustomRoutes(RouteTable.Routes);

        }

        private void RegisterCustomRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(
              "TicketsByCategoryRoute",
              "Category/{categoryName}",
              "~/TicketList.aspx"
            );
            routes.MapPageRoute(
              "TicketByNameRoute",
              "Ticket/{ticketName}",
              "~/TicketDetails.aspx"
            );
            routes.MapPageRoute(
               "DisplayBlog", 
               "Blogs/{BlogId}/{Slug}.aspx", 
               "~/News.aspx"
            );
        }
    }
}