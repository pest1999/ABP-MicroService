using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;

namespace BoxApp
{
    [DependsOn(
        typeof(BoxAppDomainModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpPermissionManagementApplicationContractsModule)
    )]
    public class BoxAppApplicationContractsModule : AbpModule
    {

    }
}
