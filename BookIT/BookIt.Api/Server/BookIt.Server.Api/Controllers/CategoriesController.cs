namespace BookIt.Server.Api.Controllers
{
    using System;
    using System.Web.Http;
    using BookIt.Services.Data.Contracts;

    [Authorize]
    [RoutePrefix("bookitApi/Categories")]
    public class CategoriesController : ApiController
    {
        private readonly ICategoriesService categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
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
