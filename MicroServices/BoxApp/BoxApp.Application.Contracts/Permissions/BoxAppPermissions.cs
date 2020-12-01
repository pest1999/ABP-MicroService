using System;
using System.Collections.Generic;
using System.Text;

namespace BoxApp.Permissions
{
    public static class BoxAppPermissions
    {
        public const string BoxApp = "BoxApp";
        public static class BoxAppCrudPm
        {
            public const string Default = BoxApp + ".BoxApp";
            public const string Delete = Default + ".Delete";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
        }

    }
}
