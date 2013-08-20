using System;

namespace PadroesDeProjetos.State
{
    public class Aprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor*0.02;
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamente já esta em estado de aprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento não pode ser repovado agora");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}