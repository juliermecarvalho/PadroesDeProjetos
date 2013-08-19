using System;

namespace PadroesDeProjetos.Strategy
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            var calculo = imposto.Calcula(orcamento);
            Console.WriteLine("PadroesDeProjetos.Strategy: " + calculo);
        }

      
    }
}
