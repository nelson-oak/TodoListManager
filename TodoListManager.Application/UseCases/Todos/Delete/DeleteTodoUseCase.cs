namespace TodoListManager.Application.UseCases.Todos.Delete;

public class DeleteTodoUseCase
{
    public void Execute(int id)
    {
        Console.WriteLine($"Deleted: {id}");
    }
}
