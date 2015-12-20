[assembly: Microsoft.Owin.OwinStartup(typeof(Bookit.SPA.Startup))]

namespace Bookit.SPA
{
    using Owin;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //uncomment to start the server parralel. and change the baseUrl port to the server's one.
            // by default now is connected to appHarbor server
           // BookIt.Server.Api.Startup.ConfigureAuth(app);
        }
    }
}