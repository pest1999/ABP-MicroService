using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using XCZ.EntityFrameworkCore;

namespace PosApp.EntityFrameworkCore
{
    public class PosAppMigrationDbContext : AbpDbContext<PosAppMigrationDbContext>    
    {

        public PosAppMigrationDbContext(
            DbContextOptions<PosAppMigrationDbContext> options
            ) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureForm();
            modelBuilder.ConfigurePosApp();
        }
    }
}
