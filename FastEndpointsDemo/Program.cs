using FastEndpoints;
using FastEndpoints.Swagger;
using FastEndpointsDemo.Endpoints;
using FastEndpointsDemo.SignalR;
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

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
app.UseDefaultExceptionHandler();

// Configure the HTTP request pipeline.
app.UseAuthorization();
app.UseFastEndpoints();
app.UseSwaggerGen(); //add this

app.MapHub<OrderHub>("/signalr");
app.Run();



