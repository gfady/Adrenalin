using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistance.Data;
using Persistance.Repositories.Base;

namespace WebAPI.Extensions
{
    public static class AddRepositoryExtension
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<INewRepository, NewRepository>();
            services.AddScoped<IClubRepository, ClubRepository>();
            services.AddScoped<IPromotionRepository, PromotionRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IVisitRepository, VisitRepository>();
            services.AddTransient<IRepositoryManager, RepositoryManager>();
            return services;
        }
    }
}
