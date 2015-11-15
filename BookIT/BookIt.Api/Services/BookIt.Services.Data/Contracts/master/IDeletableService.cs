namespace BookIt.Services.Data.Contracts.master
{
    using BookIt.Data.Common.Contracts;

    public interface IDeletableService<T> : IDataService<T> where T : IDeletableEntity
    {
        void Delete(T entity);

        void DeleteById(object id);
    }
}
