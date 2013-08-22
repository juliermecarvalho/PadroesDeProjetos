using System;
using System.Collections.Generic;

namespace PadroesDeProjetos.Observer
{
    public class NotaFiscalBuilder
    {
        private IList<ItemDaNota> _todosItens = new List<ItemDaNota>();
        protected double Impostos { get; set; }
        protected double ValorTotal { get; set; }        
        protected string Cnpj { get; set; }
        protected string RazaoSocial { get; set; }
        protected string Observacoes { get; set; }
        protected DateTime Data { get; set; }
        protected IList<ItemDaNota> TodosItens
        {
            get { return _todosItens; }
            set { _todosItens = value; }
        }

        private readonly IList<IAcaoAposGerarNota> _acaoAposGerarNotas = new List<IAcaoAposGerarNota>();

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder AdicionaAcao(IAcaoAposGerarNota novaAcao)
        {
            this._acaoAposGerarNotas.Add(novaAcao);
            return this;
        }

        public NotaFiscalBuilder ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(String observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            this.Data = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            this.TodosItens.Add(item);
            this.ValorTotal += item.Valor;
            this.Impostos += item.Valor*0.05;
            return this;
        }

        public NotaFiscal Constroi()
        {
            var notaFical = new NotaFiscal(this.RazaoSocial, this.Cnpj, this.Data, this.ValorTotal, this.Impostos, this.Observacoes, this.TodosItens);

           // EnviaPorEmail(notaFical);
           // SalvaNoBanco(notaFical);
           // EnviarPorSms(notaFical);

            foreach (var acaoAposGerarNota in _acaoAposGerarNotas)
            {
                acaoAposGerarNota.Executa(notaFical);
            }

            return notaFical;
        }

      

      

     
    }
}
