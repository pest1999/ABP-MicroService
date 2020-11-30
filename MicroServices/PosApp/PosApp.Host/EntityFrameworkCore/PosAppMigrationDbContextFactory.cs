using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PosApp.EntityFrameworkCore
{
    public class PosAppMigrationDbContextFactory: IDesignTimeDbContextFactory<PosAppMigrationDbContext>
    {
        public PosAppMigrationDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<PosAppMigrationDbContext>()
                .UseSqlServer(configuration.GetConnectionString("PosApp"));

            return new PosAppMigrationDbContext(builder.Options);
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
