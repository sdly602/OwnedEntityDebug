using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace OwnedEntityDebug.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class OwnedEntityDebugMigrationsDbContextFactory : IDesignTimeDbContextFactory<OwnedEntityDebugMigrationsDbContext>
    {
        public OwnedEntityDebugMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<OwnedEntityDebugMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new OwnedEntityDebugMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
