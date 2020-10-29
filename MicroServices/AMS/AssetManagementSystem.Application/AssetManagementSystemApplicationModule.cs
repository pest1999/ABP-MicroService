using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace AssetManagementSystem
{
    [DependsOn(
        typeof(AssetManagementSystemApplicationContractsModule),
        typeof(AbpAutoMapperModule)
    )]
    public class AssetManagementSystemApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<AssetManagementSystemApplicationModule>();
            });
        }
    }
}
