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
            var productGroup = context.AddGroup(BusinessPermissions.Group, L("Business"), MultiTenancySides.Tenant);
            var product = productGroup.AddPermission(BusinessPermissions.Business.Default, L("Business"));
            product.AddChild(BusinessPermissions.Business.Update, L("Edit"));
            product.AddChild(BusinessPermissions.Business.Delete, L("Delete"));
            product.AddChild(BusinessPermissions.Business.Create, L("Create"));

        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BusinessResource>(name);
        }
    }
}
