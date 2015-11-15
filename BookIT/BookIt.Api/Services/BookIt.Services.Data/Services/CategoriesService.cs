namespace BookIt.Services.Data.Services
{
    using BookIt.Data.Models;
    using BookIt.Services.Data.Contracts;
    using BookIt.Services.Data.Contracts.master;
    using BookIt.Services.Data.Services.master;
    using BookIt.Data.Common.Contracts;

    public class CategoriesService : DataService<Category>, ICategoriesService, IDataService<Category>
    {
        private readonly IRepository<Category> data;

        public CategoriesService(IRepository<Category> data)
            :base(data)
        {
        }
    }
}
