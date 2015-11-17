namespace BookIt.Server.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Services.Data.Contracts;
    using BookIt.Server.DataTransferModels.Location.ViewModels;
    using AutoMapper.QueryableExtensions;

    [Authorize]
    [RoutePrefix("bookitApi/Locations")]
    public class LocationsController : ApiController
    {
        private readonly ILocationsService locationsService;

        public LocationsController(ILocationsService locationsService)
        {
            this.locationsService = locationsService;
        }

        [AllowAnonymous]
        public IHttpActionResult Get()
        {
            var result = this.locationsService
                .All()
                .ProjectTo<LocationDetailsViewModel>()
                .ToList();
            return this.Ok(result);
        }
    }
}
