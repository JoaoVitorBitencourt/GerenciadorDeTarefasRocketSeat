using Gerenciador.Communication.Requests;
using Gerenciador.Communication.Responses;

namespace Gerenciador.Application.UseCases.Tarefas.Register
{
    public class RegisterTarefasUseCase
    {
        public ResponseRegisterTarefa Execute(RequestTarefaJson request)
        {
            return new ResponseRegisterTarefa
            {
                Id = Guid.NewGuid(),
            };
        }
    }
}
