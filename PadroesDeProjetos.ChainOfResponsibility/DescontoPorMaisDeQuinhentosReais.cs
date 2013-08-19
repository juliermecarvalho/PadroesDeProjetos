using System;

namespace PadroesDeProjetos.ChainOfResponsibility
{
    public class DescontoPorMaisDeQuinhentosReais: IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor >= 500)
            {
                Console.WriteLine("Desconto Por Mais De Quinhentos Reais");
                return orcamento.Valor*0.07;
            }

            return Proximo.Desconta(orcamento);
        }

    }
}
