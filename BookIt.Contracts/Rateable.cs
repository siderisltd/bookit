namespace BookIt.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Rateable : DeletableEntity, IDeletableEntity, IAuditInfo, IRateable, ICommentable
    {
        public Rateable()
        {
            this.Votes = new HashSet<IVote>();
            this.Comments = new HashSet<IComment>();
        }

        public double Rating { get; set; }

        public ICollection<IVote> Votes { get; set; }

        public ICollection<IComment> Comments { get; set; }
    }
}
