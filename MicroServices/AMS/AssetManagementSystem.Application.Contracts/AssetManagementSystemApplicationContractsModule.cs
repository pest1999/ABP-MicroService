using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;

namespace AssetManagementSystem
{
    [DependsOn(
        typeof(AssetManagementSystemDomainModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpPermissionManagementApplicationContractsModule)
    )]
    public class AssetManagementSystemApplicationContractsModule : AbpModule
    {
    }
}
