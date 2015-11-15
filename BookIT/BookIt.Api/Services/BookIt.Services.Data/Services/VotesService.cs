namespace BookIt.Services.Data.Services
{
    using BookIt.Data.Models;
    using BookIt.Services.Data.Contracts;
    using BookIt.Services.Data.Contracts.master;
    using BookIt.Services.Data.Services.master;
    using BookIt.Data.Common.Contracts;

    public class VotesService : DataService<Vote>, IVotesService, IService<Vote>
    {
        private readonly IRepository<Vote> data;

        public VotesService(IRepository<Vote> data)
            :base(data)
        {
        }
    }
}
