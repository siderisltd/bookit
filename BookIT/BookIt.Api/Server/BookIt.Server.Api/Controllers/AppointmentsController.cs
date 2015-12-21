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
    using Data.Common;

    [Authorize(Roles = ConstantRoles.CLIENT_ROLE)]
    [RoutePrefix("api/Appointments")]
    public class AppointmentsController : ApiController
    {
        //TODO: Add constraints and different response types
        private readonly IAppointmentsService appointmentsService;

        public AppointmentsController(IAppointmentsService appointmentsService)
        {
            this.appointmentsService = appointmentsService;
        }

        /// <summary>
        /// Get all appointments [REQUIRED ROLES: Owner]
        /// </summary>
        /// <returns></returns>
        //GET: api/Appointments/async/all
        [Authorize(Roles = ConstantRoles.OWNER_ROLE)]
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

        /// <summary>
        /// Return paged appointments
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize">optional parameter devault value = 20</param>
        /// <returns></returns>
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

        /// <summary>
        /// Get appointment by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Add an appointment
        /// </summary>
        /// <param name="appointmentToAdd"></param>
        /// <returns></returns>
        //POST: api/Appointments/async/add
        [Route("async/add")]
        [ValidateModel]
        public async Task<IHttpActionResult> Post([FromBody]AppointmentsBindingModel appointmentToAdd)
        {
            var dbModel = Mapper.Map<Appointment>(appointmentToAdd);

            await this.appointmentsService.AddNewAsync(dbModel);

            return this.Ok();
        }

        /// <summary>
        /// Add many appointments 
        /// </summary>
        /// <param name="appointmentsToAdd"></param>
        /// <returns></returns>
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


        //PUT: api/Appointments/async/update
        /// <summary>
        /// !Not tested
        /// </summary>
        /// <param name="id"></param>
        /// <param name="appointmentToUpdate"></param>
        /// <returns></returns>
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
        /// <summary>
        ///  !Not tested
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("markDeleted")]
        public IHttpActionResult Delete(object id)
        {
            this.appointmentsService.DeleteById(id);

            return this.Ok();
        }

        //DELETE: api/Appointments/markDeleted
        /// <summary>
        ///  !Not tested
        /// </summary>
        /// <param name="appointmentToDelete"></param>
        /// <returns></returns>
        [Route("markDeleted")]
        [ValidateModel]
        public IHttpActionResult Delete(Appointment appointmentToDelete)
        {
            this.appointmentsService.Delete(appointmentToDelete);

            return this.Ok();
        }
    }
}
