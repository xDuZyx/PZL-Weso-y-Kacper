namespace TaskFlow.Api.DTOs;
public class CreateTaskItemDto {
    public required string Title {get; set;}
    public string? Description {get; set;}
    public Guid ProjectId {get; set;}
}