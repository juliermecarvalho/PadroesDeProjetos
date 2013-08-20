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
            return OutroImposto == null ? 0 : OutroImposto.Calcula(orcamento);
        }
    }
}
