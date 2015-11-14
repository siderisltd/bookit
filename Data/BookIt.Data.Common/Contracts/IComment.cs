namespace BookIt.Data.Common.Contracts
{
    public interface IComment : IAuditInfo
    {
        string Content { get; }
    }
}
