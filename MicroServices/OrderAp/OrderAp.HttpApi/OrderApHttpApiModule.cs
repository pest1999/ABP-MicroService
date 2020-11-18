using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace OrderAp
{
    [DependsOn(
        typeof(OrderApApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule)
    )]
    public class OrderApHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(OrderApHttpApiModule).Assembly);
            });
        }
    }
}
