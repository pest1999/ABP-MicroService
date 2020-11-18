using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace OrderAp.EntityFrameworkCore
{
    public class OrderApMigrationDbContextFactory: IDesignTimeDbContextFactory<OrderApMigrationDbContext>
    {
        public OrderApMigrationDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<OrderApMigrationDbContext>()
                .UseSqlServer(configuration.GetConnectionString("OrderAp"));

            return new OrderApMigrationDbContext(builder.Options);
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
