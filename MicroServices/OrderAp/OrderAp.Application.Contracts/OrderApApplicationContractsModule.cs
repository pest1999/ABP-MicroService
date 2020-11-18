using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;

namespace OrderAp
{
    [DependsOn(
        typeof(OrderApDomainModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpPermissionManagementApplicationContractsModule)
    )]
    public class OrderApApplicationContractsModule : AbpModule
    {

    }
}
