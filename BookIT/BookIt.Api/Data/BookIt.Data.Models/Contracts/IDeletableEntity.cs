namespace BookIt.Data.Models.Contracts
{
    /// <summary>
    /// The only purpose for this interface is to allow deletion in the Generic base controller
    /// every entity that implement this empty interface will be deletable in delete request from each controller
    /// </summary>
    public interface IDeletableEntity
    {
    }
}
