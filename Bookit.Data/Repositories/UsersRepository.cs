namespace Bookit.Data.Repositories
{
    using System;
    using System.Linq;

    using Bookit.Data.Contracts;
    using Bookit.Data.Repositories.Base;
    using BookIt.Models;

    public class UsersRepository : GenericRepository<AppUser>, IUsersRepository
    {
        public UsersRepository(IBookItDbContext context)
            : base(context)
        {
        }

        public AppUser GetByUsername(string username)
        {
            return this.All().FirstOrDefault(x => x.UserName == username);
        }

        public AppUser GetById(string id)
        {
            return this.All().FirstOrDefault(x => x.Id == id);
        }
    }
}
