﻿using Volo.Abp.AutoMapper;
using Volo.Abp.BackgroundJobs.Hangfire;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace ProductAp
{
    [DependsOn(
        typeof(ProductApApplicationContractsModule),
        typeof(AbpHttpClientIdentityModelModule),
        typeof(AbpIdentityHttpApiClientModule),
        typeof(AbpAutoMapperModule),
        typeof(AbpBackgroundJobsHangfireModule)
    )]
    public class ProductApApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<ProductApApplicationModule>();
            });
        }
    }
}
