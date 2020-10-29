using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace AssetManagementSystem
{
    [DependsOn(
        typeof(AbpLocalizationModule)
    )]
    public class AssetManagementSystemDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<AssetManagementSystemDomainModule>("AssetManagementSystem");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<AssetManagementSystemDomainModule>("zh-Hans")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization");
            });
        }
    }
}
