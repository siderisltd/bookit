namespace BookIt.Services.Data.Services
{
    using BookIt.Data.Models;
    using BookIt.Data.Common.Contracts;
    using BookIt.Services.Data.Contracts;
    using BookIt.Services.Data.Contracts.master;
    using BookIt.Services.Data.Services.master;

    public class ServicesService : DataService<Service>, IServicesService, IService<Service>
    {
        private readonly IRepository<Service> data;

        public ServicesService(IRepository<Service> data)
            :base(data)
        {
        }
    }
}
