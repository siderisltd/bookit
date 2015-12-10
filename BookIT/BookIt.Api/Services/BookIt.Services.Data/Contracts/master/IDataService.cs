using System.Threading.Tasks;

namespace BookIt.Services.Data.Contracts.master
{
    using Bookit.Data.Contracts;

    public interface IDataService<T> : IRepository<T> where T: class
    {
        Task<T> AddNewAsync(T objectToAdd);
    }
}
