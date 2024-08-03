using VemdeZap.Domain.Entities.Base;
using VemdeZap.Domain.Enums;

namespace VemdeZap.Domain.Entities
{
    public class Grupo : EntityBase
    {
        public Usuario Usuario { get; set; }
        public string Nome { get; set; }
        public Enumnicho Nicho { get; set; }
    }
}
