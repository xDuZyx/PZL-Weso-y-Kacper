namespace TaskFlow.Api.Models;
public class Comment {
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Content {get; set; }
    public required string Author {get; set;}
    public DateTime CreatedAt {get; set; }= DateTime.UtcNow;
    public Guid TaskItemId {get; set;}
    public TaskItem? TaskItem {get; set;}
}