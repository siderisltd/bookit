namespace BookIt.Data.Models.Contracts
{
    public interface IComment : IBookItEntity
    {
        string Content { get; }
    }
}
