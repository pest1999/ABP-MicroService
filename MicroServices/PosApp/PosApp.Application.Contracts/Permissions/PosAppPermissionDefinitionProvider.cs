using PosApp.Localization;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace PosApp.Permissions
{
    public class PosAppPermissionDefinitionProvider: PermissionDefinitionProvider
    {

        public override void Define(IPermissionDefinitionContext context)
        {
            var productGroup = context.AddGroup(PosAppPermissions.Group, L("PosApp"), MultiTenancySides.Tenant);
            var product = productGroup.AddPermission(PosAppPermissions.PosApp.Default, L("PosApp"));
            product.AddChild(PosAppPermissions.PosApp.Update, L("Edit"));
            product.AddChild(PosAppPermissions.PosApp.Delete, L("Delete"));
            product.AddChild(PosAppPermissions.PosApp.Create, L("Create"));

        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<PosAppResource>(name);
        }
    }
}
