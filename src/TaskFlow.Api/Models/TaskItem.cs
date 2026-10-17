namespace TaskFlow.Api.Models;
public class TaskItem {
    public Guid Id {get; set; } = Guid.NewGuid();
    public required string Title {get; set;} 
    public string? Description { get; set;}
    public TaskStatus Status {get; set;} = TaskStatus.Todo;
    public DateTime CreatedAt {get; set;} = DateTime.UtcNow;
    public Guid ProjectId {get; set;}
    public Project? Project {get; set;}
    public List<Comment> Comments {get; set;} = [];
}