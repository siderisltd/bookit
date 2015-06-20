namespace Bookit.Data.Migrations
{
    using BookIt.Models;
    using System;
    using System.Data.Entity.Migrations;

    public sealed class DefaultMigrationConfiguration : DbMigrationsConfiguration<BookItDbContext>
    {
        public DefaultMigrationConfiguration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BookItDbContext context)
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
