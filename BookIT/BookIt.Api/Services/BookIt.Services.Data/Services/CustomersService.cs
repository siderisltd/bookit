using Bookit.Data.Contracts;
using BookIt.Data.Models;
using BookIt.Services.Data.Contracts;
using BookIt.Services.Data.Contracts.master;
using BookIt.Services.Data.Services.master;

namespace BookIt.Services.Data.Services
{
    public class CustomersService : DataService<Customer>, ICustomersService, IDataService<Customer>
    {
        private readonly IRepository<Customer> data;

        public CustomersService(IRepository<Customer> data)
            :base(data)
        {
        }
    }
}
