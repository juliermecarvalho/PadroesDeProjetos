using System;

namespace PadroesDeProjetos.Strategy
{
    public class Orcamento
    {

        public double Valor { get; private set; }
        public Orcamento(Double valor)
        {
            this.Valor = valor;
        }

        
    }
}
