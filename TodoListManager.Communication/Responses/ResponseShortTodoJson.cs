using TodoListManager.Communication.Enums;

namespace TodoListManager.Communication.Responses;

public class ResponseShortTodoJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateOnly Deadline { get; set; }
    public TodoPriority Priority { get; set; }
    public TodoStatus Status { get; set; }
}
