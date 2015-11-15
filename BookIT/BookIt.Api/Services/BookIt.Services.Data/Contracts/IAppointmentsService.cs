namespace BookIt.Services.Data.Contracts
{
    using System;
    using System.Linq;
    using BookIt.Data.Models;
    using BookIt.Services.Data.Contracts.master;

    public interface IAppointmentsService : IService<Appointment>
    {
        IQueryable<Appointment> Get(int businessId, DateTime dateTime);
    }
}
