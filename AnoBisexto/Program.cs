using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnoBisexto
{
    class Program
    {
        static void Main(string[] args)
        {
            var ano = int.Parse(args[0]);

            bool bisexto = AnoUtil.VerificarseAnoEhBisexto(ano);

            string mensagem = new Mensagem().CriarMensagemAnoBisexto(ano, bisexto);

            Console.WriteLine(mensagem);
            Console.ReadKey();
        }       
    }
}
