using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace BoxApp.EntityFrameworkCore
{
    public class BoxAppMigrationDbContextFactory: IDesignTimeDbContextFactory<BoxAppMigrationDbContext>
    {
        public BoxAppMigrationDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<BoxAppMigrationDbContext>()
                .UseSqlServer(configuration.GetConnectionString("BoxApp"));

            return new BoxAppMigrationDbContext(builder.Options);
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
