using System;

namespace PadroesDeProjetos.ChainOfResponsibility
{
    public class SemDesconto: IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            Console.WriteLine("Sem Desconto");
            return 0;
        }

    }
}
