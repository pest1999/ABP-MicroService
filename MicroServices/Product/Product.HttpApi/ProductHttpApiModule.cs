using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace Product
{
    [DependsOn(
        typeof(ProductApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule)
    )]
    public class ProductHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(ProductHttpApiModule).Assembly);
            });
        }
    }
}
