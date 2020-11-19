using Volo.Abp.AutoMapper;
using Volo.Abp.BackgroundJobs.Hangfire;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace OrderAp
{
    [DependsOn(
        typeof(OrderApApplicationContractsModule),
        typeof(AbpAutoMapperModule)
    )]
    public class OrderApApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<OrderApApplicationModule>();
            });
        }
    }
}
