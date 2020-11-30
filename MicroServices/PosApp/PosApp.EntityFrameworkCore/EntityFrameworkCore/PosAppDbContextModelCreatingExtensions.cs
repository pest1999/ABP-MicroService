using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace PosApp.EntityFrameworkCore
{
    public static class PosAppDbContextModelCreatingExtensions
    {
        public static void ConfigurePosApp(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

        }
    }
}
