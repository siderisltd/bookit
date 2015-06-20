namespace Bookit.Data.Contracts
{
    using BookIt.Contracts;
    using BookIt.Models;

    public interface IUsersRepository : IRepository<AppUser>
    {
        AppUser GetByUsername(string username);

        AppUser GetById(string id);
    }
}
