namespace BookIt.Data.Common.Repositories
{
    using System.Linq;

    using BookIt.Data.Common.Model;

    public interface IDeletableEntityRepository<T> : IRepository<T> where T : class, IDeletableEntity
    {
        IQueryable<T> AllWithDeleted();

        void HardDelete(T entity);
    }
}