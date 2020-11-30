using BoxAp.Localization;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace BoxAp.Permissions
{
    public class BoxApPermissionDefinitionProvider: PermissionDefinitionProvider
    {

        public override void Define(IPermissionDefinitionContext context)
        {
            var productGroup = context.AddGroup(BoxApPermissions.Group, L("BoxAp"), MultiTenancySides.Tenant);
            var product = productGroup.AddPermission(BoxApPermissions.BoxAp.Default, L("BoxAp"));
            product.AddChild(BoxApPermissions.BoxAp.Update, L("Edit"));
            product.AddChild(BoxApPermissions.BoxAp.Delete, L("Delete"));
            product.AddChild(BoxApPermissions.BoxAp.Create, L("Create"));

        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BoxApResource>(name);
        }
    }
}
