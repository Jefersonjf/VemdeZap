using VemdeZap.Domain.Entities.Base;

namespace VemdeZap.Domain.Entities
{
    public class Contato : EntityBase
    {
        public Usuario Usuario { get; set; }
        public string nome { get; set; }
        public string Telefone { get; set; }
        public int Nicho { get; set; }
    }
}
