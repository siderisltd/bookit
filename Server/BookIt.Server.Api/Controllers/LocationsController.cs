namespace BookIt.Server.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using GoogleMaps.LocationServices;

    using Services.Data.Contracts;

    public class LocationsController : ApiController
    {
        private ILocationsService locationsService;
        private ILocationService googleMapsService;

        // TODO: remove when Ninject is configed
        public LocationsController()
        {
            this.googleMapsService = new GoogleLocationService();
            this.locationsService = new Services.Data.LocationsService(new Data.BookItData());
        }

        public LocationsController(ILocationsService locationsService)
        {
            this.locationsService = locationsService;
        }

        public IHttpActionResult Get([FromBody] string address)
        {
            var mapPoint = googleMapsService.GetLatLongFromAddress(address);
            this.locationsService.All()
                .OrderBy(l => l.Address.Latitude)
                .Select(l => l);

            return this.Ok();
        }
    }
}
