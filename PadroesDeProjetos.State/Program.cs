using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjetos.State
{
    class Program
    {
        static void Main(string[] args)
        {

            var reforma = new Orcamento(500);
            Console.WriteLine("Init: " + reforma.Valor);

            reforma.AplicaDescontoExtra();
            Console.WriteLine("AplicaDescontoExtra: " + reforma.Valor);

            reforma.Aprova();

            reforma.AplicaDescontoExtra();
            Console.WriteLine("AplicaDescontoExtra Aprova: " + reforma.Valor);


            reforma.Finaliza();



        }
    }
}
