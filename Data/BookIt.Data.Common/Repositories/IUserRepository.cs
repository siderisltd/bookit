namespace BookIt.Data.Common.Repositories
{
    using Microsoft.AspNet.Identity.EntityFramework;

    public interface IUsersRepository : IRepository<IdentityUser>
    {
        IdentityUser GetByUsername(string username);

        IdentityUser GetById(string id);
    }
}
