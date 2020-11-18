using Microsoft.EntityFrameworkCore;
using OrderAp.Orders;
using Volo.Abp.EntityFrameworkCore;

namespace OrderAp.EntityFrameworkCore
{
    public class OrderApMigrationDbContext : AbpDbContext<OrderApMigrationDbContext>    
    {
        public DbSet<Order> Orders { get; set; }

        public OrderApMigrationDbContext(
            DbContextOptions<OrderApMigrationDbContext> options
            ) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureOrderAp();
        }
    }
}
