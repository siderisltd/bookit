namespace BookIt.WebApi.Tests
{
    using System.Reflection;
    using Bookit.Data.Contracts;
    using BookIt.Data.Models;
    using BookIt.Server.Api;
    using BookIt.Server.Common;
    using BookIt.WebApi.Tests.Mocked;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestInit
    {
        [AssemblyInitialize]
        public static void Init(TestContext context)
        {
            NinjectConfig.RegisterDependencies = kernel =>
            {
                kernel.Bind<IRepository<Appointment>>().ToConstant(Repositories.GetAppointmentsRepository());
                kernel.Bind<IRepository<Business>>().ToConstant(Repositories.GetBusinessesRepository());
                kernel.Bind<IRepository<Category>>().ToConstant(Repositories.GetCategoriesRepository());
                kernel.Bind<IRepository<Comment>>().ToConstant(Repositories.GetCommentsRepository());
                kernel.Bind<IRepository<Customer>>().ToConstant(Repositories.GetCustomersRepository());
                kernel.Bind<IRepository<Location>>().ToConstant(Repositories.GetLocationsRepository());
                kernel.Bind<IRepository<Service>>().ToConstant(Repositories.GetServicesRepository());
                kernel.Bind<IRepository<StaffUnit>>().ToConstant(Repositories.GetStaffUnitsRepository());
                kernel.Bind<IRepository<Tag>>().ToConstant(Repositories.GetTagsRepository());
                kernel.Bind<IRepository<Vote>>().ToConstant(Repositories.GetVotesRepository());
            };

            AutoMapperConfig.RegisterMappings(Assembly.Load(Constants.BookItApiAssembly));
        }
    }
}
