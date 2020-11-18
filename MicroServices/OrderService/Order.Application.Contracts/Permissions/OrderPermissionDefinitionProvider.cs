//using Order.Localization;
//using Microsoft.Extensions.Localization;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using Volo.Abp.Authorization.Permissions;
//using Volo.Abp.Localization;
//using Volo.Abp.MultiTenancy;

//namespace Order.Permissions
//{
//    public class OrderPermissionDefinitionProvider: PermissionDefinitionProvider
//    {

//        public override void Define(IPermissionDefinitionContext context)
//        {
//            var business = context.AddGroup(OrderPermissions.Order, L("Order"), MultiTenancySides.Tenant);

//        }

//        private static LocalizableString L(string name)
//        {
//            return LocalizableString.Create<OrderResource>(name);
//        }
//    }
//}
