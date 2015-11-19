using Bookit.Data.Contracts;
using BookIt.Data.Models;
using BookIt.Services.Data.Contracts;
using BookIt.Services.Data.Contracts.master;
using BookIt.Services.Data.Services.master;

namespace BookIt.Services.Data.Services
{
    public class TagsService : DataService<Tag>, ITagsService, IDataService<Tag>
    {
        private readonly IRepository<Tag> data;

        public TagsService(IRepository<Tag> data)
            :base(data)
        {
        }
    }
}
