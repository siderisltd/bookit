namespace BookIt.Server.Infrastructure
{
    using System.Net.Http;
    using System.Web.Http;
    using Microsoft.AspNet.Identity.Owin;

    public class BaseApiController : ApiController
    {
        private ApplicationRoleManager appRoleManager;

        protected ApplicationRoleManager AppRoleManager => this.appRoleManager ?? this.Request.GetOwinContext().GetUserManager<ApplicationRoleManager>();
    }
}
