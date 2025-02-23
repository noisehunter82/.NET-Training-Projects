namespace TodoApi.Models;

// DTO - Data Trasfer Object
// Adds a separation layer between object stored/retrieved from database and the object exchanged with the API client.
// https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio-code#prevent-over-posting
public class TodoItemDTO
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}