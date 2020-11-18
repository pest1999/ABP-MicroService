using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace OrderAp.EntityFrameworkCore
{
    public static class OrderApDbContextModelCreatingExtensions
    {
        public static void ConfigureOrderAp(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

        }
    }
}
