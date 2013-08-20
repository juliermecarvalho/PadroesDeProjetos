using System;

namespace PadroesDeProjetos.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var iss = new ISS(new ICMS());

            var orcamento = new Orcamento(500);

            var valor = iss.Calcula(orcamento);



            Console.WriteLine(valor);
        }
    }
}
