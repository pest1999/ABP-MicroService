using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;

namespace ProductAp
{
    [DependsOn(
        typeof(ProductApDomainModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpPermissionManagementApplicationContractsModule)
    )]
    public class ProductApApplicationContractsModule : AbpModule
    {

    }
}
