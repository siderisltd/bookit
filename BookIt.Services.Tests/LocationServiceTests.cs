namespace BookIt.Services.Tests
{
    using System.Linq;
    using BookIt.Data.Models;
    using BookIt.Services.Data;
    using BookIt.Services.Data.Contracts;
    using BookIt.Services.Tests.ObjectsFactory;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    //TODO: Make internal?
    [TestClass]
    public class LocationServiceTests
    {
        private InMemoryRepository<Location> locationsRepository;
        private ILocationsService locationsService;

        [TestInitialize]
        public void Initialize()
        {
            this.locationsRepository = TestObjectFactory.GetLocationsRepository();
            this.locationsService = new LocationsService(locationsRepository);
        }

        [TestMethod]
        public void AddShouldReturnCorrentNumberOfSavedChanges()
        {
            this.locationsService.Add(new Location());
            var actual = this.locationsRepository.NumberOfSavedChanges;
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void AddShouldInsertCorrectValuesInRepository()
        {
            int expectedId = 8;
            this.locationsService.Add(new Location() { Id = expectedId });
            var actual = this.locationsRepository.All().FirstOrDefault(x => x.Id == expectedId);

            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedId, actual.Id);
        }
    }
}
