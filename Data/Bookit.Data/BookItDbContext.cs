namespace Bookit.Data
{
    using System.Data.Entity;
    using BookIt.Data.Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class BookItDbContext : IdentityDbContext<ApplicationUser>, IBookItDbContext
    {
        public BookItDbContext()
            : base("BookIT", throwIfV1Schema: false)
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

        public static BookItDbContext Create()
        {
            return new BookItDbContext();
        }

        //TODO: ask what is this
        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}
