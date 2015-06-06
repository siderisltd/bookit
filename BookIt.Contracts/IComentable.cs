namespace BookIt.Contracts
{
    using System.Collections.Generic;

    public interface ICommentable
    {
        double Rating { get; }
        ICollection<IComment> Comments { get; }
    }
}
