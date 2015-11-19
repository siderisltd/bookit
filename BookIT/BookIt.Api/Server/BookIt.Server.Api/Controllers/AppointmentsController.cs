using System.IO;
using BookIt.Services.Common.Extensions;

namespace BookIt.Server.Api.Controllers
{
    using System;
    using System.Web.Http;
    using System.Collections.Generic;
    using BookIt.Services.Data.Contracts;
    using BookIt.Services.Common;
    using BookIt.Data.Models;
    using System.Data.Entity;
    using System.Threading.Tasks;
    

    [RoutePrefix("bookitApi/Appointments")]
    public class AppointmentsController : ApiController
    {
        //TODO: Check the async methods
        private readonly IAppointmentsService appointmentsService;

        public AppointmentsController(IAppointmentsService appointmentsService)
        {
            this.appointmentsService = appointmentsService;
        }


        [Route("async/all")]
        public async Task<IHttpActionResult> Get()
        {
            var model = await this.appointmentsService.All().ToListAsync();

            if (model == null) { return NotFound(); }

            return this.Ok(model);
        }

        public IHttpActionResult Get(int id)
        {
            var model =  this.appointmentsService.GetById(id);

            return this.Ok(model);
        }

        [Route("async/add")]
        public async Task<IHttpActionResult> Post([FromBody]Appointment appointmentToAdd)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            await this.appointmentsService.AddNewAsync(appointmentToAdd);

            return this.Ok();
        }

        [Route("async/addmany")]
        public async Task<IHttpActionResult> Post([FromBody]IEnumerable<Appointment> appointmentsToAdd)
        {
            //await Task.Run(() =>
            //{
            //    Parallel.ForEach(appointmentsToAdd, x => this.appointmentsService.AddNewAsync(x));
            //});

            var addeAppointments = await appointmentsToAdd.ForEachAsync(async appointment =>
            {
                await this.appointmentsService.AddNewAsync(appointment);
                return true;
            });

            //return addedFiles;

            return this.Ok();
        }

        public void Put(object id, [FromBody]Appointment appointmentToUpdate)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            this.appointmentsService.DeleteById(id);
        }


        public void Delete(Appointment appointmentToDelete)
        {
            this.appointmentsService.Delete(appointmentToDelete);
        }
    }
}
