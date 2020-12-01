using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;
using XCZ;

namespace BoxApp
{
    [DependsOn(
        typeof(BoxAppApplicationContractsModule),
        typeof(FormHttpApiModule),
        typeof(AbpAspNetCoreMvcModule)
    )]
    public class BoxAppHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(BoxAppHttpApiModule).Assembly);
            });
        }
    }
}
