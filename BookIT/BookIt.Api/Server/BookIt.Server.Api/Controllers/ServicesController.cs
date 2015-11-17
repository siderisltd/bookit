namespace BookIt.Server.Api.Controllers
{
    using System;
    using System.Web.Http;
    using BookIt.Services.Data.Contracts;

    [Authorize]
    [RoutePrefix("bookitApi/Services")]
    public class ServicesController : ApiController
    {
        private readonly IServicesService servicesService;

        public ServicesController(IServicesService servicesService)
        {
            this.servicesService = servicesService;
        }


        public IHttpActionResult Get()
        {
            throw new NotImplementedException();
        }

        public IHttpActionResult Get(int id)
        {
            throw new NotImplementedException();
        }

        public IHttpActionResult Post([FromBody]string value)
        {
            throw new NotImplementedException();
        }
        
        public IHttpActionResult Put(int id, [FromBody]string value)
        {
            throw new NotImplementedException();
        }

        public IHttpActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
