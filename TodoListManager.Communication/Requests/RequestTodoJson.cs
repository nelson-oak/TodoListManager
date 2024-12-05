using TodoListManager.Communication.Enums;

namespace TodoListManager.Communication.Requests;

public class RequestTodoJson
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateOnly Deadline { get; set; }
    public TodoPriority Priority { get; set; }
}
