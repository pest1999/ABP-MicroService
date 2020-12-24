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
            var businessGroup = context.AddGroup(BusinessPermissions.Business, L("Business"), MultiTenancySides.Tenant);

            var business = businessGroup.AddPermission(BusinessPermissions.Test.Default, L("Business-Test"));
            business.AddChild(BusinessPermissions.Test.Update, L("Business-Edit"));
            business.AddChild(BusinessPermissions.Test.Delete, L("Business-Delete"));
            business.AddChild(BusinessPermissions.Test.Create, L("Business-Create"));

        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BusinessResource>(name);
        }
    }
}
