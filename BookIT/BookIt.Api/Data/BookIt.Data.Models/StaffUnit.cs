using BookIt.Data.Models.Contracts;
using BookIt.Data.Models.Model;

namespace BookIt.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class StaffUnit : Rateable, IDeletableEntity, IAuditInfo, ICommentable, IRateable
    {
        private ICollection<Service> providedServices;

        private ICollection<DateTime> schedule;

        public StaffUnit()
        {
            this.providedServices = new HashSet<Service>();
            this.schedule = new HashSet<DateTime>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Descriptoin { get; set; }

        public string EmployeeId { get; set; }

        public virtual ApplicationUser Employee { get; set; }

        public virtual ICollection<Service> ProvidedServices
        {
            get { return this.providedServices; }
            set { this.providedServices = value; }
        }

        public virtual ICollection<DateTime> Schedule
        {
            get { return this.schedule; }
            set { this.schedule = value; }
        }
    }
}
