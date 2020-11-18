using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;

namespace Order
{
    [DependsOn(
        typeof(OrderDomainModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpPermissionManagementApplicationContractsModule)
    )]
    public class OrderApplicationContractsModule : AbpModule
    {

    }
}
