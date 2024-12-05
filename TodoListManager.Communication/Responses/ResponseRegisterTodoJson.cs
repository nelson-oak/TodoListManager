using TodoListManager.Communication.Enums;

namespace TodoListManager.Communication.Responses;

public class ResponseRegisterTodoJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
