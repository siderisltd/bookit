namespace BookIt.Server.Api
{
    using System.Web;
    using System.Reflection;
    using System.Web.Http;
    using BookIt.Services.Common;
    using Newtonsoft.Json.Serialization;
    using System.Web.Mvc;

    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            DatabaseConfig.Initialize();
            AutoMapperConfig.RegisterMappings(Assembly.Load(Constants.DataTransferModelsAssembly));

            var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}
