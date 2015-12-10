using System.Linq;
using Bookit.Api.Tests.ServicesTests.ObjectsFactory;
using BookIt.Data.Models;
using BookIt.Services.Data.Services.master;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bookit.Api.Tests.ServicesTests
{
    [TestClass]
    public class DataServiceTests
    {
        //TODO: Continue test cases for the common repositories methods
        private InMemoryRepository<Appointment> inMemoryRepository;
        private DataService<Appointment> dataService;

        [TestInitialize]
        public void Initialize()
        {
            this.inMemoryRepository = TestObjectFactory.GetAppointmentsRepository();
            this.dataService = new DataService<Appointment>(inMemoryRepository);
        }

        [TestMethod]
        public void AddShouldReturnCorrentNumberOfSavedChanges()
        {
            var forSynchronusOperation = this.dataService.AddNewAsync(new Appointment()).Result;
            var actual = this.inMemoryRepository.NumberOfSavedChanges;
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void AddShouldInsertCorrectValuesInRepository()
        {
            int expectedId = 8;
            var actualResult = this.dataService.AddNewAsync(new Appointment() { Id = expectedId }).Result;
            var actual = this.inMemoryRepository.All().FirstOrDefault(x => x.Id == expectedId);

            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedId, actual.Id);
        }
    }

}
