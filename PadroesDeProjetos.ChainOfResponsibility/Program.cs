using System;

namespace PadroesDeProjetos.ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {

            var calculadorDeDescontos = new CalculadorDeDescontos();

            var orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item(250, "Caneta"));
            orcamento.AdicionaItem(new Item(250, "Lapis"));
            orcamento.AdicionaItem(new Item(250, "Lapis"));
            orcamento.AdicionaItem(new Item(250, "Lapis"));
            //orcamento.AdicionaItem(new Item(250, "Lapis"));
            //orcamento.AdicionaItem(new Item(250, "Lapis"));

            var desconto = calculadorDeDescontos.Calcula(orcamento);



            Console.WriteLine("PadroesDeProjetos.ChainOfResponsibility: " +desconto);


        }
    }
}
