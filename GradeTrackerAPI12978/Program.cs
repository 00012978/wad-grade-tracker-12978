using GradeTracker12978.DAL.Data;
using GradeTrackerAPI12978;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

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

