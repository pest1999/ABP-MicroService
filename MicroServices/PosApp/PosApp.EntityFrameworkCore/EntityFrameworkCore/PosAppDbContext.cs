using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace PosApp.EntityFrameworkCore
{
    [ConnectionStringName("PosApp")]
    public class PosAppDbContext : AbpDbContext<PosAppDbContext>
    {

        public PosAppDbContext(DbContextOptions<PosAppDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ConfigurePosApp();
        }
    }
}
