using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Product.EntityFrameworkCore
{
    [ConnectionStringName("Product")]
    public class ProductDbContext : AbpDbContext<ProductDbContext>
    {

        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ConfigureProduct();
        }
    }
}
