namespace Bookit.Data
{
    using System;
    using System.Collections.Generic;
    using BookIt.Data.Common.Contracts;
    using BookIt.Data.Common.Repositories;
    using BookIt.Data.Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class BookItData : IBookItData
    {
        private readonly IBookItDbContext context;

        private readonly IDictionary<Type, object> repositories;

        public BookItData(IBookItDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IDeletableEntityRepository<Category> Categories => this.GetDeletableEntityRepository<Category>();

        public IDeletableEntityRepository<Location> Businesses => this.GetDeletableEntityRepository<Location>();

        public IDeletableEntityRepository<Location> Locations => this.GetDeletableEntityRepository<Location>();

        public IDeletableEntityRepository<Comment> Comments => this.GetDeletableEntityRepository<Comment>();

        public IDeletableEntityRepository<Customer> Customers => this.GetDeletableEntityRepository<Customer>();

        public IDeletableEntityRepository<Appointment> Appointments => this.GetDeletableEntityRepository<Appointment>();

        public IDeletableEntityRepository<Service> Services => this.GetDeletableEntityRepository<Service>();

        public IDeletableEntityRepository<Vote> Votes => this.GetDeletableEntityRepository<Vote>();

        public IDeletableEntityRepository<StaffUnit> StaffUnits => this.GetDeletableEntityRepository<StaffUnit>();

        public IUsersRepository Users => (UsersRepository)this.GetRepository<ApplicationUser>();

        public IRepository<IdentityRole> Roles => this.GetRepository<IdentityRole>();
   
        public IBookItDbContext Context => this.context;

        /// <summary>
        /// Saves all changes made in this context to the underlying database.
        /// </summary>
        /// <returns>
        /// The number of objects written to the underlying database.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">Thrown if the context has been disposed.</exception>
        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.context != null)
                {
                    this.context.Dispose();
                }
            }
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(EfGenericRepository<T>);

                if (typeof(T).IsAssignableFrom(typeof(ApplicationUser)))
                {
                    type = typeof(UsersRepository);
                }

                this.repositories.Add(typeof(T), Activator.CreateInstance(type, this.context));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }

        private IDeletableEntityRepository<T> GetDeletableEntityRepository<T>() where T : class, IDeletableEntity
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(DeletableEntityRepository<T>);
                this.repositories.Add(typeof(T), Activator.CreateInstance(type, this.context));
            }

            return (IDeletableEntityRepository<T>)this.repositories[typeof(T)];
        }
    }
}
