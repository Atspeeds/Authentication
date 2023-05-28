using AccountManagement.Application;
using AccountManagement.Application.Contract.Role;
using AccountManagement.Application.Contract.User;
using AccountManagement.Domain.RoleAgg;
using AccountManagement.Domain.UserAgg;
using AccountManagement.Infrastrue.EfCore;
using AccountManagement.Infrastrue.EfCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AccountManagement.Infrastrue.Configuration
{
    public class AccountBootstraper
    {
        public static void Config(IServiceCollection services, string connection)
        {
            //User
            services.AddTransient<IUserApplication,UserApplication>();
            services.AddTransient<IUserRepository, UserRepository>();
            //Role
            services.AddTransient<IRoleApplication, RoleApplication>();
            services.AddTransient<IRoleRepository, RoleRepository>();

            services.AddDbContext<AccountContext>(options =>
            {
                options.UseSqlServer(connection);
            });
        }
    }
}
