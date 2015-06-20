namespace BookIt.Models
{
    using System;
    using System.Collections.Generic;
    using BookIt.Contracts;

    public class WorkingUnit : Rateable, IDeletableEntity, IAuditInfo, ICommentable, IRateable
    {
        public WorkingUnit()
            : base()
        {
            this.ServicesProvided = new HashSet<Service>();
            this.Schedule = new HashSet<DateTime>();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public string Descriptoin { get; set; }

        public string EmployeeID { get; set; }

        public virtual AppUser Employee { get; set; }

        public virtual ICollection<Service> ServicesProvided { get; set; }

        public virtual ICollection<DateTime> Schedule { get; set; }
    }
}
