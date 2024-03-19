using GradeTracker12978.DAL.Data;
using GradeTrackerAPI12978;
using GradeTrackerAPI12978.Configuration;
using Microsoft.EntityFrameworkCore;
using FluentValidation.AspNetCore;
using FluentValidation;
using GradeTrackerAPI12978.Validation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
    .AddControllers();

builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssembly(typeof(AssignmentValidator).Assembly);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MainDbContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("SqlServerConnection")));

builder.Services.RegisterServices();

MapsterConfiguration.ConfigureMapster();
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

