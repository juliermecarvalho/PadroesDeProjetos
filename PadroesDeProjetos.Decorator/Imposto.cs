namespace PadroesDeProjetos.Decorator
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }

        protected Imposto(Imposto imposto)
        {
            OutroImposto = imposto;
        }

        protected Imposto()
        {
            OutroImposto = null;
        }

        public abstract double Calcula(Orcamento orcamento);

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) return 0;
            return OutroImposto.Calcula(orcamento);
        }
    }
}
