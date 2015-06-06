namespace BookIt.Models
{
    using BookIt.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Customer : BookitInfo, IComment, ICommentable, IRateable ,IVote , IDeletableEntity
    {
        public int ID { get; set; }

        public Customer()
        {
            this.Comments = new HashSet<IComment>();
            this.Subscriptions = new HashSet<Subscription>();
            this.Votes = new HashSet<IVote>();
        }

        public int Value
        {
            get { throw new NotImplementedException(); }
        }

        public double Rating
        {
            get { throw new NotImplementedException(); }
        }

        public string Content
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsDeleted
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public DateTime? DeletedOn
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public virtual ICollection<IComment> Comments
        {
            get { throw new NotImplementedException();}
            private set { }
        }

        public virtual IEnumerable<Subscription> Subscriptions { get; set; }

        public ICollection<IVote> Votes
        {
            set { throw new NotImplementedException(); }
        }
    }
}
