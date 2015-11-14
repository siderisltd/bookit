namespace BookIt.Data.Common.Repositories
{
    using System.Linq;
    using System.Data.Entity;
    using BookIt.Data.Common.Contracts;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class UsersRepository : EfGenericRepository<IdentityUser>, IUsersRepository
    {
        public UsersRepository(DbContext context)
            : base(context)
        {
        }

        public IdentityUser GetByUsername(string username)
        {
            return this.All().FirstOrDefault(x => x.UserName == username);
        }

        public IdentityUser GetById(string id)
        {
            return this.All().FirstOrDefault(x => x.Id == id);
        }
    }
}
