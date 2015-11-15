﻿namespace BookIt.Services.Data.Services.master
{
    using System.Linq;
    using System.Threading.Tasks;
    using BookIt.Data.Common.Contracts;
    using BookIt.Services.Data.Contracts.master;

    public class DataService<T> : IService<T> where T : class
    {
        private IRepository<T> data;

        public DataService(IRepository<T> data)
        {
            this.data = data;
        }

        public IQueryable<T> All()
        {
            return this.data.All();
        }

        public T GetById(object id)
        {
            return this.data.GetById(id);
        }

        public void Add(T objectToAdd)
        {
            this.data.Add(objectToAdd);
            this.data.SaveChanges();
        }

        public async Task<T> AddNewAsync(T objectToAdd)
        {
            this.data.Add(objectToAdd);
            await this.data.SaveChangesAsync();
            return objectToAdd;
        }
    }
}