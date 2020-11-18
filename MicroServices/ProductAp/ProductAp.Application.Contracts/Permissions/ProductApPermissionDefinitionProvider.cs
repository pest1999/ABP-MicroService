//using ProductAp.Localization;
//using Microsoft.Extensions.Localization;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using Volo.Abp.Authorization.Permissions;
//using Volo.Abp.Localization;
//using Volo.Abp.MultiTenancy;

//namespace ProductAp.Permissions
//{
//    public class ProductApPermissionDefinitionProvider: PermissionDefinitionProvider
//    {

//        public override void Define(IPermissionDefinitionContext context)
//        {
//            var business = context.AddGroup(ProductApPermissions.ProductAp, L("ProductAp"), MultiTenancySides.Tenant);

//        }

//        private static LocalizableString L(string name)
//        {
//            return LocalizableString.Create<ProductApResource>(name);
//        }
//    }
//}
