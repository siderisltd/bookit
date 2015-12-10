namespace BookIt.Server.Common.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Http;
    using BookIt.Data.Models.Contracts;
    using BookIt.Server.Common.Mapping;

    public interface IBookitCreateController<TBindingModel>
    {
        Task<IHttpActionResult> Post([FromBody] TBindingModel bindingModel);

        Task<IHttpActionResult> Post([FromBody] IEnumerable<TBindingModel> bindingModelsToAdd);
    }
}
