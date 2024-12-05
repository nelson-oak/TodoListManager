using TodoListManager.Communication.Enums;
using TodoListManager.Communication.Requests;
using TodoListManager.Communication.Responses;

namespace TodoListManager.Application.UseCases.Todos.Register;

public class RegisterTodoUseCase
{
    public ResponseRegisterTodoJson Execute(RequestTodoJson request)
    {
        int id = 1;
        Console.WriteLine($"Created: {id}, {request.Name}, {request.Description}, {request.Priority}, {request.Deadline}, {TodoStatus.InProgress}");

        return new ResponseRegisterTodoJson
        {
            Id = id,
            Name = request.Name,
        };
    }
}
