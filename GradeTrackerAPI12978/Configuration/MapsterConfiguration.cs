using GradeTracker12978.DAL.Data.DTOs.Assignments;
using GradeTracker12978.DAL.Data.DTOs.Modules;
using GradeTracker12978.DAL.Data.Entities;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace GradeTrackerAPI12978.Configuration
{
    public static class MapsterConfiguration
    {
        public static void ConfigureMapster()
        {
            TypeAdapterConfig<Assignment12978, AssignmentGetDTO12978>.NewConfig()
                .Map(dest => dest.AssignmentTypeName, src => src.AssignmentType.Name)
                .Map(dest => dest.ModuleTitle, src => src.Module.Title);

            TypeAdapterConfig<Assignment12978, AssignmentCreateDTO12978>.NewConfig()
                .Map(dest => dest.AssignmentTypeId, src => src.AssignmentType.Id)
                .Map(dest => dest.ModuleId, src => src.Module.Id);

            TypeAdapterConfig<LearningModule12978, ModuleGetDTO12978>.NewConfig()
                .Map(dest => dest.Assignments, src => src.Assignments.Select(a => a.Title).ToList());
        }
    }
}
