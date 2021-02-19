using ITCraft_TrialTask.IRepository;
using ITCraft_TrialTask.Models;
using ITCraft_TrialTask.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ITCraft_TrialTask.Extensions
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<DbContext, ItCraftDbContext>();

            services.AddScoped(typeof(IGenericRepository<>), typeof (Repository<>));
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
