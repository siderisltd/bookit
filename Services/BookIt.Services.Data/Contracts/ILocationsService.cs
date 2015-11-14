namespace BookIt.Services.Data.Contracts
{
    using System.Linq;
    using BookIt.Data.Models;

    public interface ILocationsService
    {
        IQueryable<Location> All();

        Location GetById(int businessId);
    }
}
