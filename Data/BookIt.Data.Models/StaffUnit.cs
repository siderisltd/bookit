namespace BookIt.Data.Models
{
    using System;
    using System.Collections.Generic;

    using BookIt.Data.Common.Model;

    public class StaffUnit : Rateable, IDeletableEntity, IAuditInfo, ICommentable, IRateable
    {
        public StaffUnit()
            : base()
        {
            this.ServicesProvIded = new HashSet<Service>();
            this.Schedule = new HashSet<DateTime>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Descriptoin { get; set; }

        public string EmployeeId { get; set; }

        public virtual ApplicationUser Employee { get; set; }

        public virtual ICollection<Service> ServicesProvIded { get; set; }

        public virtual ICollection<DateTime> Schedule { get; set; }
    }
}
