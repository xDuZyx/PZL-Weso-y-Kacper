 namespace TaskFlow.Api.Models;

public class Project {
    public Guid Id { get; set; } =Guid.NewGuid();
    public required string Name {get; set;}
    public string? Description {get; set;}
    public DateTime CreatedAt {get; set;} = DateTime.UtcNow;
    public List<TaskItem> Tasks {get; set;} =[];

} 
/* using TaskFlow.Api.Models; 
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok(new{
    application ="TaskFlow API",
    status = "running"
}));
app.MapGet("/api/projects", ()=> Results.Ok(Array.Empty<Project>()));
app.Run();*/