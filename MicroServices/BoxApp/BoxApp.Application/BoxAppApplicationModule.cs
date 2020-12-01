using Volo.Abp.AutoMapper;
using Volo.Abp.BackgroundJobs.Hangfire;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using XCZ;

namespace BoxApp
{
    [DependsOn(
        typeof(BoxAppApplicationContractsModule),
        typeof(AbpHttpClientIdentityModelModule),
        typeof(AbpIdentityHttpApiClientModule),
        typeof(FormApplicationModule),
        typeof(AbpAutoMapperModule),
        typeof(AbpBackgroundJobsHangfireModule)
    )]
    public class BoxAppApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<BoxAppApplicationModule>();
            });
        }
    }
}
