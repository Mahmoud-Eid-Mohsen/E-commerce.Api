

using System.Reflection;

namespace Persistance.Data.Contexts
{
   public class StoreDbContext(DbContextOptions<StoreDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; } = default!;
        public DbSet<ProductBrand> ProductBrands { get; set; } = default!;
        public DbSet<ProductTypes> ProductTypes { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
