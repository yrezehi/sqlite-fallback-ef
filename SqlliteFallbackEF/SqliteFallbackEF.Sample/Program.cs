using Microsoft.EntityFrameworkCore;
using SqliteFallbackEF.Sample;
using SqliteFallbackEF.Sample.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RepositoryContext>(options =>
    options.UseInMemoryDatabase("Default")
);

// Add services to the container.
var app = builder.Build();

app.RegisterControllers();

app.Run();