namespace BookIt.Services.Data.Services
{
    using BookIt.Data.Common.Contracts;
    using BookIt.Data.Models;
    using BookIt.Services.Data.Contracts;
    using BookIt.Services.Data.Contracts.master;
    using BookIt.Services.Data.Services.master;

    public class CommentsService : DataService<Comment>, ICommentsService, IDataService<Comment>
    {
        private readonly IRepository<Comment> data;

        public CommentsService(IRepository<Comment> data)
            :base(data)
        {
        }
    }
}
