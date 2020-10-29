using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AssetManagementSystem.EntityFrameworkCore
{
    public static class AssetManagementSystemDbContextModelCreatingExtensions
    {
        public static void ConfigureAssetManagementSystem(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            #region 自建实体的索引等个性化配置

            #endregion
        }
    }
}
