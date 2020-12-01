using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Permissions
{
    public static class BusinessPermissions
    {
        public const string Business = "Business";
        public static class BusinessCrudPm
        {
            public const string Default = Business + ".Business";
            public const string Delete = Default + ".Delete";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
        }

    }
}
