using GradeTracker12978.DAL.Repositories.Assignments;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker12978.DAL.Repositories.AssignmentTypes
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddAssignmentTypeRepository(this IServiceCollection services)
        {
            return services
                .AddScoped<IAssignmentTypeRepository, AssignmentTypeRepository>();
        }
    }
}
