namespace BookIt.Data.Models
{
    using System.Collections.Generic;

    using BookIt.Data.Common.Model;

    public class Customer : Rateable, IDeletableEntity, IAuditInfo, ICommentable, IRateable
    {
        public Customer()
        {
            this.Subscriptions = new HashSet<Appointment>();
        }

        public int Id { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual IEnumerable<Appointment> Subscriptions { get; set; }
    }
}
