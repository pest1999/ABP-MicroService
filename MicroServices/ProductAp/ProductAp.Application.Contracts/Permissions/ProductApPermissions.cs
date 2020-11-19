using System;
using System.Collections.Generic;
using System.Text;

namespace ProductAp.Permissions
{
    public static class ProductApPermissions
    {
        public const string Group = "ProductAp";

        public static class Product
        {
            public const string Default = Group + ".Product";
            public const string Delete = Default + ".Delete";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
        }
    }
}
