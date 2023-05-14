using Microsoft.EntityFrameworkCore;
using StoreManager.Domain.InventoryAgg;
using StoreManager.Domain.ProductAgg;
using StoreManager.Infrastrue.EFCore.Mapping;

namespace StoreManager.Infrastrue.EFCore
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }



        public DbSet<Product> Products { get; set; }
        public DbSet<Inventory> Inventories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assamble = typeof(ProductMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assamble);
            base.OnModelCreating(modelBuilder);
        }


    }
}
