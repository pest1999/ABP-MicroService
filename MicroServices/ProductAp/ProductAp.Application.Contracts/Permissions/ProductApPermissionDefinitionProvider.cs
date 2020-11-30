using ProductAp.Localization;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace ProductAp.Permissions
{
    public class ProductApPermissionDefinitionProvider : PermissionDefinitionProvider
    {

        public override void Define(IPermissionDefinitionContext context)
        {
            #region 添加产品权限
            var productGroup = context.AddGroup(ProductApPermissions.Group, L("ProductAp"), MultiTenancySides.Tenant);
            var product = productGroup.AddPermission(ProductApPermissions.Product.Default, L("Product"));
            product.AddChild(ProductApPermissions.Product.Update, L("Edit"));
            product.AddChild(ProductApPermissions.Product.Delete, L("Delete"));
            product.AddChild(ProductApPermissions.Product.Create, L("Create"));
            #endregion

        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ProductApResource>(name);
        }
    }
}
