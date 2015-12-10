namespace BookIt.Server.Api.Controllers
{
    using System;
    using BookIt.Services.Data.Contracts;
    using System.Web.Http;

    [Authorize]
    [RoutePrefix("api/StaffUnits")]
    public class StaffUnitsController : ApiController
    {
        private readonly IStaffUnitsService staffUnitsService;

        public StaffUnitsController(IStaffUnitsService staffUnitsService)
        {
            this.staffUnitsService = staffUnitsService;
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
