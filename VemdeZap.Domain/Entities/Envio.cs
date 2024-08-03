using VemdeZap.Domain.Entities.Base;

namespace VemdeZap.Domain.Entities
{
    public class Envio : EntityBase
    {
        public Campanha Campanha { get; set; }
        public Grupo Grupo { get; set; }
        public Contato Contato { get; set; }
        public bool Enviado { get; set; }
    }
}
