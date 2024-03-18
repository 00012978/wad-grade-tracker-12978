using GradeTrackerAPI12978.Data;
using GradeTrackerAPI12978.Data.DTOs.Assignments;
using GradeTrackerAPI12978.Data.DTOs.Modules;
using GradeTrackerAPI12978.Entities;
using Mapster;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MainDbContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("SqlServerConnection")));

ConfigureMapster();
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

void ConfigureMapster()
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