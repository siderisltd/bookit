namespace BookIt.Services.Data.Services
{
    using System;
    using System.Linq;
    using BookIt.Services.Data.Services.master;
    using BookIt.Data.Models;
    using BookIt.Services.Data.Contracts;
    using BookIt.Data.Common.Contracts;
    using BookIt.Services.Data.Contracts.master;

    public class AppointmentsService : DataService<Appointment>, IAppointmentsService, IService<Appointment>
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
