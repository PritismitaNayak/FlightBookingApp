using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Load Ocelot configuration
builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

// Add Ocelot services
builder.Services.AddOcelot();
//priti added--need to remove:TODO
var app = builder.Build();

// Use Ocelot middleware
await app.UseOcelot();

app.Run();