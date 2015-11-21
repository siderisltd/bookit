namespace BookIt.WebApi.Tests.Mocked
{
    using System.Linq;
    using System.Collections.Generic;
    using Bookit.Data.Contracts;
    using BookIt.Data.Models;
    using Moq;

    public static class Repositories
    {
        //TODO: Add data
        public static IRepository<Appointment> GetAppointmentsRepository()
        {
            var repository = new Mock<IRepository<Appointment>>();

            repository.Setup(x => x.All()).Returns(() => new List<Appointment>
            {
                new Appointment() {},
                new Appointment() {}
            }.AsQueryable());

            return repository.Object;
        }

        public static IRepository<Business> GetBusinessesRepository()
        {
            var repository = new Mock<IRepository<Business>>();

            repository.Setup(x => x.All()).Returns(() => new List<Business>
            {
                new Business() {},
                new Business() {}
            }.AsQueryable());

            return repository.Object;
        }

        public static IRepository<Category> GetCategoriesRepository()
        {
            var repository = new Mock<IRepository<Category>>();

            repository.Setup(x => x.All()).Returns(() => new List<Category>
            {
                new Category() {},
                new Category() {}
            }.AsQueryable());

            return repository.Object;
        }

        public static IRepository<Comment> GetCommentsRepository()
        {
            var repository = new Mock<IRepository<Comment>>();

            repository.Setup(x => x.All()).Returns(() => new List<Comment>
            {
                new Comment() {},
                new Comment() {}
            }.AsQueryable());

            return repository.Object;
        }

        public static IRepository<Customer> GetCustomersRepository()
        {
            var repository = new Mock<IRepository<Customer>>();

            repository.Setup(x => x.All()).Returns(() => new List<Customer>
            {
                new Customer() {},
                new Customer() {}
            }.AsQueryable());

            return repository.Object;
        }

        public static IRepository<Location> GetLocationsRepository()
        {
            var repository = new Mock<IRepository<Location>>();

            repository.Setup(x => x.All()).Returns(() => new List<Location>
            {
                new Location() {},
                new Location() {}
            }.AsQueryable());

            return repository.Object;
        }

        public static IRepository<Service> GetServicesRepository()
        {
            var repository = new Mock<IRepository<Service>>();

            repository.Setup(x => x.All()).Returns(() => new List<Service>
            {
                new Service() {},
                new Service() {}
            }.AsQueryable());

            return repository.Object;
        }

        public static IRepository<StaffUnit> GetStaffUnitsRepository()
        {
            var repository = new Mock<IRepository<StaffUnit>>();

            repository.Setup(x => x.All()).Returns(() => new List<StaffUnit>
            {
                new StaffUnit() {},
                new StaffUnit() {}
            }.AsQueryable());

            return repository.Object;
        }

        public static IRepository<Tag> GetTagsRepository()
        {
            var repository = new Mock<IRepository<Tag>>();

            repository.Setup(x => x.All()).Returns(() => new List<Tag>
            {
                new Tag() {},
                new Tag() {}
            }.AsQueryable());

            return repository.Object;
        }

        public static IRepository<Vote> GetVotesRepository()
        {
            var repository = new Mock<IRepository<Vote>>();

            repository.Setup(x => x.All()).Returns(() => new List<Vote>
            {
                new Vote() {},
                new Vote() {}
            }.AsQueryable());

            return repository.Object;
        }
    }
}
