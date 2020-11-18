using Microsoft.EntityFrameworkCore;
using OrderAp.Orders;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace OrderAp.EntityFrameworkCore
{
    [ConnectionStringName("OrderAp")]
    public class OrderApDbContext : AbpDbContext<OrderApDbContext>
    {
        public DbSet<Order> Orders { get; set; }

        public OrderApDbContext(DbContextOptions<OrderApDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ConfigureOrderAp();
        }
    }
}
