using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace BoxApp.EntityFrameworkCore
{
    public static class BoxAppDbContextModelCreatingExtensions
    {
        public static void ConfigureBoxApp(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

        }
    }
}
