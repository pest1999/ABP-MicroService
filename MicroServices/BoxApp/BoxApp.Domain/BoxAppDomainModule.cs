using BoxApp.Localization;
using BoxApp.MultiTenancy;
using Volo.Abp.AuditLogging;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;
using Volo.Abp.SettingManagement;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace BoxApp
{
    [DependsOn(
        typeof(AbpLocalizationModule),
        typeof(AbpAuditLoggingDomainModule),
        typeof(AbpSettingManagementDomainModule)
    )]
    public class BoxAppDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<BoxAppDomainModule>("BoxApp");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<BoxAppResource>("zh-Hans")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/BoxApp");
            });
        }
    }
}
