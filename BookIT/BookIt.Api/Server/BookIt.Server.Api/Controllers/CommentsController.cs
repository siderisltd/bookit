using System;

namespace BookIt.Server.Api.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;

    [Authorize]
    public class CommentsController : ApiController
    {
        // GET: api/Comments
        public IHttpActionResult Get()
        {
            throw new NotImplementedException();
        }

        // GET: api/Comments/5
        public IHttpActionResult Get(object id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Comments
        public IHttpActionResult Post([FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Comments/5
        public IHttpActionResult Put(object id, [FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/Comments/5
        public IHttpActionResult Delete(object id)
        {
            throw new NotImplementedException();
        }
    }
}
