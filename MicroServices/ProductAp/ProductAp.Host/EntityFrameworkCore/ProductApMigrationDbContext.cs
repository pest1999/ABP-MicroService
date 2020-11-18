using Microsoft.EntityFrameworkCore;
using ProductAp.Products;
using Volo.Abp.EntityFrameworkCore;

namespace ProductAp.EntityFrameworkCore
{
    public class ProductApMigrationDbContext : AbpDbContext<ProductApMigrationDbContext>    
    {
        public DbSet<Product> Products { get; set; }

        public ProductApMigrationDbContext(
            DbContextOptions<ProductApMigrationDbContext> options
            ) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureProductAp();
        }
    }
}
