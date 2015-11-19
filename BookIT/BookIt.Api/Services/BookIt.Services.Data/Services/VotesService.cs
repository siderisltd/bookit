using Bookit.Data.Contracts;
using BookIt.Data.Models;
using BookIt.Services.Data.Contracts;
using BookIt.Services.Data.Contracts.master;
using BookIt.Services.Data.Services.master;

namespace BookIt.Services.Data.Services
{
    public class VotesService : DataService<Vote>, IVotesService, IDataService<Vote>
    {
        private readonly IRepository<Vote> data;

        public VotesService(IRepository<Vote> data)
            :base(data)
        {
        }
    }
}
