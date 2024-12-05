using TodoListManager.Communication.Enums;
using TodoListManager.Communication.Responses;

namespace TodoListManager.Application.UseCases.Todos.GetAll;

public class GetAllTodosUseCase
{
    public ResponseAllTodosJson Execute()
    {
        return new ResponseAllTodosJson
        {
            Todos = new List<ResponseTodoJson>
            {
                new ResponseTodoJson
                {
                    Id = 1,
                    Name = "Some Todo",
                    Description = "Some Description",
                    Deadline = new DateOnly(year: 2025, month: 3, day: 13),
                    Priority = TodoPriority.Medium,
                    Status = TodoStatus.InProgress,
                },
                new ResponseTodoJson
                {
                    Id = 2,
                    Name = "Another Todo",
                    Description = "Another Description",
                    Deadline = new DateOnly(year: 2024, month: 12, day: 25),
                    Priority = TodoPriority.Low,
                    Status = TodoStatus.Done,
                },
                new ResponseTodoJson
                {
                    Id = 3,
                    Name = "Another Todo",
                    Description = "Another Description",
                    Deadline = new DateOnly(year: 2025, month: 1, day: 11),
                    Priority = TodoPriority.High,
                    Status = TodoStatus.Todo,
                },
            }
        };
    }
}
