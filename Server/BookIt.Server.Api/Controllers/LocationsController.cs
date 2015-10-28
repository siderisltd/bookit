namespace BookIt.Server.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using Services.Data.Contracts;

    public class LocationsController : ApiController
    {
        private ILocationsService locationsService;
        
        public LocationsController()
            :this(new Services.Data.LocationsService(new Data.BookItData()))
        {
        }

        public LocationsController(ILocationsService locationsService)
        {
            this.locationsService = locationsService;
        }

        public IHttpActionResult Get()
        {
            var result = this.locationsService.All().ToList();
            return this.Ok(result);
        }
    }
}
