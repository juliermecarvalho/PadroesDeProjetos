using System;

namespace PadroesDeProjetos.State
{
    public class Finalizado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Or�amentos finalizados n�o recebem descontos");
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
            throw new Exception("Or�amento n�o pode ser finalizado agora");
        }
    }
}