namespace PadroesDeProjetos.ChainOfResponsibility
{
    public class Item
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }


        public Item(double valor, string nome)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}