using Microsoft.Extensions.DependencyInjection;

namespace GradeTracker12978.DAL.Repositories.Assignments
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddAssignmentRepository(this IServiceCollection services)
        {
            return services
                .AddScoped<IAssignmentRepository, AssignmentRepository>();
        }
    }
}
