namespace BookIt.Server.Api.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Http;
    using BookIt.Data.Models;
    using BookIt.Services.Data.Contracts;


    public class ValuesController : ApiController
    {
        private IAppointmentsService appointmentsService;

        public ValuesController(IAppointmentsService appointmentsService)
        {
            this.appointmentsService = appointmentsService;
        }

        
        public IEnumerable<string> Get()
        {
            appointmentsService.AddNewAsync(new Appointment() {Start = DateTime.Now});
            return new string[] { "value1", "value2" };
        }

        public string Get(int id)
        {
            return "value";
        }

        public void Post([FromBody]string value)
        {
        }

        public void Put(int id, [FromBody]string value)
        {
        }

        public void Delete(int id)
        {
        }
    }
}
