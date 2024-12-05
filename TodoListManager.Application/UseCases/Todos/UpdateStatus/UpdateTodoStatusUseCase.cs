using TodoListManager.Communication.Requests;

namespace TodoListManager.Application.UseCases.Todos.UpdateStatus;

public class UpdateTodoStatusUseCase
{
    public void Execute(int id, RequestUpdateTodoStatusJson request)
    {
        Console.WriteLine($"Update Statud: {id}, {request.Status}");
    }
}
