using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;

namespace PosApp
{
    [DependsOn(
        typeof(PosAppDomainModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpPermissionManagementApplicationContractsModule)
    )]
    public class PosAppApplicationContractsModule : AbpModule
    {

    }
}
