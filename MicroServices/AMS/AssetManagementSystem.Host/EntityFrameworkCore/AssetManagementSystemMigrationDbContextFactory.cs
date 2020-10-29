using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystem.EntityFrameworkCore
{
    public class AssetManagementSystemMigrationDbContextFactory : IDesignTimeDbContextFactory<AssetManagementSystemMigrationDbContext>
    {
        public AssetManagementSystemMigrationDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AssetManagementSystemMigrationDbContext>()
                .UseSqlServer(configuration.GetConnectionString("AssetManagementSystem"));

            return new AssetManagementSystemMigrationDbContext(builder.Options);
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
