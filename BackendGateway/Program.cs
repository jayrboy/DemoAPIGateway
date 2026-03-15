using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Ocelot Basic setup
builder.Configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("ocelot.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables();
builder.Services.AddOcelot(builder.Configuration);

var app = builder.Build();

app.Use(async (context, next) =>
{

    if (context.Request.Path.StartsWithSegments("/"))
    {
        await context.Response.WriteAsync("<h1>" + Environment.MachineName + "</h1>");
        return;
    }
    await next();
});

await app.UseOcelot();

app.Run();