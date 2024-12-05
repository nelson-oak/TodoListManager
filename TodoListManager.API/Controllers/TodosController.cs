using Microsoft.AspNetCore.Mvc;
using TodoListManager.Application.UseCases.Todos.Delete;
using TodoListManager.Application.UseCases.Todos.GetAll;
using TodoListManager.Application.UseCases.Todos.GetById;
using TodoListManager.Application.UseCases.Todos.Register;
using TodoListManager.Application.UseCases.Todos.Update;
using TodoListManager.Application.UseCases.Todos.UpdateStatus;
using TodoListManager.Communication.Requests;
using TodoListManager.Communication.Responses;

namespace TodoListManager.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodosController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(ResponseTodoJson), StatusCodes.Status200OK)]
    public IActionResult GetById()
    {
        var useCase = new GetAllTodosUseCase();
        var response = useCase.Execute();

        return Ok(response);
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTodoJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] int id)
    {
        var useCase = new GetTodoByIdUseCase();
        var response = useCase.Execute(id);

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterTodoJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestTodoJson request)
    {
        var useCase = new RegisterTodoUseCase();
        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType( StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestTodoJson request)
    {
        var useCase = new UpdateTodoUseCase();
        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpPatch]
    [Route("{id}/status")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult UpdateStatus([FromRoute] int id, [FromBody] RequestUpdateTodoStatusJson request)
    {
        var useCase = new UpdateTodoStatusUseCase();
        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute] int id)
    {
        var useCase = new DeleteTodoUseCase();
        useCase.Execute(id);

        return NoContent();
    }
}
