namespace BookIt.Data
{
    using System;

    using Microsoft.AspNet.Identity.EntityFramework;   
    
    using BookIt.Data.Common.Repositories;
    using BookIt.Data.Models;

    public interface IBookItData : IDisposable
    {
        IDeletableEntityRepository<Category> Categories { get; }

        IDeletableEntityRepository<Location> Businesses { get; }

        IDeletableEntityRepository<Location> Locations { get; }

        IDeletableEntityRepository<Comment> Comments { get; }

        IDeletableEntityRepository<Customer> Customers { get; }

        IDeletableEntityRepository<Appointment> Appointments { get; }

        IDeletableEntityRepository<Service> Services { get; }

        IDeletableEntityRepository<Vote> Votes { get; }

        IDeletableEntityRepository<StaffUnit> StaffUnits { get; }

        IUsersRepository Users { get; }

        IRepository<IdentityRole> Roles { get; }

        IBookItDbContext Context { get; }

        int SaveChanges();
    }
}
