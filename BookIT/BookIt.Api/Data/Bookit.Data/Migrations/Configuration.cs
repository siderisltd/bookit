namespace Bookit.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Collections.Generic;
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
            #region ApplicationUsers
            DataSeeder<ApplicationUser> applicationUsers = new DataSeeder<ApplicationUser>();
            applicationUsers.SeedData();
            #endregion

            #region Appointments
            var appointments = new Appointment[]
            {
                new Appointment
                {

                },
            };
            #endregion

            #region Businesses
            var businesses = new Business[]
            {
                new Business
                {

                },
            };
            #endregion






            #region categories
            var categories = new Category[]
            {
                new Category()
                {
                    Name = "Restorant",
                    PreserveCreatedOn = true,
                },
                new Category()
                {
                    Name = "Hairdresser",
                    PreserveCreatedOn = true,
                },
                new Category()
                {
                    Name = "Doctor",
                    PreserveCreatedOn = true,
                },
                new Category()
                {
                    Name = "Massagist",
                    CreatedOn = DateTime.Now,
                    PreserveCreatedOn = false,
                },
                new Category()
                {
                    Name = "Manaf",
                    PreserveCreatedOn = true,
                },
                new Category()
                {
                    Name = "Prostitute",
                    PreserveCreatedOn = true,
                },
                new Category()
                {
                    Name = "Gigolo",
                    CreatedOn = DateTime.Now,
                    PreserveCreatedOn = false,
                }
            };
            #endregion

            #region serviceProviders

            var serviceProviders = new StaffUnit[]
            {
                new StaffUnit
                {
                    
                    Name = "Gosho",
                    
                },
                new StaffUnit
                {

                },
                new StaffUnit
                {

                },
                new StaffUnit
                {

                },
                new StaffUnit
                {

                },
                new StaffUnit
                {

                },
                new StaffUnit
                {

                },
                new StaffUnit
                {

                },
                new StaffUnit
                {

                },
                new StaffUnit
                {

                },
            };
            #endregion

            #region services
            var services = new Service[]
            {
                new Service
                {
                    DurationInMinutes = 60,
                    Price = 16.99m,
                    PreserveCreatedOn = true,
                    Category = categories[0]
                },
                new Service
                {
                    Category = categories[1]
                },
                new Service
                {
                    Category = categories[1]
                },
                new Service
                {
                    Category = categories[1]
                },
                new Service
                {
                    Category = categories[1]
                },
                new Service
                {
                    Category = categories[3]
                },
                new Service
                {
                    Category = categories[4]
                },
                new Service
                {
                    Category = categories[2]
                },
            };
            #endregion

            #region comments
            var comments = new Comment[]
            {
                new Comment
                {

                },
            };
            #endregion

            ctx.Categories.AddOrUpdate(c => c.Name, categories);


            //#region locations
            //ctx.BusinessLocations.AddOrUpdate(x => x.Name, )

            ctx.BusinessLocations.AddOrUpdate(x => x.Name,
                new Location()
                {
                    Name = "Test1",
                    //Categories = ctx.Categories
                },
                new Location()
                {

                },
                new Location()
                {

                },
                new Location()
                {

                },
                new Location()
                {

                },
                new Location()
                {

                },
                new Location()
                {

                });

            //#endregion
        }
    }
}
