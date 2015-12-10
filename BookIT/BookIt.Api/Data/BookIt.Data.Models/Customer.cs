using BookIt.Data.Models.Contracts;
using BookIt.Data.Models.Model;

namespace BookIt.Data.Models
{
    using System.Collections.Generic;

    public class Customer : Rateable, IDeletableEntity, IBookItEntity, ICommentable, IRateable
    {
        private ICollection<Appointment> subscriptions;

        public Customer()
        {
            this.subscriptions = new HashSet<Appointment>();
        }

        //public int Id { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Appointment> Subscriptions
        {
            get { return this.subscriptions; }
            set { this.subscriptions = value; }
        }
    }
}
