namespace BookIt.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BookIt.Data;
    using BookIt.Data.Models;
    using BookIt.Services.Data.Contracts;
    using BookIt.Data.Common.Repositories;

    public class AppointmentService : IAppointmentService
    {
        private readonly IRepository<Appointment> appointments;

        public AppointmentService(IRepository<Appointment> appointments)
        {
            this.appointments = appointments;
        }

        public IQueryable<Appointment> Get(int businessId, DateTime dateTime)
        {
            return this.appointments.All()
                .Where(a => a.BusinessId == businessId && a.Start.Date == dateTime.Date);
        }

        public async Task<Appointment> AddNew(Appointment appointment)
        {
            this.appointments.Add(appointment);
            this.appointments.SaveChanges();
            return appointment;
        }
    }
}
