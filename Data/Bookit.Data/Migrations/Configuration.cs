namespace Bookit.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using BookIt.Data.Models;

    public sealed class Configuration : DbMigrationsConfiguration<BookItDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BookItDbContext ctx)
        {
            //TODO: Add innitial data and create a fake repo for testing in folder tests

            // 7 categories
            //#region categoriesInitializing
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
    }
}
