using System.Linq;
using BookIt.Data.Models.Contracts;

namespace Bookit.Data.Contracts
{
    public interface IDeletableEntityRepository<T> : IRepository<T> where T : class, IDeletableEntity
    {
        IQueryable<T> AllWithDeleted();

        void Delete(T entity);

        void Delete(int id);

        void HardDelete(T entity);
    }
}