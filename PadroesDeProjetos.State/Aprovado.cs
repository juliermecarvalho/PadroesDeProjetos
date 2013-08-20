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
            throw new Exception("Or�amente j� esta em estado de aprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Or�amento n�o pode ser repovado agora");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}