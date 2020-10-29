using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace AssetManagementSystem.EntityFrameworkCore
{
    [ConnectionStringName("AssetManagementSystem")]
    public class AssetManagementSystemDbContext : AbpDbContext<AssetManagementSystemDbContext>
    {
        #region 添加自建实体

        #endregion

        public AssetManagementSystemDbContext(DbContextOptions<AssetManagementSystemDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureAssetManagementSystem();
        }
    }
}
