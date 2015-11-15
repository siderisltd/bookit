namespace BookIt.Services.Data.Services.master
{
    using System;
    using BookIt.Data.Common.Contracts;
    using BookIt.Services.Data.Contracts.master;

    public class DeletableService<T> : DataService<T>, IDeletableService<T> where T : class , IDeletableEntity
    {
        private readonly IRepository<T> data;

        public DeletableService(IRepository<T> data)
            : base(data)
        {
        }
        public void Delete(T entity)
        {
            this.data.Delete(entity);
        }

        public void DeleteById(object id)
        {
            this.data.Delete(id);
        }

    }
}
