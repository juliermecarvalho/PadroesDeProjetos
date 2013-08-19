using System;
using System.Collections.Generic;

namespace PadroesDeProjetos.ChainOfResponsibility
{
    public class Orcamento
    {

        public double Valor { get; private set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento(Double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            this.Itens.Add(item);
        }



        
    }
}
