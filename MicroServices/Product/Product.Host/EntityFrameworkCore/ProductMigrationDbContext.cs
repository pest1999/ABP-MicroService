using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Product.EntityFrameworkCore
{
    public class ProductMigrationDbContext : AbpDbContext<ProductMigrationDbContext>    
    {
        public ProductMigrationDbContext(
            DbContextOptions<ProductMigrationDbContext> options
            ) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureProduct();
        }
    }
}
