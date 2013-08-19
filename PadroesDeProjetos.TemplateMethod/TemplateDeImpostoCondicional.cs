namespace PadroesDeProjetos.TemplateMethod
{
    public abstract class TemplateDeImpostoCondicional: IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return DeveUsarMaximaTaxacao(orcamento) ? MaximaTaxacao(orcamento) : MinimaTaxacao(orcamento);
        }

        public abstract double MinimaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);

    }
}
