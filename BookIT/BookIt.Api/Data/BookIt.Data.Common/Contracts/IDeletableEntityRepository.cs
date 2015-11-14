namespace BookIt.Data.Common.Contracts
{
    using System.Linq;

    public interface IDeletableEntityRepository<T> : IRepository<T> where T : class, IDeletableEntity
    {
        IQueryable<T> AllWithDeleted();

        void HardDelete(T entity);
    }
}