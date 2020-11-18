using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace ProductAp
{
    [DependsOn(
        typeof(ProductApApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule)
    )]
    public class ProductApHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(ProductApHttpApiModule).Assembly);
            });
        }
    }
}
