using BookIt.Services.Data.Contracts.master;
using BookIt.Services.Data.Services.master;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(BookIt.Server.Api.NinjectConfig), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(BookIt.Server.Api.NinjectConfig), "Stop")]

namespace BookIt.Server.Api
{
    using System;
    using System.Web;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject.Extensions.Conventions;
    using Ninject;
    using Bookit.Data;
    using Microsoft.Owin.Security;
    using Microsoft.Owin.Security.DataHandler;
    using Microsoft.Owin.Security.DataHandler.Encoder;
    using Microsoft.Owin.Security.DataHandler.Serializer;
    using Ninject.Web.Common;
    using BookIt.Server.Common;
    using BookIt.Data.Common.Contracts;
    using BookIt.Data.Common.Repositories;
    using BookIt.Services.Common;
    using BookIt.Services.Data;
    using BookIt.Services.Data.Contracts;

    public static class NinjectConfig 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                ObjectFactory.Innitialize(kernel);
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {


            //kernel.Bind(typeof(IBookItDbContext)).To(typeof(BookItDbContext)).InRequestScope();
            //kernel.Bind(typeof(IBookItData)).To(typeof(BookItData));

            //kernel.Bind(typeof(IDeletableDataService<>)).To(typeof(DeletableDataService<>));

            //kernel.Bind(typeof(IRepository<>)).To(typeof(EfGenericRepository<>));
            //kernel.Bind(typeof(IDataService<>)).To(typeof(DataService<>));
            //kernel.Bind(typeof(IDeletableService<>)).To(typeof(DeletableService<>));

            kernel.Bind(x => x
                .From("BookIt.Data")
                .SelectAllClasses()
                 .BindAllInterfaces());

            kernel.Bind(x => x
                .From("BookIt.Data.Common")
                .SelectAllClasses()
                 .BindAllInterfaces());

            kernel.Bind(x => x
                .From("BookIt.Data.Models")
                .SelectAllClasses()
              .BindAllInterfaces());

            kernel.Bind(x => x
                .From("BookIt.Server.Api")
                .SelectAllClasses()
                .BindAllInterfaces());

            kernel.Bind(x => x
                .From("BookIt.Server.Common")
                .SelectAllClasses()
                .BindAllInterfaces());

            kernel.Bind(x => x
                .From("BookIt.Server.DataTransferModels")
                .SelectAllClasses()
               .BindAllInterfaces());

            kernel.Bind(x => x
                .From("BookIt.Services.Common")
                .SelectAllClasses()
               .BindAllInterfaces());

            kernel.Bind(x => x
                 .From("BookIt.Services.Data")
                 .SelectAllClasses()
              .BindAllInterfaces());



            kernel.Bind(typeof(ISecureDataFormat<AuthenticationTicket>)).To(typeof(SecureDataFormat<AuthenticationTicket>));
            kernel.Bind(typeof(ITextEncoder)).To(typeof(Base64UrlTextEncoder));
            kernel.Bind(typeof(IDataSerializer<AuthenticationTicket>)).To(typeof(TicketSerializer));
        }        
    }
}
