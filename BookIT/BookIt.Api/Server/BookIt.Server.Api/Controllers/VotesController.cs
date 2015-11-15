using System;

namespace BookIt.Server.Api.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;

    [Authorize]
    public class VotesController : ApiController
    {
        // GET: api/Votes
        public IHttpActionResult Get()
        {
            throw new NotImplementedException();
        }

        // GET: api/Votes/5
        public IHttpActionResult Get(object id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Votes
        public IHttpActionResult Post([FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Votes/5
        public IHttpActionResult Put(object id, [FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/Votes/5
        public IHttpActionResult Delete(object id)
        {
            throw new NotImplementedException();
        }
    }
}
