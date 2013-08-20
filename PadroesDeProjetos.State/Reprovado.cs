using System;

namespace PadroesDeProjetos.State
{
    public class Reprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos repovados não recebem descontos");
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