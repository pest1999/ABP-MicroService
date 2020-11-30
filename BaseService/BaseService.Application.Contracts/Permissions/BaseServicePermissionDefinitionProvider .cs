using BaseService.Localization;
using OrderAp.Permissions;
using ProductAp.Permissions;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace BaseService.Permissions
{
    public class BaseServicePermissionDefinitionProvider : PermissionDefinitionProvider
    {

        public override void Define(IPermissionDefinitionContext context)
        {
            var business = context.AddGroup(BaseServicePermissions.BaseService, L("BaseService"), MultiTenancySides.Tenant);

            var auditLogging = business.AddPermission(BaseServicePermissions.AuditLogging.Default, L("AuditLogging"));

            var dictionary = business.AddPermission(BaseServicePermissions.DataDictionary.Default, L("DataDictionary"));
            dictionary.AddChild(BaseServicePermissions.DataDictionary.Update, L("Edit"));
            dictionary.AddChild(BaseServicePermissions.DataDictionary.Delete, L("Delete"));
            dictionary.AddChild(BaseServicePermissions.DataDictionary.Create, L("Create"));

            var organization = business.AddPermission(BaseServicePermissions.Organization.Default,L("Organization"));
            organization.AddChild(BaseServicePermissions.Organization.Update, L("Edit"));
            organization.AddChild(BaseServicePermissions.Organization.Delete, L("Delete"));
            organization.AddChild(BaseServicePermissions.Organization.Create, L("Create"));

            var job = business.AddPermission(BaseServicePermissions.Job.Default, L("Job"));
            job.AddChild(BaseServicePermissions.Job.Update, L("Edit"));
            job.AddChild(BaseServicePermissions.Job.Delete, L("Delete"));
            job.AddChild(BaseServicePermissions.Job.Create, L("Create"));

            #region 添加订单权限
            //var orderGroup = context.AddGroup(OrderApPermissions.Group, L("OrderAp"), MultiTenancySides.Tenant);
            //var order = orderGroup.AddPermission(OrderApPermissions.Order.Default, L("Order"));
            //order.AddChild(OrderApPermissions.Order.Update, L("Edit"));
            //order.AddChild(OrderApPermissions.Order.Delete, L("Delete"));
            //order.AddChild(OrderApPermissions.Order.Create, L("Create"));
            #endregion

            #region 添加产品权限
            //var productGroup = context.AddGroup(ProductApPermissions.Group, L("ProductAp"), MultiTenancySides.Tenant);
            //var product = productGroup.AddPermission(ProductApPermissions.Product.Default, L("Product"));
            //product.AddChild(ProductApPermissions.Product.Update, L("Edit"));
            //product.AddChild(ProductApPermissions.Product.Delete, L("Delete"));
            //product.AddChild(ProductApPermissions.Product.Create, L("Create"));
            #endregion

        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BaseServiceResource>(name);
        }
    }
}
