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
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BookItDbContext, Configuration>());
        }
    }
}