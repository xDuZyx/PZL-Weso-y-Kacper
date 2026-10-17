using TaskFlow.Api.Models; 
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok(new{
    application ="TaskFlow API",
    status = "running"
}));
app.MapGet("/api/projects", ()=> Results.Ok(Array.Empty<Project>()));
app.Run();