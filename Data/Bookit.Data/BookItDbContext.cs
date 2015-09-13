namespace BookIt.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    using Microsoft.AspNet.Identity.EntityFramework;

    using BookIt.Data.Models;
    
    public class BookItDbContext : IdentityDbContext<ApplicationUser>, IBookItDbContext
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

        public IDbSet<Appointment> Appointments { get; set; }

        public IDbSet<StaffUnit> Staff { get; set; }

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

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}
