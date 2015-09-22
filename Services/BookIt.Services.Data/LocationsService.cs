namespace BookIt.Services.Data
{
    using System;
    using System.Linq;
    using BookIt.Data;
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
    }
}
