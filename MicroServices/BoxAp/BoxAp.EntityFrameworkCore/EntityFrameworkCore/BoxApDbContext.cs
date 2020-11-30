using BoxAp.Products;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace BoxAp.EntityFrameworkCore
{
    [ConnectionStringName("BoxAp")]
    public class BoxApDbContext : AbpDbContext<BoxApDbContext>
    {
        public DbSet<Product> Products { get; set; }

        public BoxApDbContext(DbContextOptions<BoxApDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ConfigureBoxAp();
        }
    }
}
