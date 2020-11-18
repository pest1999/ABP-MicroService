using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Product.EntityFrameworkCore
{
    public class ProductMigrationDbContextFactory: IDesignTimeDbContextFactory<ProductMigrationDbContext>
    {
        public ProductMigrationDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ProductMigrationDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Product"));

            return new ProductMigrationDbContext(builder.Options);
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
