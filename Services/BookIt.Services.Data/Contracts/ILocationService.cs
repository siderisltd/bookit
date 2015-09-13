namespace BookIt.Services.Data.Contracts
{
    using BookIt.Data.Models;
    
    public interface ILocationService
    {
        Location GetById(int businessId);
    }
}
