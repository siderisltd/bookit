using System;
using System.Linq;
using System.Threading.Tasks;
using Bookit.Data.Contracts;
using BookIt.Services.Data.Contracts.master;

namespace BookIt.Services.Data.Services.master
{
    //TODO: Remove void operations!!!
    public class DataService<T> : IDataService<T> where T : class
    {
        private readonly IRepository<T> data;

        public DataService(IRepository<T> data)
        {
            this.data = data;
        }

        public IQueryable<T> All()
        {
            return this.data.All();
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

        public int SaveChanges()
        {
            return this.data.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await this.data.SaveChangesAsync();
        }

        public T GetById(object id)
        {
            return this.data.GetById(id);
        }

        public void Update(T entity)
        {
            this.data.Update(entity);
        }

        public void Delete(T entity)
        {
            this.data.Delete(entity);
        }

        public void DeleteById(object id)
        {
            this.data.DeleteById(id);
        }

        public T Attach(T entity)
        {
            return this.data.Attach(entity);
        }

        public void Detach(T entity)
        {
            this.data.Detach(entity);
        }
    }
}
