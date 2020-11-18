using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ProductAp.EntityFrameworkCore
{
    public class ProductApMigrationDbContextFactory: IDesignTimeDbContextFactory<ProductApMigrationDbContext>
    {
        public ProductApMigrationDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ProductApMigrationDbContext>()
                .UseSqlServer(configuration.GetConnectionString("ProductAp"));

            return new ProductApMigrationDbContext(builder.Options);
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
