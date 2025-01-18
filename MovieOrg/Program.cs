using Microsoft.EntityFrameworkCore;
using MovieOrg.Application;
using MovieOrg.Infraestructure;
using MovieOrg.Infraestructure.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<MovieOrgDbContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("MovieOrgAPIContext")));

builder.Services
    .AddInfraestructureDI()
    .AddApplicationDI();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
