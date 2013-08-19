namespace PadroesDeProjetos.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IImposto iss = new ISS();

            IImposto icms = new ICMS();

            var orcamento = new Orcamento(500.0);


            var calculador = new CalculadorDeImpostos();


            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, icms);
        }
    }
}
