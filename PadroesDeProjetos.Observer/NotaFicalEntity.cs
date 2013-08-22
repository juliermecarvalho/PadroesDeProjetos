using System;

namespace PadroesDeProjetos.Observer
{
    public class NotaFicalEntity : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFical)
        {
            Console.WriteLine("Salvar no banco de dados");
        }
    }
}