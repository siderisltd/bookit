namespace BookIt.Server.Api.Controllers
{
    using System;
    using System.Web.Http;
    using BookIt.Services.Data.Contracts;

    /// <summary>
    /// NOT IMPLEMENTED
    /// </summary>
    [Authorize]
    [RoutePrefix("api/Comments")]
    public class CommentsController : ApiController
    {
        private readonly ICommentsService commentsService;

        public CommentsController(ICommentsService commentsService)
        {
            this.commentsService = commentsService;
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
