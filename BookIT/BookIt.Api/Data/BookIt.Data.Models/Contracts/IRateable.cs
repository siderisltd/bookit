using System.Collections.Generic;

namespace BookIt.Data.Models.Contracts
{
    public interface IRateable
    {
        double Rating { get; }

        ICollection<IVote> Votes { set; }
    }
}
