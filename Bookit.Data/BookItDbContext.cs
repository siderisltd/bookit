namespace Bookit.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using BookIt.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    
    public class BookItDbContext : IdentityDbContext<AppUser>, IBookItDbContext
    {
        public BookItDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Location> BusinessLocations { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Comment> Comments { get; set; }

        public IDbSet<Customer> Customers { get; set; }

        public IDbSet<Service> Services { get; set; }

        public IDbSet<Engagement> Subscriptions { get; set; }

        public IDbSet<WorkingUnit> Units { get; set; }

        public IDbSet<Vote> Votes { get; set; }

        public IDbSet<Address> Addresses { get; set; }

        public IDbSet<City> Citys { get; set; }

        public IDbSet<Street> Streets { get; set; }

        public DbContext DbContext
        {
            get { return this; }
        }

        public static BookItDbContext Create()
        {
            return new BookItDbContext();
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public void ClearDatabase()
        {
            throw new NotImplementedException();
        }

        public DbEntityEntry<TEntity> Entity<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}
