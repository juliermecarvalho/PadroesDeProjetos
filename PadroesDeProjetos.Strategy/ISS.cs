﻿namespace PadroesDeProjetos.Strategy
{
    public class ISS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor*0.6;
        }
    }
}
