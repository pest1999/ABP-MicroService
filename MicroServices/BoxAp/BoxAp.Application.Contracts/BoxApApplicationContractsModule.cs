using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;

namespace BoxAp
{
    [DependsOn(
        typeof(BoxApDomainModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpPermissionManagementApplicationContractsModule)
    )]
    public class BoxApApplicationContractsModule : AbpModule
    {

    }
}
