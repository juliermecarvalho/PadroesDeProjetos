using System;
using System.Collections.Generic;

namespace PadroesDeProjetos.Observer
{
    public class NotaFiscal
    {
        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataDeEmissao, double valorBruto, double impostos, string observacoes, IList<ItemDaNota> itens)
        {
            NRazaoSocial = razaoSocial;
            NCnpj = cnpj;
            NDataDeEmissao = dataDeEmissao;
            NValorBruto = valorBruto;
            NImpostos = impostos;
            NObservacoes = observacoes;
            NItens = itens;
        }

        public string NRazaoSocial { get; set; }
        public string NCnpj { get; set; }
        public DateTime NDataDeEmissao { get; set; }
        public double NValorBruto { get; set; }
        public double NImpostos { get; set; }
        public string NObservacoes { get; set; }
        public IList<ItemDaNota> NItens { get; set; }
       
    }
}
