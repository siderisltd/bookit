﻿namespace BookIt.Services.Data.Tests.ObjectsFactory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Bookit.Data.Contracts;

    public class InMemoryRepository<T> : IRepository<T>
        where T : class
    {
        private IList<T> data;

        public InMemoryRepository()
        {
            this.data = new List<T>();
            this.AttachedEntities = new List<T>();
            this.DetachedEntities = new List<T>();
            this.UpdatedEntities = new List<T>();
        }

        public IList<T> AttachedEntities { get; set; }

        public IList<T> DetachedEntities { get; set; }

        public IList<T> UpdatedEntities { get; set; }

        public bool isDisposed { get; set; }

        public int NumberOfSavedChanges { get; set; }


        public void Add(T entity)
        {
            this.data.Add(entity);
        }

        public IQueryable<T> All()
        {
            return this.data.AsQueryable();
        }

        public T Attach(T entity)
        {
            this.AttachedEntities.Add(entity);
            return entity;
        }

        public void Delete(int id)
        {
            if (this.data.Count() == 0)
            {
                throw new InvalidOperationException("Repository data is missing!");
            }
            this.data.Remove(this.data[0]);
        }

        public void Delete(T entity)
        {
            if (!this.data.Contains(entity))
            {
                throw new InvalidOperationException("Entity to delete is missing!");
            }
            this.data.Remove(entity);
        }

        public void Detach(T entity)
        {
            this.DetachedEntities.Add(entity);
        }

        public void Dispose()
        {
            this.isDisposed = true;
        }

        public T GetById(int id)
        {
            if (this.data.Count == 0)
            {
                throw new InvalidOperationException("Searched data is missing!");
            }
            return this.data[0];
        }

        public int SaveChanges()
        {
            this.NumberOfSavedChanges += 1;
            return this.NumberOfSavedChanges;
        }

        public void Update(T entity)
        {
            this.UpdatedEntities.Add(entity);
        }

        public Task<int> SaveChangesAsync()
        {
            Task<int> saveChangesTask = Task<int>.Factory.StartNew(() =>
            {
                this.NumberOfSavedChanges += 1;
                return this.NumberOfSavedChanges;
            });

            return saveChangesTask;
        }
    }
}
