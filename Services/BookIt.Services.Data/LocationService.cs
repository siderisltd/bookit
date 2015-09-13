namespace BookIt.Services.Data
{
    using System;

    using BookIt.Data;
    using BookIt.Data.Models;
    using BookIt.Services.Data.Contracts;

    public class LocationService : ILocationService
    {
        private readonly IBookItData data;

        public LocationService(IBookItData data)
        {
            this.data = data;
        }

        public Location GetById(int businessId)
        {
            return this.data.Locations.GetById(businessId);
        }
    }
}
