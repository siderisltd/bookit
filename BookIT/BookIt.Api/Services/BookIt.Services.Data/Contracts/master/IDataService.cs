namespace BookIt.Services.Data.Contracts.master
{
    using System.Linq;
    using System.Threading.Tasks;

    public interface IDataService<T>
    {
        IQueryable<T> All();

        T GetById(int id);

        void Add(T objectToAdd);

        Task<T> AddNewAsync(T objectToAdd);
    }
}
