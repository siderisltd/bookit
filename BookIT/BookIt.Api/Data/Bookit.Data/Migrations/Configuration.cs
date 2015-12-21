namespace Bookit.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using BookIt.Data.Common;
    using BookIt.Data.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;


    public sealed class Configuration : DbMigrationsConfiguration<BookItDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BookItDbContext ctx)
        {
            //Innitial roles
            //var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(ctx));
            AddOrUpdateRoles(ctx);


            //TODO: Add innitial data and create a fake repo for testing in folder tests

            //7 categories
            // #region categoriesInitializing
            //ctx.Categories.AddOrUpdate(c => c.Name,
            //    new Category()
            //    {
            //        Name = "Restorant",
            //        PreserveCreatedOn = true,
            //    }, new Category()
            //    {
            //        Name = "Hairdresser",
            //        PreserveCreatedOn = true,
            //    }, new Category()
            //    {
            //        Name = "Doctor",
            //        PreserveCreatedOn = true,
            //    }, new Category()
            //    {
            //        Name = "Massagist",
            //        CreatedOn = DateTime.Now,
            //        PreserveCreatedOn = false,
            //    }, new Category()
            //    {
            //        Name = "Manaf",
            //        PreserveCreatedOn = true,
            //    }, new Category()
            //    {
            //        Name = "Prostitute",
            //        PreserveCreatedOn = true,
            //    }, new Category()
            //    {
            //        Name = "Gigolo",
            //        CreatedOn = DateTime.Now,
            //        PreserveCreatedOn = false,
            //    });
            //#endregion

            //#region locations

            //ctx.BusinessLocations.AddOrUpdate(x => x.Name,
            //    new Location()
            //    {
            //        Name = "Test1",
            //        //Categories = ctx.Categories
            //    },
            //    new Location()
            //    {

            //    },
            //    new Location()
            //    {

            //    },
            //    new Location()
            //    {

            //    },
            //    new Location()
            //    {

            //    },
            //    new Location()
            //    {

            //    },
            //    new Location()
            //    {

            //    });

            //#endregion
        }

        private static void AddOrUpdateRoles(BookItDbContext ctx)
        {
            var allRoles = new string[]
            {
                ConstantRoles.ADMIN_ROLE,
                ConstantRoles.CREATOR_ROLE,
                ConstantRoles.EMPLOYEE_ROLE,
                ConstantRoles.MANAGER_ROLE,
                ConstantRoles.OWNER_ROLE,
                ConstantRoles.SUPERVISOR_ROLE,
                ConstantRoles.WORKER_ROLE,
                ConstantRoles.CLIENT_ROLE
            };

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(ctx));

            foreach (var roleName in allRoles)
            {
                if (!roleManager.RoleExists(roleName))
                {
                    roleManager.Create(new IdentityRole(roleName));
                }
            }
        }
    }
}
