namespace BookIt.Server.Common.Contracts
{
    using System.Web.Http;
    using BookIt.Data.Models.Contracts;

    public interface IBookitDeleteController<TBindingModel>
    {
        IHttpActionResult Delete(object id);

        IHttpActionResult Delete(TBindingModel deletableBindingModel);
    }
}
