using Bookit.Data.Contracts;
using BookIt.Data.Models.Contracts;
using BookIt.Services.Data.Contracts.master;

namespace BookIt.Services.Data.Services.master
{
    public class DeletableService<T> : DataService<T>, IDeletableService<T> where T : class , IDeletableEntity
    {
        private readonly IDeletableEntityRepository<T> data;

        public DeletableService(IDeletableEntityRepository<T> data) 
            : base(data)
        {
            this.data = data;
        }

        public void Delete(T entity)
        {
            this.data.Delete(entity);
        }

        public void Delete(int id)
        {
            this.data.Delete(id);
        }

    }
}
