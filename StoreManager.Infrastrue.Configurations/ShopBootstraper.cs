using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StoreManager.Application;
using StoreManager.Application.Contract.Product;
using StoreManager.Domain.ProductAgg;
using StoreManager.Infrastrue.EFCore;
using StoreManager.Infrastrue.EFCore.Repository;

namespace StoreManager.Infrastrue.Configurations
{
    public class ShopBootstraper
    {
        public static void Config(IServiceCollection services,string connectionstring)
        {

            services.AddTransient<IProductApplication, ProductApplication>();
            services.AddTransient<IProductRepository, ProductRepository>();


            services.AddDbContext<ShopContext>(options =>
            {
                options.UseSqlServer(connectionstring);
            });

        }
    }
}
