using System;
using System.Collections.Generic;

namespace PadroesDeProjetos.State
{
    public class Orcamento
    {

        public double Valor { get;  set; }
        public IList<Item> Itens { get; private set; }
        public IEstadoDeUmOrcamento EstadoAtual { get; set; }

        public Orcamento(Double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
            EstadoAtual = new EmAprovacao();
        }

        public void AdicionaItem(Item item)
        {
            this.Itens.Add(item);
        }


        public void AplicaDescontoExtra()
        {
           EstadoAtual.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}
