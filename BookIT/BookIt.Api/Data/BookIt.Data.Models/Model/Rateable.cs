using System.Collections.Generic;
using BookIt.Data.Models.Contracts;

namespace BookIt.Data.Models.Model
{
    public abstract class Rateable : DeletableEntity, IDeletableEntity, IAuditInfo, IRateable, ICommentable
    {
        protected Rateable()
        {
            this.Votes = new HashSet<IVote>();
            this.Comments = new HashSet<IComment>();
        }

        public double Rating { get; set; }

        public ICollection<IVote> Votes { get; set; }

        public ICollection<IComment> Comments { get; set; }
    }
}
