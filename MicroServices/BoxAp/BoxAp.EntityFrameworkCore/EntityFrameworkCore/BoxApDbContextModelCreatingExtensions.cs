using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace BoxAp.EntityFrameworkCore
{
    public static class BoxApDbContextModelCreatingExtensions
    {
        public static void ConfigureBoxAp(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

        }
    }
}
