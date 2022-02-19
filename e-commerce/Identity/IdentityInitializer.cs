using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Entity;
using System.Linq;
using System.Web;
using e_commerce.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace e_commerce.Identity
{
    public class IdentityInitializer:CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            //Roller
            if (!context.Roles.Any(i=>i.Name=="admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole(){Name = "admin",Description = "admin rolü"};

                manager.Create(role);


            }
            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole(){ Name = "user",Description = "user rolü"};

                manager.Create(role);


            }

            if (!context.Roles.Any(i => i.Name == "serkantopal"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser(){ Name = "Serkan", Surname = "Topal",UserName = "serkantopal",Email = "serkan98topal@gmail.com" };

                manager.Create(user,"123456");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");


            }
            if (!context.Roles.Any(i => i.Name == "kayatopal"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "kaya", Surname = "Topal",UserName = "kayatopal",Email = "kaya98topal@gmail.com" };

                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "user");


            }

            base.Seed(context);
        }
    }
}