//using Product.Localization;
//using Microsoft.Extensions.Localization;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using Volo.Abp.Authorization.Permissions;
//using Volo.Abp.Localization;
//using Volo.Abp.MultiTenancy;

//namespace Product.Permissions
//{
//    public class ProductPermissionDefinitionProvider: PermissionDefinitionProvider
//    {

//        public override void Define(IPermissionDefinitionContext context)
//        {
//            var business = context.AddGroup(ProductPermissions.Product, L("Product"), MultiTenancySides.Tenant);

//        }

//        private static LocalizableString L(string name)
//        {
//            return LocalizableString.Create<ProductResource>(name);
//        }
//    }
//}
