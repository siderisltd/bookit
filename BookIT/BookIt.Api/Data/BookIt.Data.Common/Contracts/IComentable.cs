namespace BookIt.Data.Common.Contracts
{
    using System.Collections.Generic;

    public interface ICommentable
    {
        ICollection<IComment> Comments { get; }
    }
}
