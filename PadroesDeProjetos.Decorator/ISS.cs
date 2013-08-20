namespace PadroesDeProjetos.Decorator
{
    public class ISS : Imposto
    {
        public ISS(Imposto imposto) : base(imposto) 
        { }

        public ISS()
        { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor*0.06 + CalculoDoOutroImposto(orcamento);
        }

    }
}
