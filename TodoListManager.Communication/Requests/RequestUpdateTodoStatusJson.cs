using TodoListManager.Communication.Enums;

namespace TodoListManager.Communication.Requests;

public class RequestUpdateTodoStatusJson
{
    public TodoStatus Status { get; set; }
}
