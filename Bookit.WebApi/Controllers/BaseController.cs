namespace Bookit.WebApi.Controllers
{
    using System.Web.Http;

    using Bookit.Data;

    public class BaseController : ApiController
    {
        public BaseController(IBookItData data)
        {
            this.Data = data;
        }

        public IBookItData Data { get; set; }
    }
}
