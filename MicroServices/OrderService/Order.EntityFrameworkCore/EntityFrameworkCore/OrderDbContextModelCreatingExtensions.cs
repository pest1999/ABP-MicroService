using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Order.EntityFrameworkCore
{
    public static class OrderDbContextModelCreatingExtensions
    {
        public static void ConfigureOrder(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

        }
    }
}
