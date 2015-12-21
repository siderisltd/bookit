using System.Reflection;
using System.Web.Http;
using BookIt.Server.Common;

//[assembly: Microsoft.Owin.OwinStartup(typeof(BookIt.Server.Api.Startup))]

namespace BookIt.Server.Api
{
    using System.Web.Security;
    using Microsoft.Owin.Cors;
    using Ninject.Web.Common.OwinHost;
    using Ninject.Web.WebApi.OwinHost;
    using Owin;

    public partial class Startup
    {
        public static void Configuration(IAppBuilder app)
        {
            //TODO:Uncomment if you want to run the server with starting the client

            //AutoMapperConfig.RegisterMappings(Assembly.Load(Constants.BookItApiAssembly));
            //AutoMapperConfig.RegisterMappings(Assembly.Load(Constants.DataTransferModelsAssembly));

           

            //TODO: Restrict Ip 
            app.UseCors(CorsOptions.AllowAll);
            ConfigureAuth(app);


            //var httpConfig = new HttpConfiguration();
            //WebApiConfig.Register(httpConfig);
            //httpConfig.EnsureInitialized();

            //app
            //    .UseNinjectMiddleware(NinjectConfig.CreateKernel)
            //    .UseNinjectWebApi(httpConfig);

        }

    }
}
