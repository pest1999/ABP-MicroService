using BoxAp.Products;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using XCZ.EntityFrameworkCore;

namespace BoxAp.EntityFrameworkCore
{
    public class BoxApMigrationDbContext : AbpDbContext<BoxApMigrationDbContext>    
    {
        public DbSet<Product> Products { get; set; }

        public BoxApMigrationDbContext(
            DbContextOptions<BoxApMigrationDbContext> options
            ) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureForm();
            modelBuilder.ConfigureBoxAp();
        }
    }
}
