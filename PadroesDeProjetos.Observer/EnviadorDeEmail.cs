using System;

namespace PadroesDeProjetos.Observer
{
    public class EnviadorDeEmail: IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFical)
        {
            Console.WriteLine("Enviar por email");
        }

      
    }
}