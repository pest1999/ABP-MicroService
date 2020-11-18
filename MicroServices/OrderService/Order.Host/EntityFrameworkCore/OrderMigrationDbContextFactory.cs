using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Order.EntityFrameworkCore
{
    public class OrderMigrationDbContextFactory: IDesignTimeDbContextFactory<OrderMigrationDbContext>
    {
        public OrderMigrationDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<OrderMigrationDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Order"));

            return new OrderMigrationDbContext(builder.Options);
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
