using Business.Localization;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Business.Permissions
{
    public class BusinessPermissionDefinitionProvider: PermissionDefinitionProvider
    {

        public override void Define(IPermissionDefinitionContext context)
        {
            var business = context.AddGroup(BusinessPermissions.Business, L("Business"), MultiTenancySides.Tenant);

            var job = business.AddPermission(BusinessPermissions.BusinessCrudPm.Default, L("Business"));
            job.AddChild(BusinessPermissions.BusinessCrudPm.Update, L("Edit"));
            job.AddChild(BusinessPermissions.BusinessCrudPm.Delete, L("Delete"));
            job.AddChild(BusinessPermissions.BusinessCrudPm.Create, L("Create"));

        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BusinessResource>(name);
        }
    }
}
