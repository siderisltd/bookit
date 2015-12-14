//[assembly: Microsoft.Owin.OwinStartup(typeof(Bookit.SPA.Startup))]

namespace Bookit.SPA
{
    using Owin;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //BookIt.Server.Api.Startup.ConfigureAuth(app);
            //BookIt.Server.Api.Startup.Configuration(app);
        }
    }
}