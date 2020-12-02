using BoxApp.Boxes;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace BoxApp.EntityFrameworkCore
{
    [ConnectionStringName("BoxApp")]
    public class BoxAppDbContext : AbpDbContext<BoxAppDbContext>
    {
        public DbSet<Box> Boxes { get; set; }

        public BoxAppDbContext(DbContextOptions<BoxAppDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ConfigureBoxApp();
        }
    }
}
