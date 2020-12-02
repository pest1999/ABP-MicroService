using BoxApp.Boxes;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using XCZ.EntityFrameworkCore;

namespace BoxApp.EntityFrameworkCore
{
    public class BoxAppMigrationDbContext : AbpDbContext<BoxAppMigrationDbContext>    
    {
        public DbSet<Box> Boxes { get; set; }

        public BoxAppMigrationDbContext(
            DbContextOptions<BoxAppMigrationDbContext> options
            ) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureForm();
            modelBuilder.ConfigureBoxApp();
        }
    }
}
