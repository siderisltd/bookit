namespace BookIt.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Bookit.Data;
    using BookIt.Data.Models;
    using BookIt.Services.Data.Contracts;

    public class AppointmentService : IAppointmentService
    {
        private readonly IBookItData data;

        public AppointmentService(IBookItData data)
        {
            this.data = data;
        }

        public IQueryable<Appointment> Get(int businessId, DateTime dateTime)
        {
            return this.data.Appointments.All()
                .Where(a => a.BusinessId == businessId && a.Start.Date == dateTime.Date);
        }

        public async Task<Appointment> AddNew(Appointment appointment)
        {
            this.data.Appointments.Add(appointment);
            this.data.SaveChanges();
            return appointment;
        }
    }
}
