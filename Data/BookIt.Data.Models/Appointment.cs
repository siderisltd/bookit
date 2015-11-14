namespace BookIt.Data.Models
{
    using System;
    using BookIt.Data.Common.Model;
    using BookIt.Data.Common.Contracts;

    public class Appointment : DeletableEntity, IDeletableEntity, IAuditInfo
    {
        public int Id { get; set; }
        
        public DateTime Start { get; set; }

        public DateTime? End { get; set; }

        public int LocationId { get; set; }

        public virtual Location Location { get; set; }
    }
}
