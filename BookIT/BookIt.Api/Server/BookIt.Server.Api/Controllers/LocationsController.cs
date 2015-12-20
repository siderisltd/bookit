using BookIt.Server.DataTransferModels.Locations.ViewModels;

namespace BookIt.Server.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Services.Data.Contracts;
    using AutoMapper.QueryableExtensions;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.Data.Entity;
    using AutoMapper;
    using BookIt.Data.Models;
    using BookIt.Server.Common.Contracts;
    using BookIt.Server.DataTransferModels.Locations.BindingModels;
    using BookIt.Server.Infrastructure.Validation;

    public class LocationsController : ApiController , IBookitDeleteController<DeleteLocationBindingModel>
    {
        private readonly ILocationsService locationsService;

        public LocationsController(ILocationsService locationsService)
        {
            this.locationsService = locationsService;
        }

        /// <summary>
        /// Get all locations
        /// </summary>
        /// <returns></returns>
        public async Task<IHttpActionResult> Get()
        {
            var model = await this.locationsService
                .All()
                .ProjectTo<LocationDetailsViewModel>()
                .ToListAsync();

            if (model == null) { return NotFound(); }

            return this.Ok(model);
        }

        /// <summary>
        /// Gets location by given ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ValidateModel]
        public async Task<IHttpActionResult> Get(int id)
        {
            var model = await this.locationsService
                 .All()
                 .ProjectTo<LocationDetailsViewModel>()
                 .FirstOrDefaultAsync(x => x.Id == id);

            return this.Ok(model);
        }

        /// <summary>
        /// Add location by given model
        /// </summary>
        /// <param name="bindingModel"></param>
        /// <returns></returns>
        [ValidateModel]
        public async Task<IHttpActionResult> Post(AddLocationBindingModel bindingModel)
        {
            var dbModel = Mapper.Map<Location>(bindingModel);
            await this.locationsService.AddNewAsync(dbModel);
            return this.Ok();
        }

        /// <summary>
        /// Add many locations by getting a collection of POCO
        /// </summary>
        /// <param name="bindingModel"></param>
        /// <returns></returns>
        [ValidateModel]
        public async Task<IHttpActionResult> Post(IEnumerable<AddLocationBindingModel> bindingModelsToAdd)
        {
            foreach (var model in bindingModelsToAdd)
            {
                var dbModel = Mapper.Map<Location>(model);
                await this.locationsService.AddNewAsync(dbModel);
            }

            return this.Ok();
        }

        /// <summary>
        /// Update given location
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updatableBindingModel"></param>
        /// <returns></returns>
        [ValidateModel]
        public async Task<IHttpActionResult> Put(int id, UpdateLocationBindingModel updatableBindingModel)
        {
            var dbObject = await this.locationsService
                .All()
                .FirstOrDefaultAsync(x => x.Id == id);

            var dbModel = Mapper.Map<UpdateLocationBindingModel, Location>(updatableBindingModel);

            this.locationsService.Update(dbModel);
            await this.locationsService.SaveChangesAsync();

            return this.Ok(dbObject.Id);
        }

        /// <summary>
        /// Deletes location by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult Delete(object id)
        {
            this.locationsService.DeleteById(id);

            return this.Ok();
        }

        /// <summary>
        /// Delete location by given POCO
        /// </summary>
        /// <param name="deletableBindingModel"></param>
        /// <returns></returns>
        [ValidateModel]
        public IHttpActionResult Delete(DeleteLocationBindingModel deletableBindingModel)
        {
            var dbModel = Mapper.Map<DeleteLocationBindingModel, Location>(deletableBindingModel);
            this.locationsService.Delete(dbModel);

            return this.Ok();
        }
    }
}
