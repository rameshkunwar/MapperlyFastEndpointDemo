using FastEndpoints;
using FastEndpoints.Swagger;

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
}); //define a swagger document

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
app.UseDefaultExceptionHandler();

// Configure the HTTP request pipeline.
app.UseAuthorization();
app.UseFastEndpoints();
app.UseSwaggerGen(); //add this
app.Run();



