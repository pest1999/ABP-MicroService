using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Permissions
{
    public static class BusinessPermissions
    {
        public const string Business = "Business";

        /// <summary>
        /// 测试用
        /// </summary>
        public static class Test
        {
            public const string Default = Business + ".Test";
            public const string Delete = Default + ".Delete";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";

        }

    }
}
