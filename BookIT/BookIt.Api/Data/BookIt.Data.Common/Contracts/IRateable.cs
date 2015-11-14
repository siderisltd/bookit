namespace BookIt.Data.Common.Contracts
{
    using System.Collections.Generic;

    public interface IRateable
    {
        double Rating { get; }

        ICollection<IVote> Votes { set; }
    }
}
