
using Microsoft.Owin;

[assembly: OwinStartup(typeof(BookIt.Server.Api.Startup))]

namespace BookIt.Server.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    using Ninject.Web.Common.OwinHost;
    using Ninject.Web.WebApi.OwinHost;

    using Owin;

    using BookIt.Server.Api.App_Start;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            app
                .UseNinjectMiddleware(NinjectConfig.CreateKernel)
                .UseNinjectWebApi(new HttpConfiguration());

        }
    }
}
