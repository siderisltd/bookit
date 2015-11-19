namespace BookIt.Data.Models.Contracts
{
    public interface IComment : IAuditInfo
    {
        string Content { get; }
    }
}
