using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace BoxAp.EntityFrameworkCore
{
    public class BoxApMigrationDbContextFactory: IDesignTimeDbContextFactory<BoxApMigrationDbContext>
    {
        public BoxApMigrationDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<BoxApMigrationDbContext>()
                .UseSqlServer(configuration.GetConnectionString("BoxAp"));

            return new BoxApMigrationDbContext(builder.Options);
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
