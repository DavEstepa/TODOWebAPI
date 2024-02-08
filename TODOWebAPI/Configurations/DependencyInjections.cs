using TODOWebAPI.Domain.Interfaces;
using TODOWebAPI.Repository;

namespace TODOWebAPI.Configurations
{
    public static class DependencyInjections
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddSingleton<ITODORepository, TODORepository>();
        }
    }
}
