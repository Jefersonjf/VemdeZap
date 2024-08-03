using VemdeZap.Domain.Entities.Base;

namespace VemdeZap.Domain.Entities
{
    public class Usuario : EntityBase
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
