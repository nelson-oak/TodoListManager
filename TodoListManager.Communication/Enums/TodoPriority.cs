using System.Text.Json.Serialization;

namespace TodoListManager.Communication.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TodoPriority
{
    Low = 0,
    Medium = 1,
    High = 2,
}
