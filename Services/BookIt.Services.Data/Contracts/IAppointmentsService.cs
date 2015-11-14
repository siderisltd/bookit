namespace BookIt.Services.Data.Contracts
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using BookIt.Data.Models;

    public interface IAppointmentsService
    {
        IQueryable<Appointment> All();

        IQueryable<Appointment> Get(int businessId, DateTime dateTime);

        Task<Appointment> AddNewAsync(Appointment appointment);
    }
}
