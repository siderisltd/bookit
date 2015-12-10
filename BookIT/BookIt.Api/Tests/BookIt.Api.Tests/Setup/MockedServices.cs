using BookIt.Services.Data.Contracts;
using BookIt.Services.Data.Services;

namespace Bookit.Api.Tests.Setup
{
    public static class MockedServices
    {
        public static ILocationsService GetLocationsService()
        {
            return new LocationsService(MockedRepositories.GetLocationsRepository());
        }
    }
}
