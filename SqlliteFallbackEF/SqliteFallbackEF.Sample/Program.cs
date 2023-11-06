using Microsoft.EntityFrameworkCore;
using SqliteFallbackEF.Sample;
using SqliteFallbackEF.Sample.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RepositoryContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"))
);

// Add services to the container.
var app = builder.Build();

app.RegisterControllers();

app.Run();