using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore;

namespace AssetManagementSystem.EntityFrameworkCore
{
    public class AssetManagementSystemMigrationDbContext : AbpDbContext<AssetManagementSystemMigrationDbContext>
    {
        public AssetManagementSystemMigrationDbContext(DbContextOptions<AssetManagementSystemMigrationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureAssetManagementSystem();
        }
    }
}
