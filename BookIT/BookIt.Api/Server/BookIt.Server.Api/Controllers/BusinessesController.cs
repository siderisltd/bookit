namespace BookIt.Server.Api.Controllers
{
    using System;
    using BookIt.Services.Data.Contracts;
    using System.Web.Http;

    /// <summary>
    /// NOT IMPLEMENTED
    /// </summary>
    [Authorize]
    [RoutePrefix("api/Businesses")]
    public class BusinessesController : ApiController
    {
        private readonly IBusinessesService businessesService;

        public BusinessesController(IBusinessesService businessesService)
        {
            this.businessesService = businessesService;
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
