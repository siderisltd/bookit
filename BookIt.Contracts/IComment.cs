namespace BookIt.Contracts
{
    using System;

    public interface IComment
    {
        // TODO: think what else needs to be added
        string Content { get; }
        DateTime Date { get; }
    }
}
