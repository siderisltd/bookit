using System.Collections.Generic;

namespace BookIt.Data.Models.Contracts
{
    public interface ICommentable
    {
        ICollection<IComment> Comments { get; }
    }
}
