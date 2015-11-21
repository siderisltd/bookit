using System.Collections.Generic;
using BookIt.Data.Models.Contracts;

namespace BookIt.Data.Models.Model
{
    public abstract class Rateable : DeletableEntity, IDeletableEntity, IAuditInfo, IRateable, ICommentable
    {
        private ICollection<IVote> votes;
        private ICollection<IComment> comments;

        protected Rateable()
        {
            this.votes = new HashSet<IVote>();
            this.comments = new HashSet<IComment>();
        }

        public double Rating { get; set; }

        public ICollection<IVote> Votes
        {
            get { return this.votes; }
            set { this.votes = value; }
        }

        public ICollection<IComment> Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }
    }
}
