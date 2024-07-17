using Gerenciador.Communication.Enums;

namespace Gerenciador.Communication.Responses
{
    public class ResponseTarefa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Priority Prioridade { get; set; }
        public StatusTask Status { get; set; }
    }
}
