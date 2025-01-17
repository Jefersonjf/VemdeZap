﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VemdeZap.Domain.Commands.Usuario.AdicionarUsuario
{
    public class AdicionarUsuarioRequest : IRequest<AdicionarUsuarioResponse>
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
