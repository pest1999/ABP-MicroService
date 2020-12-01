using BoxApp.Localization;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace BoxApp.Permissions
{
    public class BoxAppPermissionDefinitionProvider: PermissionDefinitionProvider
    {

        public override void Define(IPermissionDefinitionContext context)
        {
            var boxApp = context.AddGroup(BoxAppPermissions.BoxApp, L("BoxApp"), MultiTenancySides.Tenant);

            var job = boxApp.AddPermission(BoxAppPermissions.BoxAppCrudPm.Default, L("BoxApp"));
            job.AddChild(BoxAppPermissions.BoxAppCrudPm.Update, L("Edit"));
            job.AddChild(BoxAppPermissions.BoxAppCrudPm.Delete, L("Delete"));
            job.AddChild(BoxAppPermissions.BoxAppCrudPm.Create, L("Create"));
        }

        

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BoxAppResource>(name);
        }
    }
}
