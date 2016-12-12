using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web3project_BookIT.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

//docs.microsoft.com/en-us/azure/app-service-web/web-sites-dotnet-deploy-aspnet-mvc-app-membership-oauth-sql-database#using-the-membership-api
//Code design comes from the address above, my own code and from tutorials by Shane Banks.
namespace Web3project_BookIT.Controllers
{
    internal class Roles
    {
        internal void AddUserAndRole()
        {
            // Access the application context and create result variables.
            Models.ApplicationDbContext context = new ApplicationDbContext();
            IdentityResult IdRoleResult;
            IdentityResult IdUserResult;

            var roleStore = new RoleStore<IdentityRole>(context);
             
            var roleMgr = new RoleManager<IdentityRole>(roleStore);

            var canAddEvents = new RoleManager<IdentityRole>(roleStore);
            //Names such as "canAdd" and "canDelete" have been suggested as role names rather then admin and member
            if (!canAddEvents.RoleExists("canAddEvents"))
            {
                IdRoleResult = canAddEvents.Create(new IdentityRole { Name = "canAddEvents" });
            }

            // Then, you create the "canEdit" role if it doesn't already exist.
            if (!roleMgr.RoleExists("canEdit"))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = "canEdit" });
            }

            var userEventPlanner = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var appEventPlanner = new ApplicationUser
            {
                UserName = "EventPlanner1@BookIt.ie", 
                Email = "EventPlanner1@BookIt.ie" 
            };
            IdUserResult = userEventPlanner.Create(appEventPlanner, "Pa$$wordEvntPlanner1");

            var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var appUser = new ApplicationUser
            {
                UserName = "canEditUser@BookIT.com",
                Email = "canEditUser@BookIT.com"
            };
            IdUserResult = userMgr.Create(appUser, "Pa$$word1");

            // If the new "canEdit" user was successfully created, 
            // add the "canEdit" user to the "canEdit" role. 
            //Same "canAddEvents" role.
            if (!userMgr.IsInRole(userMgr.FindByEmail("canEditUser@BookIT.com").Id, "canEdit"))
            {
                IdUserResult = userMgr.AddToRole(userMgr.FindByEmail("canEditUser@BookIT.com").Id, "canEdit");
            }
            if (!userEventPlanner.IsInRole(userEventPlanner.FindByEmail("EventPlanner1@BookIt.ie").Id, "canAddEvents"))
            {
                IdUserResult = userMgr.AddToRole(userMgr.FindByEmail("EventPlanner1@BookIt.ie").Id, "canAddEvents");
            }
        }
    }
}