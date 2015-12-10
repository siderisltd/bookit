namespace BookIt.Server.Common.Contracts
{
    using System.Threading.Tasks;
    using System.Web.Http;
    using BookIt.Data.Models.Contracts;
    using BookIt.Server.Common.Mapping;

    public interface IBookitUpdateController<TBindingModel>
    {
        Task<IHttpActionResult> Put(int id, [FromBody] TBindingModel updatableBindingModel);
    }
}
