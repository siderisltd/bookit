namespace BookIt.Services.Data.Services
{
    using BookIt.Data.Common.Contracts;
    using BookIt.Data.Models;
    using BookIt.Services.Data.Contracts;
    using BookIt.Services.Data.Contracts.master;
    using BookIt.Services.Data.Services.master;

    public class TagsService : DataService<Tag>, ITagsService, IService<Tag>
    {
        private readonly IRepository<Tag> data;

        public TagsService(IRepository<Tag> data)
            :base(data)
        {
        }
    }
}
