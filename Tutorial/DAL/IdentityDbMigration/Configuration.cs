namespace Tutorial.DAL.IdentityDbMigration
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Tutorial.DAL.IdentityDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DAL\IdentityDbMigration";
        }

        protected override void Seed(Tutorial.DAL.IdentityDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            #region Create Role
            this.createDefaultRole("admin", "ธุรการ", context);
            this.createDefaultRole("lawyer", "นิติกร", context);
            this.createDefaultRole("superadmin", "ผู้ดูแลระบบ", context);
            this.createDefaultRole("person", "บุคคลทั่วไป", context);

            #endregion

            #region Create default user ( Format #1 )
            this.createDefaultUser("superadmin", "superadmin", context);
            this.createDefaultUser("admin", "admin", context);
            this.createDefaultUser("lawyer", "lawyer", context);
            this.createDefaultUser("person", "person", context);
            #endregion

            #region Create default user ( Format #2 )
            //PasswordHasher hasher = new PasswordHasher();
            //context.Users.AddOrUpdate(u => u.UserName,
            //    new ApplicationUser() { UserName ="superadmin", PasswordHash = hasher.HashPassword("P@ssw0rd") },
            //    new ApplicationUser() { UserName = "admin", PasswordHash = hasher.HashPassword("P@ssw0rd") },
            //    new ApplicationUser() { UserName = "lawyer", PasswordHash = hasher.HashPassword("P@ssw0rd") },
            //    new ApplicationUser() { UserName = "person", PasswordHash = hasher.HashPassword("P@ssw0rd") }
            //);
            #endregion
        }

        public void createDefaultUser(string username, string role, Tutorial.DAL.IdentityDb context)
        {
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            if (!context.Users.Any(u => u.UserName == username))
            {
                var user = new ApplicationUser { UserName = username, Email = username + "@mail.com" };
                var result = userManager.Create(user, "P@ssw0rd");
                if (result.Succeeded)
                {
                    userManager.AddToRole(user.Id, role);
                }

            }
        }

        public void createDefaultRole(string role, string desc, Tutorial.DAL.IdentityDb context)
        {
            var roleStore = new RoleStore<ApplicationRole>(context);
            var roleManager = new RoleManager<ApplicationRole>(roleStore);

            if (!roleManager.RoleExists(role))
            {
                roleManager.Create(new ApplicationRole() { Name = role, Description = desc });
            }
            
        }
    }
}
