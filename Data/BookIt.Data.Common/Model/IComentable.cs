namespace BookIt.Data.Common.Model
{
    using System.Collections.Generic;

    public interface ICommentable
    {
        ICollection<IComment> Comments { get; }
    }
}
