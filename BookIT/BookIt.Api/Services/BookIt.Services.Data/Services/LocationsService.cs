using Bookit.Data.Contracts;
using BookIt.Data.Models;
using BookIt.Services.Data.Contracts;
using BookIt.Services.Data.Contracts.master;
using BookIt.Services.Data.Services.master;

namespace BookIt.Services.Data.Services
{
    public class LocationsService : DataService<Location>, ILocationsService, IDataService<Location>
    {
        private readonly IRepository<Location> data;

        public LocationsService(IRepository<Location> data)
            :base(data)
        {
        }
    }
}
