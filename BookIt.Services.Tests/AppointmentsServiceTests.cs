namespace BookIt.Services.Tests
{
    using System.Linq;
    using BookIt.Data.Models;
    using BookIt.Services.Data;
    using BookIt.Services.Data.Contracts;
    using ObjectsFactory;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    //TODO: Make internal?
    [TestClass]
    public class AppointmentsServiceTests
    {
        private InMemoryRepository<Appointment> appointmentRepository;
        private IAppointmentsService appointmentsService;

        [TestInitialize]
        public void Initialize()
        {
            this.appointmentRepository = TestObjectFactory.GetAppointmentsRepository();
            this.appointmentsService = new AppointmentsService(appointmentRepository);
        }

        [TestMethod]
        public void AddShouldReturnCorrentNumberOfSavedChanges()
        {
            var forSynchronusOperation = this.appointmentsService.AddNewAsync(new Appointment()).Result;
            var actual = this.appointmentRepository.NumberOfSavedChanges;
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void AddShouldInsertCorrectValuesInRepository()
        {
            int expectedId = 8;
            this.appointmentsService.AddNewAsync(new Appointment() { Id = expectedId });
            var actual = this.appointmentRepository.All().FirstOrDefault(x => x.Id == expectedId);

            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedId, actual.Id);
        }
    }
}
