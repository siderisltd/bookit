using System;

namespace BookIt.Server.Api.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;

    [Authorize]
    public class StaffUnitsController : ApiController
    {
        // GET: api/StaffUnits
        public IHttpActionResult Get()
        {
            throw new NotImplementedException();
        }

        // GET: api/StaffUnits/5
        public IHttpActionResult Get(object id)
        {
            throw new NotImplementedException();
        }

        // POST: api/StaffUnits
        public IHttpActionResult Post([FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // PUT: api/StaffUnits/5
        public IHttpActionResult Put(object id, [FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/StaffUnits/5
        public IHttpActionResult Delete(object id)
        {
            throw new NotImplementedException();
        }
    }
}
