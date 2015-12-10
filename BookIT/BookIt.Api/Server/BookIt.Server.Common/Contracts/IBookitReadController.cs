namespace BookIt.Server.Common.Contracts
{
    using System.Threading.Tasks;
    using System.Web.Http;

    public interface IBookitReadController
    {
        Task<IHttpActionResult> Get();

        Task<IHttpActionResult> Get(int id);
    }
}
