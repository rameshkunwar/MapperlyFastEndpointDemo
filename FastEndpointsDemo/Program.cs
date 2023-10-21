using FastEndpoints;
using FastEndpoints.Swagger;
using FastEndpointsDemo.Endpoints;
using FastEndpointsDemo.SignalR;
using Serilog;
using System.Text.Json.Serialization;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddFastEndpoints(option =>
{
    option.SourceGeneratorDiscoveredTypes.AddRange(FastEndpointsDemo.DiscoveredTypes.All);
});
builder.Services.SwaggerDocument(o =>
{
    o.DocumentSettings = s =>
    {
        s.Title = "My API";
        s.Version = "v1";
    };
    o.SerializerSettings = s =>
    {
        s.PropertyNamingPolicy = null;
        s.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    };
}); //define a swagger document

builder.Services.AddSignalR();
builder.Services.AddTransient<Create>();

IConfigurationRoot configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile(path: "appsettings.json", optional: false, reloadOnChange: true)
    .Build();

Log.Logger = new LoggerConfiguration()
                        .ReadFrom.Configuration(configuration)
                        .CreateLogger();

builder.Host.UseSerilog();
builder.Services.AddSingleton(Log.Logger);



WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
app.UseDefaultExceptionHandler();

// Configure the HTTP request pipeline.
app.UseAuthorization();
app.UseFastEndpoints();
app.UseSwaggerGen(); //add this

app.MapHub<OrderHub>("/signalr");
app.Run();



