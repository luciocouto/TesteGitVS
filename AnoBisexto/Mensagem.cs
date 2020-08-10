using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnoBisexto
{
    public class Mensagem
    {
        public string CriarMensagemAnoBisexto(int aAno, bool aEhBisexto)
        {
            string mensagemBisexto = aEhBisexto ? " é bisexto." : " não é bisexto.";

            string mensagem = $"o Ano {aAno} {mensagemBisexto} ";

            return mensagem;
        }
    }
}
