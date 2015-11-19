namespace BookIt.Services.Data.Services
{
    using System;
    using System.Linq;
    using Bookit.Data.Contracts;
    using BookIt.Data.Models;
    using BookIt.Services.Data.Contracts;
    using BookIt.Services.Data.Contracts.master;
    using BookIt.Services.Data.Services.master;

    public class AppointmentsService : DeletableService<Appointment>, IAppointmentsService, IDataService<Appointment>
    {
        private readonly IRepository<Appointment> data;

        public AppointmentsService(IRepository<Appointment> data)
            :base(data)
        {
        }

        public IQueryable<Appointment> Get(int locationId, DateTime dateTime)
        {
            return this.data.All()
                .Where(a => a.LocationId == locationId && a.Start.Date == dateTime.Date);
        }
    }
}
