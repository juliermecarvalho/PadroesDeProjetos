using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjetos.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            const string razaoSocial = "razaoSocial";
            const string cnpj = "cnpj";
            const string observacoes = "Observacoes";
            //var dataDeEmissao = DateTime.Now;
            //const int valorBruto = 0;
            //const int impostos = 0;
            
            //var itens = new List<ItemDaNota> {new ItemDaNota("nome", 10)};

            var criador = new NotaFiscalBuilder()
                .ParaEmpresa(razaoSocial)
                .ComCnpj(cnpj)
                .NaDataAtual()
                .ComObservacoes(observacoes)
                .ComItem(new ItemDaNota("nome 01", 10))
                .ComItem(new ItemDaNota("nome 02", 15));



            var nf = criador.Constroi();
        }
    }



}
