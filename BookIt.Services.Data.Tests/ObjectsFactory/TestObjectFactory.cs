namespace BookIt.Api.Tests.ObjectsFactory
{
    using System;
    using BookIt.Data.Models;

    public static class TestObjectFactory
    {
        public static InMemoryRepository<ApplicationUser> GetApplicationUserRepository(int count = 50)
        {
            var repository = new InMemoryRepository<ApplicationUser>();

            for (int i = 0; i < count; i++)
            {
                var user = new ApplicationUser();
                
                repository.Add(user);
            }

            return repository;
        }

        public static InMemoryRepository<Appointment> GetAppointmentsRepository(int count = 50)
        {
            var repository = new InMemoryRepository<Appointment>();

            for (int i = 0; i < count; i++)
            {
                var appointment = new Appointment();

                repository.Add(appointment);
            }

            return repository;
        }

        public static InMemoryRepository<Business> GetBusinessesRepository(int count = 50)
        {
            var repository = new InMemoryRepository<Business>();

            for (int i = 0; i < count; i++)
            {
                var business = new Business();

                repository.Add(business);
            }

            return repository;
        }

        public static InMemoryRepository<Category> GetCategoriesRepository(int count = 50)
        {
            var repository = new InMemoryRepository<Category>();

            for (int i = 0; i < count; i++)
            {
                var category = new Category();

                repository.Add(category);
            }

            return repository;
        }

        public static InMemoryRepository<Comment> GetCommentsRepository(int count = 50)
        {
            var repository = new InMemoryRepository<Comment>();

            for (int i = 0; i < count; i++)
            {
                var comment = new Comment();

                repository.Add(comment);
            }

            return repository;
        }

        public static InMemoryRepository<Customer> GetCustomersRepository(int count = 50)
        {
            var repository = new InMemoryRepository<Customer>();

            for (int i = 0; i < count; i++)
            {
                var customer = new Customer();

                repository.Add(customer);
            }

            return repository;
        }

        public static InMemoryRepository<Location> GetLocationsRepository(int count = 50)
        {
            var repository = new InMemoryRepository<Location>();

            for (int i = 0; i < count; i++)
            {
                var location = new Location();

                repository.Add(location);
            }

            return repository;
        }

        public static InMemoryRepository<Service> GetServicesRepository(int count = 50)
        {
            var repository = new InMemoryRepository<Service>();

            for (int i = 0; i < count; i++)
            {
                var service = new Service();

                repository.Add(service);
            }

            return repository;
        }

        public static InMemoryRepository<StaffUnit> GetStaffUnitRepository(int count = 50)
        {
            var repository = new InMemoryRepository<StaffUnit>();

            for (int i = 0; i < count; i++)
            {
                var staffUnit = new StaffUnit();

                repository.Add(staffUnit);
            }

            return repository;
        }

        public static InMemoryRepository<Tag> GetTagsRepository(int count = 50)
        {
            var repository = new InMemoryRepository<Tag>();

            for (int i = 0; i < count; i++)
            {
                var tag = new Tag();

                repository.Add(tag);
            }

            return repository;
        }

        public static InMemoryRepository<Vote> GetVotesRepository(int count = 50)
        {
            var repository = new InMemoryRepository<Vote>();

            for (int i = 0; i < count; i++)
            {
                var vote = new Vote();

                repository.Add(vote);
            }

            return repository;
        }
    }
}
