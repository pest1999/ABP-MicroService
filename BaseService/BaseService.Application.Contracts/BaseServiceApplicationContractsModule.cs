using BoxAp;
using Business;
using PosApp;
using ProductAp;
using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;

namespace BaseService
{
    [DependsOn(
        typeof(BaseServiceDomainModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpPermissionManagementApplicationContractsModule),
        typeof(BusinessApplicationContractsModule),
        typeof(ProductApApplicationContractsModule),
        typeof(BoxApApplicationContractsModule),
        typeof(PosAppApplicationContractsModule)

    )]
    public class BaseServiceApplicationContractsModule : AbpModule
    {
    }
}
