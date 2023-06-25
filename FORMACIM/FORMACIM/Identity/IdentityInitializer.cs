using FORMACIM.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ETICARET.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            //Rolleri
            if (!context.Roles.Any(i => i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "admin", Description = "Admin Rolü" };
                manager.Create(role);
            }
            if (context.Roles.Any(i => i.Name == "user") == false)
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "user", Description = "User Rolü" };
                manager.Create(role);
            }
            //User
            if (!context.Users.Any(i => i.Name == "muhammetoguz"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "muhammet", Surname = "oğuz", UserName = "muhammetoguz", Email = "oguzm2323@gmail.com" };

                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "user");
                manager.AddToRole(user.Id, "admin");
            }

            if (!context.Users.Any(i => i.Name == "musaoguz"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "musa", Surname = "oguz", UserName = "musaoguz", Email = "musaoguz@gmail.com" };

                manager.Create(user, "12345678");
                manager.AddToRole(user.Id, "user");
            }

            base.Seed(context);
        }
    }
}