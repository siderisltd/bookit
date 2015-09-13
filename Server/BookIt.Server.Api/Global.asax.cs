namespace BookIt.Server.Api
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Reflection;
    using System.Web;
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    using Newtonsoft.Json.Serialization;

    using BookIt.Data;
    using BookIt.Data.Migrations;
    using BookIt.Server.Common.Mapping;
    using BookIt.Services.Common;

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BookItDbContext, Configuration>());
            AutoMapperConfig.RegisterMappings(Assembly.Load(Constants.DataTransferModelsAssembly));

            var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

        }
    }
}
