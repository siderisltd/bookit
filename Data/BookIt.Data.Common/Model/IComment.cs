namespace BookIt.Data.Common.Model
{
    public interface IComment : IAuditInfo
    {
        string Content { get; }
    }
}
