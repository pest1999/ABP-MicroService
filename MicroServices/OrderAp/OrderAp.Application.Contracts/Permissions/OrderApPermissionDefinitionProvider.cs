//using OrderAp.Localization;
//using Microsoft.Extensions.Localization;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using Volo.Abp.Authorization.Permissions;
//using Volo.Abp.Localization;
//using Volo.Abp.MultiTenancy;

//namespace OrderAp.Permissions
//{
//    public class OrderApPermissionDefinitionProvider: PermissionDefinitionProvider
//    {

//        public override void Define(IPermissionDefinitionContext context)
//        {
//            var business = context.AddGroup(OrderApPermissions.OrderAp, L("OrderAp"), MultiTenancySides.Tenant);

//        }

//        private static LocalizableString L(string name)
//        {
//            return LocalizableString.Create<OrderApResource>(name);
//        }
//    }
//}
