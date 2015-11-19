using Bookit.Data.Contracts;
using BookIt.Data.Models;
using BookIt.Services.Data.Contracts;
using BookIt.Services.Data.Contracts.master;
using BookIt.Services.Data.Services.master;

namespace BookIt.Services.Data.Services
{
    public class ServicesService : DataService<Service>, IServicesService, IDataService<Service>
    {
        private readonly IRepository<Service> data;

        public ServicesService(IRepository<Service> data)
            :base(data)
        {
        }
    }
}
