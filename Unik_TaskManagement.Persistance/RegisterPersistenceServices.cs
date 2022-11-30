using Microsoft.Extensions.DependencyInjection;
using Unik_TaskManagement.Application.Contracts.Persistence;
using Unik_TaskManagement.Persistence.Repositories;

namespace Unik_TaskManagement.Persistence
{
    public static class RegisterPersistenceServices
    {
        public static IServiceCollection AddPersistenceServices ( this IServiceCollection services /*IConfiguration configuration*/ )
        {
            //services.AddDbContext<PostDbContext>(options =>
            //    options.UseSqlServer(configuration.GetConnectionString("PostConnectionString")));

            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
            //services.AddScoped(typeof(IPostRepository), typeof(PostRepository));

            return services;
        }
    }
}
