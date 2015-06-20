namespace BookIt.Models
{
    using System.Collections.Generic;
    using BookIt.Contracts;

    public class Customer : Rateable, IDeletableEntity, IAuditInfo, ICommentable, IRateable
    {
        public Customer()
        {
            this.Subscriptions = new HashSet<Engagement>();
        }

        public int ID { get; set; }

        public string UserID { get; set; }

        public virtual AppUser User { get; set; }

        public virtual IEnumerable<Engagement> Subscriptions { get; set; }
    }
}
