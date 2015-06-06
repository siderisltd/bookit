namespace BookIt.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface IBusiness : ICommentable, IComment, IVote, IRateable, IAuditInfo, IDeletableEntity
    {
        ICollection<IBusinessLocation> Locations { get; set; }

        ICollection<IUnit> Units { get; set; }

        ICategory Category { get; set; }

        ICollection<IService> Services { get; set; }
    }
}
