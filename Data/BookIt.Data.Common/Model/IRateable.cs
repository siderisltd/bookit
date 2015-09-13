namespace BookIt.Data.Common.Model
{
    using System.Collections.Generic;
    using System.Linq;

    public interface IRateable
    {
        double Rating { get; }

        ICollection<IVote> Votes { set; }
    }
}
