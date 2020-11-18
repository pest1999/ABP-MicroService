using Microsoft.EntityFrameworkCore;
using ProductAp.Products;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ProductAp.EntityFrameworkCore
{
    [ConnectionStringName("ProductAp")]
    public class ProductApDbContext : AbpDbContext<ProductApDbContext>
    {
        public DbSet<Product> Products { get; set; }

        public ProductApDbContext(DbContextOptions<ProductApDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ConfigureProductAp();
        }
    }
}
