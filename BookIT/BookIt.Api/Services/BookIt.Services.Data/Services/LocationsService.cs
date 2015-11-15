namespace BookIt.Services.Data.Services
{
    using BookIt.Data.Models;
    using BookIt.Data.Common.Contracts;
    using BookIt.Services.Data.Services.master;
    using Contracts;
    using Contracts.master;

    public class LocationsService : DataService<Location>, ILocationsService, IService<Location>
    {
        private readonly IRepository<Location> data;

        public LocationsService(IRepository<Location> data)
            :base(data)
        {
        }
    }
}
