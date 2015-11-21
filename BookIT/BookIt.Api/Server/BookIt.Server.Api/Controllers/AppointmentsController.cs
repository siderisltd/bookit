namespace BookIt.Server.Api.Controllers
{
    using System;
    using System.Web.Http;
    using System.Collections.Generic;
    using BookIt.Services.Data.Contracts;
    using BookIt.Data.Models;
    using System.Data.Entity;
    using System.Threading.Tasks;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using BookIt.Server.DataTransferModels.Appointments.BindingModels;
    using BookIt.Server.DataTransferModels.Appointments.ViewModels;


    [RoutePrefix("bookitApi/Appointments")]
    public class AppointmentsController : ApiController
    {
        //TODO: Check the async methods
        private readonly IAppointmentsService appointmentsService;

        public AppointmentsController(IAppointmentsService appointmentsService)
        {
            this.appointmentsService = appointmentsService;
        }

        //GET: bookitApi/Appointments/async/all
        [Route("async/all")]
        public async Task<IHttpActionResult> Get()
        {
            var model = await this.appointmentsService
                .All()
                .ProjectTo<AppointmentsViewModel>()
                .ToListAsync();

            if (model == null) { return NotFound(); }

            return this.Ok(model);
        }

        //GET: bookitApi/Appointments/async?id=10
        [Route("async")]
        public async Task<IHttpActionResult> Get(int id)
        {
            var model = await this.appointmentsService
                .All()
                .ProjectTo<AppointmentsViewModel>()
                .FirstOrDefaultAsync(x => x.Id == id);


            return this.Ok(model);
        }

        //POST: bookitApi/Appointments/async/add
        [Route("async/add")]
        public async Task<IHttpActionResult> Post([FromBody]AppointmentsBindingModel appointmentToAdd)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var dbModel = Mapper.Map<Appointment>(appointmentToAdd);

            await this.appointmentsService.AddNewAsync(dbModel);

            return this.Ok();
        }

        [Route("async/addmany")]
        public async Task<IHttpActionResult> Post([FromBody]IEnumerable<AppointmentsBindingModel> appointmentsToAdd)
        {
            foreach (var appointment in appointmentsToAdd)
            {
                var dbModel = Mapper.Map<Appointment>(appointment);
                await this.appointmentsService.AddNewAsync(dbModel);
            }

            return this.Ok();
        }

        [Route("async/update")]
        public async Task<IHttpActionResult> Put(int id, [FromBody]AppointmentsBindingModel appointmentToUpdate)
        {
            var dbObject = await this.appointmentsService
                .All()
                .FirstOrDefaultAsync(x => x.Id == id);

            dbObject.Start = appointmentToUpdate.Start;
            dbObject.End = appointmentToUpdate.End;
            dbObject.CreatedOn = appointmentToUpdate.CreatedOn;

            await this.appointmentsService.SaveChangesAsync();

            return this.Ok(dbObject.Id);
        }

        [Route("markDeleted")]
        public IHttpActionResult Delete(int id)
        {
            this.appointmentsService.Delete(id);

            return this.Ok();
        }

        [Route("markDeleted")]
        public IHttpActionResult Delete(Appointment appointmentToDelete)
        {
            this.appointmentsService.Delete(appointmentToDelete);

            return this.Ok();
        }
    }
}
