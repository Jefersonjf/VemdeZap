using VemdeZap.Domain.Entities.Base;

namespace VemdeZap.Domain.Entities
{
    public class Campanha : EntityBase
    {
        public string nome { get; set; }
        public Usuario Usuario { get; set; }
    }
}
