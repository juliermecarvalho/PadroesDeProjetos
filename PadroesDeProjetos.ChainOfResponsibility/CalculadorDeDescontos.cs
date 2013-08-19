namespace PadroesDeProjetos.ChainOfResponsibility
{
    public class CalculadorDeDescontos
    {

        public double Calcula(Orcamento orcamento)
        {
            IDesconto descontoPorCincoItens = new DescontoPorCincoItens();
            IDesconto descontoPorMaisDeQuinhentosReais = new DescontoPorMaisDeQuinhentosReais();
            IDesconto semDesconto = new SemDesconto();


            descontoPorCincoItens.Proximo = descontoPorMaisDeQuinhentosReais;
            descontoPorMaisDeQuinhentosReais.Proximo = semDesconto;

            return descontoPorCincoItens.Desconta(orcamento);
        }

    }
}
