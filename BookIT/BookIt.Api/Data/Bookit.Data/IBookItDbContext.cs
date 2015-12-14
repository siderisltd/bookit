using System.Threading.Tasks;

namespace Bookit.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using BookIt.Data.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    public interface IBookItDbContext
    {
        IDbSet<Location> BusinessLocations { get; set; }

        IDbSet<Category> Categories { get; set; }

        IDbSet<Comment> Comments { get; set; }

        IDbSet<Customer> Customers { get; set; }

        IDbSet<Service> Services { get; set; }

        IDbSet<Appointment> Appointments { get; set; }

        IDbSet<StaffUnit> Staff { get; set; }

        IDbSet<Vote> Votes { get; set; }

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        int SaveChanges();

        Task<int> SaveChangesAsync();

        void Dispose();
    }
}
