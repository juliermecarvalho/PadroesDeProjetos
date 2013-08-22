using System;

namespace PadroesDeProjetos.Observer
{
    public class EnviadorDeSms : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFical)
        {
            Console.WriteLine("Enviar por Sms");
        }
    }
}