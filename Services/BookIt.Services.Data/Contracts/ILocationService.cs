namespace BookIt.Services.Data.Contracts
{
    using BookIt.Data.Models;
    using BookIt.Services.Common;

    public interface ILocationService: IService
    {
        Location GetById(int businessId);
    }
}
