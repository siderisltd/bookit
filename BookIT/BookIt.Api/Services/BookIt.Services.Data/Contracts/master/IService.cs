namespace BookIt.Services.Data.Contracts.master
{
    using System.Linq;
    using System.Threading.Tasks;

    public interface IService<T>
    {
        IQueryable<T> All();

        T GetById(object id);

        void Add(T objectToAdd);

        Task<T> AddNewAsync(T objectToAdd);
    }
}
