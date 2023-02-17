using Microsoft.EntityFrameworkCore;
using Persistance.Data;

namespace WebAPI.Extensions
{
    public static class AddDbContextExtension
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddDbContext<DatabaseContext>(options =>
            {
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                options.UseNpgsql(connectionString, opt =>
                {
                    opt.MigrationsAssembly("Persistance");
                });
            });
            return services;
        }
    }
}
