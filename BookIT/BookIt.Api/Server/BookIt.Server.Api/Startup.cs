using System.Reflection;
using System.Web.Http;
using BookIt.Server.Common;

[assembly: Microsoft.Owin.OwinStartup(typeof(BookIt.Server.Api.Startup))]

namespace BookIt.Server.Api
{
    using Owin;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            AutoMapperConfig.RegisterMappings(Assembly.Load(Constants.BookItApiAssembly));

            ConfigureAuth(app);

            var httpConfig = new HttpConfiguration();

            WebApiConfig.Register(httpConfig);

            httpConfig.EnsureInitialized();

            //app
            //    .UseNinjectMiddleware(NinjectConfig.CreateKernel)
            //    .UseNinjectWebApi(httpConfig);

        }
    }
}
