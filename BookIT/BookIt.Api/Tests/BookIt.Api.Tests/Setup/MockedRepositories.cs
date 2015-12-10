using System.Collections.Generic;
using System.Linq;
using Bookit.Data.Contracts;
using BookIt.Data.Models;
using Moq;

namespace Bookit.Api.Tests.Setup
{
    public static class MockedRepositories
    {
        //TODO: Add data
        public static IRepository<Appointment> GetAppointmentsRepository()
        {
            var repository = new Mock<IRepository<Appointment>>();

            repository.Setup(x => x.All()).Returns(() => new List<Appointment>
            {
                new Appointment() { },
                new Appointment() {}
            }.AsQueryable());

            return repository.Object;
        }


        public static IRepository<Location> GetLocationsRepository()
        {

            var listOfLocations = new List<Location>();
            for (int i = 1; i <= 20; i++)
            {
                listOfLocations.Add(new Location() {Id = i, Name = "Test #" + i, Description = "TestDescription #" + i});
            }

            var repository = new Mock<IRepository<Location>>();


            repository.Setup(x => x.All()).Returns(listOfLocations.AsQueryable());

            return repository.Object;
        }

    }
}
