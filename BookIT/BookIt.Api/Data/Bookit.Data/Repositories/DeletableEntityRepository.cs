﻿using System;
using System.Data.Entity;
using System.Linq;
using Bookit.Data.Contracts;
using BookIt.Data.Models.Contracts;

namespace Bookit.Data.Repositories
{
    public class DeletableEntityRepository<T> : EfGenericRepository<T>, IDeletableEntityRepository<T> where T : class, IDeletableEntity
    {
        //TODO: check
        public DeletableEntityRepository(IBookItDbContext context)
            : base(context)
        {
        }

        public override IQueryable<T> All()
        {
            return base.All().Where(x => !x.IsDeleted);
        }

        public IQueryable<T> AllWithDeleted()
        {
            return base.All();
        }

        public override void Delete(T entity)
        {
            entity.IsDeleted = true;
            entity.DeletedOn = DateTime.Now;
            var entry = this.Context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.DbSet.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }

        public void HardDelete(T entity)
        {
            base.Delete(entity);
        }
    }
}
