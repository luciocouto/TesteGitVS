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
            int resultado;

            var ano = int.Parse(args[0]);

            bool bisexto = AnoUtil.VerificarseAnoEhBisexto(ano);

            string mensagemResultado = bisexto ? " é bisexto." : " não é bisexto.";

            string mensagem = $"o Ano {args[0]} {mensagemResultado} ";

            Console.WriteLine(mensagem);
            Console.ReadKey();
        }       
    }
}
