namespace BookIt.Server.DataTransferModels.Appointments.BindingModels
{
    using System;
    using BookIt.Data.Models;
    using BookIt.Server.Common.Mapping;

    public class AppointmentsBindingModel : IMapFrom<Appointment>
    {
        public AppointmentsBindingModel()
        {
            this.CreatedOn = DateTime.Now;
        }

        public int Id { get; set; }

        public int LocationId { get; set; }

        public DateTime Start { get; set; }

        public DateTime? End { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
