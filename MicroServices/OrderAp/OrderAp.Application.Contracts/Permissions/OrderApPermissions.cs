using System;
using System.Collections.Generic;
using System.Text;

namespace OrderAp.Permissions
{
    public static class OrderApPermissions
    {
        public const string Group = "OrderAp";

        public static class Order
        {
            public const string Default = Group + ".Order";
            public const string Delete = Default + ".Delete";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
        }
    }
}
