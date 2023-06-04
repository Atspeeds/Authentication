using _01_Framework.Infrastrue;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StoreManager.Application;
using StoreManager.Application.Contract.Inventory;
using StoreManager.Application.Contract.Product;
using StoreManager.Domain.InventoryAgg;
using StoreManager.Domain.ProductAgg;
using StoreManager.Infrastrue.Configurations.Permissions;
using StoreManager.Infrastrue.EFCore;
using StoreManager.Infrastrue.EFCore.Repository;

namespace StoreManager.Infrastrue.Configurations
{
    public class ShopBootstraper
    {
        public static void Config(IServiceCollection services,string connectionstring)
        {
            //Product
            services.AddTransient<IProductApplication, ProductApplication>();
            services.AddTransient<IProductRepository, ProductRepository>();

            //Inventory
            services.AddTransient<INventoryApplication, InventoryApplication>();
            services.AddTransient<INventoryRepository, InventoryRepository>();

            //Exposer
            services.AddTransient<IPermissionExposer, StorePermissionExposer>();


            services.AddDbContext<ShopContext>(options =>
            {
                options.UseSqlServer(connectionstring);
            });

        }
    }
}
