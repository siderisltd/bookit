namespace BookIt.Services.Data.Services
{
    using BookIt.Services.Data.Contracts;
    using BookIt.Services.Data.Contracts.master;
    using BookIt.Data.Common.Contracts;
    using BookIt.Data.Models;
    using BookIt.Services.Data.Services.master;

    public class BusinessesService : DataService<Business>, IBusinessesService, IService<Business>
    {
        private readonly IRepository<Business> data;

        public BusinessesService(IRepository<Business> data)
            : base(data)
        {
        }
    }
}
