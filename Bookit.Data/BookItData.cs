﻿namespace Bookit.Data
{
    using System;
    using System.Collections.Generic;

    using Microsoft.AspNet.Identity.EntityFramework;

    using BookIt.Contracts;
    using Bookit.Data.Repositories;
    using Bookit.Data.Repositories.Base;
    using Bookit.Data.Repositories.Contracts;
    using BookIt.Models;
    
    public class BookItData : IBookItData
    {
        private IBookItDbContext context;

        private readonly Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public BookItData()
            : this(new BookItDbContext())
        {
        }

        public BookItData(IBookItDbContext context)
        {
            this.context = context;
        }

        public IDeletableEntityRepository<Category> Categories
        {
            get
            {
                return this.GetDeletableEntityRepository<Category>();
            }
        }

        public IDeletableEntityRepository<Business> Businesses
        {
            get
            {
                return this.GetDeletableEntityRepository<Business>();
            }
        }

        public IDeletableEntityRepository<Location> Locations
        {
            get
            {
                return this.GetDeletableEntityRepository<Location>();
            }
        }

        public IDeletableEntityRepository<Address> Addresses
        {
            get
            {
                return this.GetDeletableEntityRepository<Address>();
            }
        }

        public IDeletableEntityRepository<City> Cities
        {
            get
            {
                return this.GetDeletableEntityRepository<City>();
            }
        }

        public IDeletableEntityRepository<Comment> Comments
        {
            get
            {
                return this.GetDeletableEntityRepository<Comment>();
            }
        }

        public IDeletableEntityRepository<Customer> Customers
        {
            get
            {
                return this.GetDeletableEntityRepository<Customer>();
            }
        }

        public IDeletableEntityRepository<Engagement> Engagements
        {
            get
            {
                return this.GetDeletableEntityRepository<Engagement>();
            }
        }

        public IDeletableEntityRepository<Service> Services
        {
            get
            {
                return this.GetDeletableEntityRepository<Service>();
            }
        }

        public IDeletableEntityRepository<Street> Streets
        {
            get
            {
                return this.GetDeletableEntityRepository<Street>();
            }
        }

        public IDeletableEntityRepository<Vote> Votes
        {
            get
            {
                return this.GetDeletableEntityRepository<Vote>();
            }
        }

        public IDeletableEntityRepository<WorkingUnit> WorkingUnits
        {
            get
            {
                return this.GetDeletableEntityRepository<WorkingUnit>();
            }
        }

        public IUsersRepository Users
        {
            get
            {
                return (UsersRepository)this.GetRepository<AppUser>();
            }
        }
        
        public IRepository<IdentityRole> Roles
        {
            get
            {
                return this.GetRepository<IdentityRole>();
            }
        }

        public IBookItDbContext Context
        {
            get
            {
                return this.context;
            }
        }

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
                var type = typeof(GenericRepository<T>);

                if (typeof(T).IsAssignableFrom(typeof(AppUser)))
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