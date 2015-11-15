using System;

namespace BookIt.Server.Api.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;

    [Authorize]
    public class TagsController : ApiController
    {
        // GET: api/Tags
        public IHttpActionResult Get()
        {
            throw new NotImplementedException();
        }

        // GET: api/Tags/5
        public IHttpActionResult Get(object id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Tags
        public IHttpActionResult Post([FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Tags/5
        public IHttpActionResult Put(object id, [FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/Tags/5
        public IHttpActionResult Delete(object id)
        {
            throw new NotImplementedException();
        }
    }
}
