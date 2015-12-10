using System.Reflection;
using Bookit.Api.Tests.Setup;
using Bookit.Data.Contracts;
using BookIt.Data.Models;
using BookIt.Server.Api;
using BookIt.Server.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bookit.Api.Tests
{
    [TestClass]
    public static class TestInit
    {
        [AssemblyInitialize]
        public static void Init(TestContext context)
        {
            NinjectConfig.RegisterDependencies = kernel =>
            {
                kernel.Bind<IRepository<Appointment>>().ToConstant(MockedRepositories.GetAppointmentsRepository());
                //kernel.Bind<IRepository<Business>>().ToConstant(Repositories.GetBusinessesRepository());
                //kernel.Bind<IRepository<Category>>().ToConstant(Repositories.GetCategoriesRepository());
                //kernel.Bind<IRepository<Comment>>().ToConstant(Repositories.GetCommentsRepository());
                //kernel.Bind<IRepository<Customer>>().ToConstant(Repositories.GetCustomersRepository());
                kernel.Bind<IRepository<Location>>().ToConstant(MockedRepositories.GetLocationsRepository());
                //kernel.Bind<IRepository<Service>>().ToConstant(Repositories.GetServicesRepository());
                //kernel.Bind<IRepository<StaffUnit>>().ToConstant(Repositories.GetStaffUnitsRepository());
                //kernel.Bind<IRepository<Tag>>().ToConstant(Repositories.GetTagsRepository());
                //kernel.Bind<IRepository<Vote>>().ToConstant(Repositories.GetVotesRepository());
            };
            //4:37
            AutoMapperConfig.RegisterMappings(Assembly.Load(Constants.BookItApiAssembly));
            AutoMapperConfig.RegisterMappings(Assembly.Load(Constants.DataTransferModelsAssembly));
        }
    }
}
