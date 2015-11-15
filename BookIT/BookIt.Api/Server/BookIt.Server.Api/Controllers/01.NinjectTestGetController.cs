namespace BookIt.Server.Api.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Http;
    using BookIt.Data.Models;
    using BookIt.Services.Data.Contracts;

    public class NinjectTestGetController : ApiController
    {
        private IAppointmentsService appointmentsService;

        public NinjectTestGetController(IAppointmentsService appointmentsService)
        {
            this.appointmentsService = appointmentsService;
        }

        // GET api/NinjectTestGet
        public IEnumerable<string> Get()
        {
            appointmentsService.AddNewAsync(new Appointment() {Start = DateTime.Now});
            return new string[] { "value1", "value2" };
        }
    }
}
