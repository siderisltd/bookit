using System;
using BookIt.Data.Models;
using BookIt.Services.Data;
using BookIt.Services.Data.Contracts;

namespace BookIt.Server.Api.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;

    public class ValuesController : ApiController
    {
        private IAppointmentsService appointmentsService;

        public ValuesController(IAppointmentsService appointmentsService)
        {
            this.appointmentsService = appointmentsService;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            appointmentsService.AddNewAsync(new Appointment() {Start = DateTime.Now});
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
