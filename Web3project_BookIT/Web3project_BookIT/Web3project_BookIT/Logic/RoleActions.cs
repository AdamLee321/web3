using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web3project_BookIT.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Web3project_BookIT.Logic
{
    internal class RoleActions
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
                UserName = "EventPlanner1@BookIt.ie", //THIS NEEDS TO COME FROM LOGIN INFO NOT HARDCODED
                Email = "EventPlanner1@BookIt.ie" //THIS NEEDS TO COME FROM LOGIN INFO NOT HARDCODED
            };
            IdUserResult = userEventPlanner.Create(appEventPlanner, "Pa$$wordEvntPlanner1");

            // Create a UserManager object based on the UserStore object and the ApplicationDbContext  
            // object. Note that you can create new objects and use them as parameters in
            // a single line of code, rather than using multiple lines of code, as you did
            // for the RoleManager object.
            var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var appUser = new ApplicationUser
            {
                UserName = "canEditUser@BookIT.com",
                Email = "canEditUser@BookIT.com"
            };
            IdUserResult = userMgr.Create(appUser, "Pa$$word1");

            // If the new "canEdit" user was successfully created, 
            // add the "canEdit" user to the "canEdit" role. 
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