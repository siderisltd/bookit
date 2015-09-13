namespace BookIt.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using BookIt.Data.Common.Model;

    public class Appointment : DeletableEntity, IDeletableEntity, IAuditInfo
    {
        public int Id { get; set; }
        
        public DateTime Start { get; set; }

        public DateTime? End { get; set; }

        public int BusinessId { get; set; }

        public virtual Location Business { get; set; }
    }
}
