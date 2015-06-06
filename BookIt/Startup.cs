using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookIt.Startup))]
namespace BookIt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
