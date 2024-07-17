using Gerenciador.Communication.Enums;

namespace Gerenciador.Communication.Requests
{
    public class RequestTarefaJson
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Priority Prioridade { get; set; }
        public StatusTask Status { get; set; }
    }
}
