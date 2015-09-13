namespace BookIt.Services.Data.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BookIt.Data.Models;
    using BookIt.Services.Common;

    public interface IAppointmentService: IService
    {
        IQueryable<Appointment> Get(int businessId, DateTime dateTime);

        Task<Appointment> AddNew(Appointment appointment);
    }
}
