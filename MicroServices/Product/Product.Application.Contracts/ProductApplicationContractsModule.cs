using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;

namespace Product
{
    [DependsOn(
        typeof(ProductDomainModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpPermissionManagementApplicationContractsModule)
    )]
    public class ProductApplicationContractsModule : AbpModule
    {

    }
}
