using Microsoft.Extensions.DependencyInjection;

namespace GradeTracker12978.DAL.Repositories.LearningModules
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddModuleRepository(this IServiceCollection services)
        {
            return services
                .AddScoped<IModuleRepository, ModuleRepository>();
        }
    }
}
