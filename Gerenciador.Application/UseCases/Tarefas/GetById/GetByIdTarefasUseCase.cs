using Gerenciador.Communication.Enums;
using Gerenciador.Communication.Responses;

namespace Gerenciador.Application.UseCases.Tarefas.GetById
{
    public class GetByIdTarefasUseCase
    {
        public ResponseTarefa Execute(Guid id)
        {
            return new ResponseTarefa
            {
                Id = id,
                Descricao = "teste",
                Nome = "teste",
                Prioridade = Priority.Low,
                Status = StatusTask.Ready
            };
        }
    }
}
