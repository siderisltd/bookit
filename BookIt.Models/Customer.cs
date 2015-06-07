namespace BookIt.Models
{
    using BookIt.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
