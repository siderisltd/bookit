using BookIt.Data.Models.Contracts;
using BookIt.Data.Models.Model;

namespace BookIt.Data.Models
{
    using System;

    public class Appointment : DeletableEntity, IDeletableEntity, IAuditInfo
    {
        public int Id { get; set; }
        
        public DateTime Start { get; set; }

        public DateTime? End { get; set; }

        public int LocationId { get; set; }

        public virtual Location Location { get; set; }
    }
}
