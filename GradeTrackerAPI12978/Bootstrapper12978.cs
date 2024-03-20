using GradeTracker12978.DAL.Repositories.Assignments;
using GradeTracker12978.DAL.Repositories.AssignmentTypes;
using GradeTracker12978.DAL.Repositories.LearningModules;

namespace GradeTrackerAPI12978
{
    public static class Bootstrapper12978
    {
        public static IServiceCollection RegisterServices(this IServiceCollection service, IConfiguration configuration = null)
        {
            service
                .AddAssignmentRepository()
                .AddModuleRepository()
                .AddAssignmentTypeRepository();

            return service;
        }
    }
}
