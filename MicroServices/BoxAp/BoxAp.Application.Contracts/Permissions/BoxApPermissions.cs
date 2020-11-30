using System;
using System.Collections.Generic;
using System.Text;

namespace BoxAp.Permissions
{
    public static class BoxApPermissions
    {
        public const string Group = "BoxAp";

        public static class BoxAp
        {
            public const string Default = Group + ".BoxAp";
            public const string Delete = Default + ".Delete";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
        }

    }
}
