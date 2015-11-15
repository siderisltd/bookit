using System;

namespace BookIt.Server.Api.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;

    [Authorize]
    public class ServicesController : ApiController
    {
        // GET: api/Services
        public IHttpActionResult Get()
        {
            throw new NotImplementedException();
        }

        // GET: api/Services/5
        public IHttpActionResult Get(object id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Services
        public IHttpActionResult Post([FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Services/5
        public IHttpActionResult Put(object id, [FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/Services/5
        public IHttpActionResult Delete(object id)
        {
            throw new NotImplementedException();
        }
    }
}
