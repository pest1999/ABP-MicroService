using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Order.EntityFrameworkCore
{
    public class OrderMigrationDbContext : AbpDbContext<OrderMigrationDbContext>    
    {
        public OrderMigrationDbContext(
            DbContextOptions<OrderMigrationDbContext> options
            ) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureOrder();
        }
    }
}
