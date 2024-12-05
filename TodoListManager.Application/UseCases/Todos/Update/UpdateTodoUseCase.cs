using TodoListManager.Communication.Enums;
using TodoListManager.Communication.Requests;

namespace TodoListManager.Application.UseCases.Todos.Update;

public class UpdateTodoUseCase
{
    public void Execute(int id, RequestTodoJson request)
    {
        Console.WriteLine($"Updated: {id}, {request.Name}, {request.Description}, {request.Priority}, {request.Deadline}");
    }
}
