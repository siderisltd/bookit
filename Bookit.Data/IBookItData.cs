namespace Bookit.Data
{
    using System;

    using Microsoft.AspNet.Identity.EntityFramework;

    using BookIt.Contracts;
    using BookIt.Models;
    using Bookit.Data.Repositories.Contracts;

    public interface IBookItData : IDisposable
    {
        IDeletableEntityRepository<Category> Categories { get; }

        IDeletableEntityRepository<Business> Businesses { get; }

        IDeletableEntityRepository<Location> Locations { get; }

        IDeletableEntityRepository<Address> Addresses { get; }

        IDeletableEntityRepository<City> Cities { get; }

        IDeletableEntityRepository<Comment> Comments { get; }

        IDeletableEntityRepository<Customer> Customers { get; }

        IDeletableEntityRepository<Engagement> Engagements { get; }

        IDeletableEntityRepository<Service> Services { get; }

        IDeletableEntityRepository<Street> Streets { get; }

        IDeletableEntityRepository<Vote> Votes { get; }

        IDeletableEntityRepository<WorkingUnit> WorkingUnits { get; }

        IUsersRepository Users { get; }

        IRepository<IdentityRole> Roles { get; }

        IBookItDbContext Context { get; }

        int SaveChanges();
    }
}
