namespace BookIt.Services.Data
{
    using System.Linq;
    using Bookit.Data;
    using BookIt.Data.Models;
    using BookIt.Data.Common.Contracts;
    using BookIt.Services.Data.Contracts;
    using System;

    public class LocationsService : ILocationsService
    {
        private readonly IRepository<Location> data;

        public LocationsService(IRepository<Location> data)
        {
            this.data = data;
        }

        public void Add(Location location)
        {
            this.data.Add(location);
        }

        public IQueryable<Location> All()
        {
            return this.data.All();
        }

        public Location GetById(int businessId)
        {
            return this.data.GetById(businessId);
        }
    }
}
