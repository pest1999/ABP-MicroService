using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Product.EntityFrameworkCore
{
    public static class ProductDbContextModelCreatingExtensions
    {
        public static void ConfigureProduct(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

        }
    }
}
