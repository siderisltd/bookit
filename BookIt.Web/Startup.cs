using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookIt.Web.Startup))]
namespace BookIt.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
