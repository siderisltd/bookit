namespace BookIt.Services.Data.Contracts
{
    using System.Linq;

    using BookIt.Data.Models;
    using BookIt.Services.Common;

    public interface ILocationsService: IService
    {
        IQueryable<Location> All();

        Location GetById(int businessId);
    }
}
