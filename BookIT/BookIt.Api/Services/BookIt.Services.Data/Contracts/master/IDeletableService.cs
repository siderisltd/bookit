using BookIt.Data.Models.Contracts;

namespace BookIt.Services.Data.Contracts.master
{

    public interface IDeletableService<T> : IDataService<T> where T : IDeletableEntity
    {
        void Delete(T entity);

        void DeleteById(int id);
    }
}
