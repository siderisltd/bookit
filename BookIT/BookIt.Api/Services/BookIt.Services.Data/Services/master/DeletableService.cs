using Bookit.Data.Contracts;
using BookIt.Data.Models.Contracts;
using BookIt.Services.Data.Contracts.master;

namespace BookIt.Services.Data.Services.master
{
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

        public void DeleteById(int id)
        {
            this.data.Delete(id);
        }

    }
}
