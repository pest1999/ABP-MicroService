using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Order.EntityFrameworkCore
{
    [ConnectionStringName("Order")]
    public class OrderDbContext : AbpDbContext<OrderDbContext>
    {

        public OrderDbContext(DbContextOptions<OrderDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ConfigureOrder();
        }
    }
}
