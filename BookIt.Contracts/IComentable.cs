namespace BookIt.Contracts
{
    using System.Collections.Generic;

    public interface ICommentable
    {
        ICollection<IComment> Comments { get; }
    }
}
