namespace BookIt.Server.Api.Controllers
{
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
    using BookIt.Server.Common;
    using BookIt.Server.Infrastructure.Validation;
    using BookIt.Services.Common.Extensions;

    [RoutePrefix("api/Appointments")]
    public class AppointmentsController : ApiController
    {
        //The base controller
        //TODO: Add constraints and different response types
        private readonly IAppointmentsService appointmentsService;

        public AppointmentsController(IAppointmentsService appointmentsService)
        {
            this.appointmentsService = appointmentsService;
        }

        //GET: api/Appointments/async/all
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

        //GET: api/Appointments/async/all/paged
        [Route("async/all/paged")]
        public async Task<IHttpActionResult> Get(int page, int pageSize = Constants.DefaultPageSize)
        {
            int lastPage = this.appointmentsService.GetLastPage(pageSize);

            if (page < 0 || page > lastPage)
            {
                return this.BadRequest(Constants.InvalidPageNumber);
            }

            var model = await this.appointmentsService
                .AllPaged(page, pageSize)
                .ProjectTo<AppointmentsViewModel>()
                .ToListAsync();

            if (model == null) { return NotFound(); }

            return this.Ok(model);
        }

        //GET: api/Appointments/async?id=10
        [Route("async")]
        public async Task<IHttpActionResult> Get(int id)
        {
            var model = await this.appointmentsService
                .All()
                .ProjectTo<AppointmentsViewModel>()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (model == null) { return NotFound(); }

            return this.Ok(model);
        }

        //POST: api/Appointments/async/add
        [Route("async/add")]
        [ValidateModel]
        public async Task<IHttpActionResult> Post([FromBody]AppointmentsBindingModel appointmentToAdd)
        {
            var dbModel = Mapper.Map<Appointment>(appointmentToAdd);

            await this.appointmentsService.AddNewAsync(dbModel);

            return this.Ok();
        }

        //POST: api/Appointments/async/addmany
        [Route("async/addmany")]
        [ValidateModel]
        public async Task<IHttpActionResult> Post([FromBody]IEnumerable<AppointmentsBindingModel> appointmentsToAdd)
        {

            foreach (var appointment in appointmentsToAdd)
            {
                var dbModel = Mapper.Map<Appointment>(appointment);
                await this.appointmentsService.AddNewAsync(dbModel);
            }

            return this.Ok();
        }



        //TODO: Test below

        //PUT: api/Appointments/async/update
        [Route("async/update")]
        [ValidateModel]
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

        //DELETE: api/Appointments/markDeleted
        [Route("markDeleted")]
        public IHttpActionResult Delete(object id)
        {
            this.appointmentsService.DeleteById(id);

            return this.Ok();
        }

        //DELETE: api/Appointments/markDeleted
        [Route("markDeleted")]
        [ValidateModel]
        public IHttpActionResult Delete(Appointment appointmentToDelete)
        {
            this.appointmentsService.Delete(appointmentToDelete);

            return this.Ok();
        }
    }
}
