using SqliteFallbackEF.Sample;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var app = builder.Build();

app.RegisterControllers();

app.Run();