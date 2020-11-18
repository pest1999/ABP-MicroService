using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace Order
{
    [DependsOn(
        typeof(OrderApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule)
    )]
    public class OrderHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(OrderHttpApiModule).Assembly);
            });
        }
    }
}
