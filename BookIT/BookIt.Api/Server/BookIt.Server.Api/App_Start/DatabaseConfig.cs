namespace BookIt.Server.Api
{
    using System.Data.Entity;
    using Bookit.Data;
    using Bookit.Data.Migrations;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BookItDbContext, Configuration>());
        }
    }
}