namespace BookIt.Server.DataTransferModels.Appointments.ViewModels
{
    using System;
    using BookIt.Data.Models;
    using BookIt.Server.Common.Mapping;

    public class AppointmentsViewModel : IMapFrom<Appointment>, IViewModel
    {
        public int Id { get; set; }

        public DateTime Start { get; set; }

        public DateTime? End { get; set; }

        public int LocationId { get; set; }
    }
}
