using System.Threading.Tasks;

namespace BookIt.Services.Data
{
    using System.Linq;
    using Bookit.Data;
    using BookIt.Data.Models;
    using BookIt.Services.Data.Contracts;

    public class LocationsService : ILocationsService
    {
        private readonly IBookItData data;

        public LocationsService(IBookItData data)
        {
            this.data = data;
        }

        public IQueryable<Location> All()
        {
            return this.data.Locations.All();
        }

        public Location GetById(int businessId)
        {
            return this.data.Locations.GetById(businessId);
        }

        public void Add(Location objectToAdd)
        {
            throw new System.NotImplementedException();
        }

        public Task<Location> AddNewAsync(Location objectToAdd)
        {
            throw new System.NotImplementedException();
        }
    }
}
