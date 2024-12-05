using TodoListManager.Communication.Enums;
using TodoListManager.Communication.Responses;

namespace TodoListManager.Application.UseCases.Todos.GetById;

public class GetTodoByIdUseCase
{
    public ResponseTodoJson Execute(int id)
    {
        return new ResponseTodoJson
        {
            Id = id,
            Name = "Some Todo",
            Description = "Some Description",
            Deadline = new DateOnly(year: 2025, month: 3, day: 13),
            Priority = TodoPriority.Medium,
            Status = TodoStatus.InProgress,
        };
    }
}
