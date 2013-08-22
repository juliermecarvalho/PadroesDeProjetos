using System;
using System.Collections.Generic;

namespace PadroesDeProjetos.Builder
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

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
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
            return new NotaFiscal(this.RazaoSocial, this.Cnpj, this.Data, this.ValorTotal, this.Impostos, this.Observacoes, this.TodosItens);
        }

      
    }
}
