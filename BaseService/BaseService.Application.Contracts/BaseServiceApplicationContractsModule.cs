using BoxApp;
using Business;
using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;

namespace BaseService
{
    [DependsOn(
        typeof(BaseServiceDomainModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpPermissionManagementApplicationContractsModule),
        typeof(BoxAppApplicationContractsModule),
        typeof(BusinessApplicationContractsModule)
    )]
    public class BaseServiceApplicationContractsModule : AbpModule
    {
    }
}
