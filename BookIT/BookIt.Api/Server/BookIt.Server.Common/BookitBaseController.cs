//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Threading.Tasks;
//using System.Web.Http;
//using AutoMapper;
//using AutoMapper.QueryableExtensions;
//using BookIt.Data.Models.Contracts;
//using BookIt.Server.Common.Contracts;
//using BookIt.Server.Common.Mapping;
//using BookIt.Server.Infrastructure.Validation;
//using BookIt.Services.Data.Contracts.master;

//namespace BookIt.Server.Api.Controllers
//{

//    //TODO: Fuck this shit?
//    public abstract class BookitBaseController<TDbObject, TService> : ApiController
//        where TDbObject : class, IBookItEntity
//        where TService : class, IDataService<TDbObject>

//    {
//        //TODO: Add constraints and different response types
//        private readonly TService service;

//        protected BookitBaseController(TService service)
//        {
//            this.service = service;
//        }

//        public virtual async Task<IHttpActionResult> Get<TViewModel>() where TViewModel : class, IMapFrom<TDbObject>, IViewModel
//        {
//            var model = await this.service
//                .All()
//                .ProjectTo<TViewModel>()
//                .ToListAsync();

//            if (model == null) { return NotFound(); }

//            return this.Ok(model);
//        }

//        public virtual async Task<IHttpActionResult> Get<TViewModel>(int id) where TViewModel : class, IMapFrom<TDbObject>, IViewModel
//        {
//            var model = await this.service
//                .All()
//                .ProjectTo<TViewModel>()
//                .FirstOrDefaultAsync(x => x.Id == id);

//            if (model == null) { return NotFound(); }

//            return this.Ok(model);
//        }

//        //POST: bookitApi/Appointments/async/add
//        [Route("async/add")]
//        [ValidateModel]
//        public virtual async Task<IHttpActionResult> Post<TBindingModel>([FromBody]TBindingModel bindingModel) where TBindingModel : class, IMapFrom<TDbObject>, IBindingModel
//        {
//            if (!this.ModelState.IsValid)
//            {
//                return this.BadRequest(this.ModelState);
//            }

//            var dbModel = Mapper.Map<TDbObject>(bindingModel);

//            await this.service.AddNewAsync(dbModel);

//            return this.Ok();
//        }

//        //POST: bookitApi/Appointments/async/addmany
//        [Route("async/addmany")]
//        [ValidateModel]
//        public virtual async Task<IHttpActionResult> Post<TBindingModel>([FromBody]IEnumerable<TBindingModel> bindingModelsToAdd) where TBindingModel : class, IMapFrom<TDbObject>, IBindingModel
//        {
//            foreach (var model in bindingModelsToAdd)
//            {
//                var dbModel = Mapper.Map<TDbObject>(model);
//                await this.service.AddNewAsync(dbModel);
//            }

//            return this.Ok();
//        }

//        //PUT: bookitApi/Appointments/async/update
//        [Route("async/update")]
//        [ValidateModel]
//        public virtual async Task<IHttpActionResult> Put<TBindingModel>(int id, [FromBody]TBindingModel updatableModel) where TBindingModel : class, IMapFrom<TDbObject>, IBindingModel
//        {
//            var dbObject = await this.service
//                .All()
//                .FirstOrDefaultAsync(x => x.Id == id);

//            var dbModel = Mapper.Map<TBindingModel, TDbObject>(updatableModel);

//            this.service.Update(dbModel);
//            await this.service.SaveChangesAsync();

//            return this.Ok(dbObject.Id);
//        }

//        //DELETE: bookitApi/Appointments/markDeleted
//        [Route("markDeleted")]
//        public virtual IHttpActionResult Delete(object id)
//        {
//            this.service.DeleteById(id);

//            return this.Ok();
//        }

//        //DELETE: bookitApi/Appointments/markDeleted
//        [Route("markDeleted")]
//        [ValidateModel]
//        public virtual IHttpActionResult Delete(TDbObject appointmentToDelete)
//        {
//            this.service.Delete(appointmentToDelete);

//            return this.Ok();
//        }
//    }
//}