using System.Text.Json.Serialization;

namespace TodoListManager.Communication.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TodoStatus
{
    Todo = 0,
    InProgress = 1,
    Done = 2,
}
