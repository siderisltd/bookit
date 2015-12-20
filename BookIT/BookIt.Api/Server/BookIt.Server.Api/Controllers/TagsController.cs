namespace BookIt.Server.Api.Controllers
{
    using System;
    using System.Web.Http;
    using BookIt.Services.Data.Contracts;

    /// <summary>
    /// NOT IMPLEMENTED
    /// </summary>
    [Authorize]
    [RoutePrefix("api/Tags")]
    public class TagsController : ApiController
    {
        private readonly ITagsService tagsService;

        public TagsController(ITagsService tagsService)
        {
            this.tagsService = tagsService;
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
