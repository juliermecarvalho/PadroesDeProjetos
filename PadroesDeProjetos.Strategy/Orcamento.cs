using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
