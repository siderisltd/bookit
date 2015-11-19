using Bookit.Data.Contracts;
using BookIt.Data.Models;
using BookIt.Services.Data.Contracts;
using BookIt.Services.Data.Contracts.master;
using BookIt.Services.Data.Services.master;

namespace BookIt.Services.Data.Services
{
    public class BusinessesService : DataService<Business>, IBusinessesService, IDataService<Business>
    {
        private readonly IRepository<Business> data;

        public BusinessesService(IRepository<Business> data)
            : base(data)
        {
        }
    }
}
