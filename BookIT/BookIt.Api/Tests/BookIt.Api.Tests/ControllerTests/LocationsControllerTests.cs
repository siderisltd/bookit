using Bookit.Api.Tests.Setup;
using BookIt.Server.Api.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyTested.WebApi;

namespace Bookit.Api.Tests.ControllerTests
{
    [TestClass]
    public class LocationsControllerTests
    {
        [TestMethod]
        public void GetShouldReturnOkResult() 
        {
            MyWebApi
                .Controller<LocationsController>()
                .WithResolvedDependencies(MockedServices.GetLocationsService())
                .Calling(x => x.Get())
                .ShouldReturn()
                .Ok();
        }
    }
}
