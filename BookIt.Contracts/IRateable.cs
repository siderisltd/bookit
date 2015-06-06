namespace BookIt.Contracts
{
    using System.Collections.Generic;
    using System.Linq;

    public interface IRateable
    {
        ICollection<IVote> Votes { set; }
    }
}
