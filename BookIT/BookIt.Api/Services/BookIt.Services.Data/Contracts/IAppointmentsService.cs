namespace BookIt.Services.Data.Contracts
{
    using System;
    using System.Linq;
    using BookIt.Data.Models;
    using BookIt.Services.Data.Contracts.master;

    public interface IAppointmentsService : IDataService<Appointment>
    {
        IQueryable<Appointment> Get(int businessLocationId, DateTime dateTime);

        IQueryable<Appointment> AllPaged(int page, int pageSize);

        int GetLastPage(int pageSize);
    }
}
