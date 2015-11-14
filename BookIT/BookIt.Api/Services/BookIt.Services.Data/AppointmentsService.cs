using BookIt.Data.Common.Contracts;

namespace BookIt.Services.Data
{
    using System;
    using Bookit.Data;
    using System.Linq;
    using System.Threading.Tasks;
    using BookIt.Data.Models;
    using BookIt.Services.Data.Contracts;

    public class AppointmentsService : IAppointmentsService
    {
        private readonly IRepository<Appointment> data;

        public AppointmentsService(IRepository<Appointment> data)
        {
            this.data = data;
        }

        public IQueryable<Appointment> All()
        {
            return this.data.All();
        }

        public IQueryable<Appointment> Get(int locationId, DateTime dateTime)
        {
            return this.data.All()
                .Where(a => a.LocationId == locationId && a.Start.Date == dateTime.Date);
        }

        public async Task<Appointment> AddNewAsync(Appointment appointment)
        {
            this.data.Add(appointment);
            await this.data.SaveChangesAsync();
            return appointment;
        }
    }
}
