using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Exceptions
{
    public class JogoNaoCadastrado : Exception
    {
        public JogoNaoCadastrado() : base ("Jogo não está cadastrado")
        {
        }
    }
}
