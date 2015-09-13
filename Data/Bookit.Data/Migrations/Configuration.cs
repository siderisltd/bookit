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

        protected override void Seed(BookItDbContext context)
        {
            context.Categories.AddOrUpdate(c => c.Name,
                new Category()
                {
                    Name = "Restorant",
                    CreatedOn = DateTime.Now,
                    PreserveCreatedOn = true,
                }, new Category()
                {
                    Name = "Hairdresser",
                    CreatedOn = DateTime.Now,
                    PreserveCreatedOn = true,
                }, new Category()
                {
                    Name = "Doctor",
                    CreatedOn = DateTime.Now,
                    PreserveCreatedOn = true,
                });
        }
    }
}
