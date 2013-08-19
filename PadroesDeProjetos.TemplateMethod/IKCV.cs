using System.Linq;

namespace PadroesDeProjetos.TemplateMethod
{
    public class IKCV: TemplateDeImpostoCondicional
    {
       
        protected bool TemItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            return orcamento.Itens.Any(i => i.Valor > 100);
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && TemItemMaiorQue100ReaisNo(orcamento);
        }
    }
}
