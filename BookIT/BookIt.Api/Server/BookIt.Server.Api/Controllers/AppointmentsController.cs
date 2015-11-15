namespace BookIt.Server.Api.Controllers
{
    using System;
    using System.Web.Http;
    using System.Collections.Generic;
    using BookIt.Services.Data.Contracts;
    using BookIt.Data.Models;
    using System.Data.Entity;
    using System.Threading.Tasks;

    //[Authorize]
    public class AppointmentsController : ApiController
    {
        //TODO: Check the async methods
        private readonly IAppointmentsService appointmentsService;

        public AppointmentsController(IAppointmentsService appointmentsService)
        {
            this.appointmentsService = appointmentsService;
        }

        // GET: api/Appointments
        [Route("appointments/async/all")]
        public async Task<IHttpActionResult> Get()
        {
            var model = await this.appointmentsService.All().ToListAsync();

            if (model == null) { return NotFound(); }

            return this.Ok(model);
        }

        // GET: api/Appointments/5
        public IHttpActionResult Get(object id)
        {
            if (id == null)
            {
                return this.BadRequest("AppointmentID cannot be null");
            }

            var model =  this.appointmentsService.GetById(id);

            return this.Ok(model);
        }

        // POST: api/Appointments
        [Route("api/appointments/async/add")]
        public async Task<IHttpActionResult> Post([FromBody]Appointment appointmentToAdd)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            await this.appointmentsService.AddNewAsync(appointmentToAdd);

            return this.Ok();
        }

        // POST: api/Appointments
        [Route("api/appointments/async/addmany")]
        public async Task<IHttpActionResult> Post([FromBody]IEnumerable<Appointment> appointmentsToAdd)
        {
            await Task.Run(() =>
            {
                Parallel.ForEach(appointmentsToAdd, x => this.appointmentsService.AddNewAsync(x));
            });

            return this.Ok();
        }

        // PUT: api/Appointments/5
        public void Put(object id, [FromBody]Appointment appointmentToUpdate)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/Appointments/5
        public void Delete(object id)
        {
            this.appointmentsService.DeleteById(id);
        }

        // DELETE: api/Appointments
        public void Delete(Appointment appointmentToDelete)
        {
            this.appointmentsService.Delete(appointmentToDelete);
        }
    }
}
