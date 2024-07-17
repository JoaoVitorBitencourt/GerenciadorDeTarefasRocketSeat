using Gerenciador.Application.UseCases.Tarefas.Delete;
using Gerenciador.Application.UseCases.Tarefas.GetAll;
using Gerenciador.Application.UseCases.Tarefas.GetById;
using Gerenciador.Application.UseCases.Tarefas.Register;
using Gerenciador.Application.UseCases.Tarefas.Update;
using Gerenciador.Communication.Requests;
using Gerenciador.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciador.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(List<ResponseTarefa>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult GetAll()
        {
            try
            {
                var useCase = new GetAllTarefasUseCase();

                var response = useCase.Execute();

                if(response.Any())
                    return Ok(response);
                else 
                    return NoContent();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseTarefa), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult GetById(Guid id)
        {
            try
            {
                var useCase = new GetByIdTarefasUseCase();

                var response = useCase.Execute(id);

                if (response is not null)
                    return Ok(response);
                else
                    return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterTarefa), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromBody] RequestTarefaJson request)
        {
            try
            {
                var useCase = new RegisterTarefasUseCase();

                var response = useCase.Execute(request);

                return Created(string.Empty, response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult Update([FromRoute]Guid id, [FromBody] RequestTarefaJson request)
        {
            try
            {
                var useCase = new UpdateTarefasUseCase();

                useCase.Execute(id, request);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult Delete(Guid id)
        {
            try
            {
                var useCase = new DeleteTarefaByIdUseCase();

                useCase.Execute(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
