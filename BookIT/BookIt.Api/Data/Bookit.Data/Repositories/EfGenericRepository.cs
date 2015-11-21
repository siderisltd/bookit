using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using Bookit.Data.Contracts;

namespace Bookit.Data.Repositories
{
    public class EfGenericRepository<T> : IRepository<T> where T : class
    {
        public EfGenericRepository(IBookItDbContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context", "An instance of DbContext is required to use this repository.");
            }

            this.Context = context;
            this.DbSet = this.Context.Set<T>();
        }

        public IBookItDbContext Context { get; set; }

        public IDbSet<T> DbSet { get; set; }

        public virtual IQueryable<T> All()
        {
            return this.DbSet.AsQueryable();
        }

        public virtual T GetById(int id)
        {
            var dbObject = this.DbSet.Find(id);
            return dbObject;
        }

        public virtual void Add(T entity)
        {
            DbEntityEntry entry = this.Context.Entry(entity);
            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                this.DbSet.Add(entity);
            }
        }

        public virtual void Update(T entity)
        {
            DbEntityEntry entry = this.Context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.DbSet.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }
        
        //public virtual void Delete(T entity)
        //{
        //    DbEntityEntry entry = this.Context.Entry(entity);
        //    if (entry.State != EntityState.Deleted)
        //    {
        //        entry.State = EntityState.Deleted;
        //    }
        //    else
        //    {
        //        this.DbSet.Attach(entity);
        //        this.DbSet.Remove(entity);
        //    }
        //}

        //public virtual void Delete(int id)
        //{
        //    var entity = this.GetById(id);

        //    if (entity != null)
        //    {
        //        this.Delete(entity);
        //    }
        //}

        public T Attach(T entity)
        {
            return this.Context.Set<T>().Attach(entity);
        }

        public virtual void Detach(T entity)
        {
            DbEntityEntry entry = this.Context.Entry(entity);

            entry.State = EntityState.Detached;
        }

        private int GetPrimaryKey(DbEntityEntry entry)
        {
            var myObject = entry.Entity;

            var property = myObject
                .GetType()
                .GetProperties()
                .FirstOrDefault(prop => Attribute.IsDefined(prop, typeof(KeyAttribute)));

            return (int)property.GetValue(myObject, null);
        }

        public int SaveChanges()
        {
            return this.Context.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return this.Context.SaveChangesAsync();
        }

        public void Dispose()
        {
            this.Context.Dispose();
        }
    }
}
