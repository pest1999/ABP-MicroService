using BoxApp;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;
using XCZ;

namespace Business
{
    [DependsOn(
        typeof(BusinessApplicationContractsModule),
        typeof(FormHttpApiModule),
        typeof(AbpAspNetCoreMvcModule),
        typeof(BoxAppApplicationContractsModule),
        typeof(BoxAppHttpApiModule)
    )]
    public class BusinessHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(BusinessHttpApiModule).Assembly);
            });
        }
    }
}
