using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace ProductAp.EntityFrameworkCore
{
    public static class ProductApDbContextModelCreatingExtensions
    {
        public static void ConfigureProductAp(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

        }
    }
}
