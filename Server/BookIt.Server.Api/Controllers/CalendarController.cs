namespace BookIt.Server.Api.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Http;

    using Models;
    using Services.Data;
    using Services.Data.Contracts;
    using Data.Models;
    
    public class CalendarController : ApiController
    {
        private IAppointmentService appointmentService;
        //private ILocationService locatoinService;

        public CalendarController(IAppointmentService appointmentService)
        {
            this.appointmentService = appointmentService;
            //this.locatoinService = locatoinService;
        }

        // GET: Calendar
        public IHttpActionResult Get(int year, int month, int day, [FromBody]int businessId)
        {
            var data = new
            {
                date = new
                {
                    year = year,
                    month = month,
                    day = day
                },
                result = new TimeFrame[]
                {
                    new TimeFrame(new Time(10, 00), new Time(12, 30)),
                    new TimeFrame(new Time(13, 00), new Time(14, 00)),
                    new TimeFrame(new Time(17, 00), new Time(17, 30)),
                }
            };

            return this.Ok(data);

            var model = appointmentService.Get(businessId, new DateTime(year, month, day));
            return this.Ok(model);
        }

        [Authorize]
        [HttpPost]
        public void Post(int year, int month, int day, [FromBody]int businessId, [FromBody]TimeFrame timeFrame)
        {
            var newAppointment = new Appointment()
            {
                //Location = locatoinService.GetById(businessId)
            };

            appointmentService.AddNew(newAppointment);
        }
    }
}