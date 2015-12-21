namespace BookIt.Server.Api
{
    using System.Data.Entity;
    using System.Data.SqlClient;
    using Bookit.Data;
    using Bookit.Data.Migrations;
    using Data.Common;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            //TODO: uncomment me when remove
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<BookItDbContext, Configuration>());
            SqlConnection.ClearAllPools();
            //TODO: remove me
            Database.SetInitializer(new MyInitializer());
        }
    }

    //TODO remove me
    public class MyInitializer : DropCreateDatabaseAlways<BookItDbContext>
    {
        protected override void Seed(BookItDbContext context)
        {
            AddOrUpdateRoles(context);
            base.Seed(context);
        }

        private static void AddOrUpdateRoles(BookItDbContext ctx)
        {
            var allRoles = new string[]
            {
                ConstantRoles.ADMIN_ROLE,
                ConstantRoles.CREATOR_ROLE,
                ConstantRoles.EMPLOYEE_ROLE,
                ConstantRoles.MANAGER_ROLE,
                ConstantRoles.OWNER_ROLE,
                ConstantRoles.SUPERVISOR_ROLE,
                ConstantRoles.WORKER_ROLE,
                ConstantRoles.CLIENT_ROLE
            };

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(ctx));

            foreach (var roleName in allRoles)
            {
                if (!roleManager.RoleExists(roleName))
                {
                    roleManager.Create(new IdentityRole(roleName));
                }
            }
        }
    }
}