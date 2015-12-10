namespace BookIt.Services.Data.Services
{
    using System;
    using System.Linq;
    using Bookit.Data.Contracts;
    using BookIt.Data.Models;
    using BookIt.Services.Data.Contracts;
    using BookIt.Services.Data.Contracts.master;
    using BookIt.Services.Data.Services.master;

    public class AppointmentsService : DataService<Appointment>, IAppointmentsService, IDataService<Appointment>
    {
        private readonly IRepository<Appointment> data;

        public AppointmentsService(IRepository<Appointment> data)
            : base(data)
        {
            this.data = data;
        }

        public IQueryable<Appointment> AllPaged(int page, int pageSize)
        {
            return this.data
                .All()
                .OrderByDescending(pr => pr.CreatedOn)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<Appointment> Get(int businessLocationId, DateTime dateTime)
        {
            return this.data.All()
                .Where(a => a.LocationId == businessLocationId && a.Start.Date == dateTime.Date);
        }

        public int GetLastPage(int pageSize)
        {
            var lastPageNumber = this.data
                                     .All()
                                     .Count();

            return lastPageNumber / pageSize;
        }
    }
}
