using Gerenciador.Communication.Enums;
using Gerenciador.Communication.Responses;

namespace Gerenciador.Application.UseCases.Tarefas.GetAll
{
    public class GetAllTarefasUseCase
    {
        public List<ResponseTarefa> Execute()
        {
            return [
                new ResponseTarefa
                {
                    Id = Guid.NewGuid(),
                    Descricao = "teste",
                    Nome = "teste",
                    Prioridade = Priority.Low,
                    Status = StatusTask.Ready
                }
            ];
        }
    }
}
