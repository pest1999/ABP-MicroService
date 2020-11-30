using System;
using System.Collections.Generic;
using System.Text;

namespace PosApp.Permissions
{
    public static class PosAppPermissions
    {
        public const string Group = "PosApp";

        public static class PosApp
        {
            public const string Default = Group + ".PosApp";
            public const string Delete = Default + ".Delete";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
        }

    }
}
