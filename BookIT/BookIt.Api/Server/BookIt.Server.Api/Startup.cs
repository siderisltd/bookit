[assembly: Microsoft.Owin.OwinStartup(typeof(BookIt.Server.Api.Startup))]

namespace BookIt.Server.Api
{
    using Owin;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           // NinjectConfig.RegisterDependencies()

            ConfigureAuth(app);

            //app
            //    .UseNinjectMiddleware(NinjectConfig.CreateKernel)
            //    .UseNinjectWebApi(new HttpConfiguration());

        }
    }
}
