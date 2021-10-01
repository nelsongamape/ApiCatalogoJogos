using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Exceptions
{
    public class JogoJaCadastrado : Exception
    {
        public JogoJaCadastrado() : base (" Este jogo já está cadastrado")
        {
        }
    }
}
