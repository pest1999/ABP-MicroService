using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AssetManagementSystem.EntityFrameworkCore
{
    [DependsOn(
        typeof(AssetManagementSystemDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class AssetManagementSystemEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpDbContextOptions>(options =>
            {
                options.UseSqlServer();
            });

            context.Services.AddAbpDbContext<AssetManagementSystemDbContext>(options =>
            {
                options.AddDefaultRepositories(includeAllEntities: true);
            });
        }
    }
}
